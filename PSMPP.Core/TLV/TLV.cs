//--------------------------------------------------------------------------
// This project is licensed under the LGPLv3 as detailed in the LICENSE file
//--------------------------------------------------------------------------

using System;
using System.IO;
using System.Linq;

namespace PSMPP.Core.TLV
{
    /// <summary>
    ///     All optional parameters are supplied the following general TLV (Tag, Length, Value) format
    /// </summary>
    public class Tlv
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Tlv" /> class.
        /// </summary>
        /// <param name="tag">The optional parameter</param>
        /// <param name="length">The length of the value</param>
        public Tlv(Tag tag, ushort length)
        {
            Tag = tag;
            Length = length;
        }

        /// <summary>
        ///     Gets the Tag property.
        ///     Used to uniquely identify the particular optional parameter in question
        /// </summary>
        public Tag Tag { get; }

        /// <summary>
        ///     Gets the Length property. Indicates the length of the Value field in octets.
        ///     Note that this length does not include the length of the Tag and Length fields
        /// </summary>
        public ushort Length { get; private set; }

        /// <summary>
        ///     Gets the Value property.
        ///     Contains the actual data for the optional parameter in question
        /// </summary>
        public byte[] RawValue { get; private set; }

        /// <summary>
        ///     Converts a raw byte-array into an instance of this TLV class
        /// </summary>
        /// <param name="input">The byte-array that needs to be converted</param>
        /// <returns>A populated instance of this TLV class</returns>
        public static Tlv Parse(byte[] input)
        {
            // input has to be > 5 bytes (4 bytes for tag & length + > 1 byte for the value)
            if (input.Length < 5)
            {
                throw new Exception("We need at least 5 bytes to build a TLV object");
            }

            var tag = (Tag) BitConverter.ToUInt16(input, 0);
            var len = BitConverter.ToUInt16(input, 2);
            var tlv = new Tlv(tag, len);
            tlv.ParseValue(input, len);
            return tlv;
        }

        /// <summary>
        ///     Gets the byte-array that represents this specific TLV class
        /// </summary>
        /// <returns>A byte-array that represents this TLV object</returns>
        public virtual byte[] GetBytes()
        {
            if (RawValue == null || RawValue.Length != Length)
            {
                throw new Exception("Tlv value length inconsistent with length field or has no data set");
            }

            var stream = new MemoryStream();
            using (var buffer = new BinaryWriter(stream))
            {
                buffer.Write((ushort) Tag);
                buffer.Write(Length);
                buffer.Write(RawValue);
            }

            return stream.ToArray();
        }

        /// <summary>
        ///     Populates the RawValue parameter on this instance from the provided byte-array
        /// </summary>
        /// <param name="input">The byte-array that contains the value we seek</param>
        /// <param name="length">The length of the value in the TLV object</param>
        /// <param name="start">The starting location of the value in the byte-array</param>
        public virtual void ParseValue(byte[] input, int length, int start = 0)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (length < 1)
            {
                throw new ArgumentException("An invalid length argument was supplied", "length");
            }

            RawValue = input.Skip(start).Take(length).ToArray();
            Length = (ushort) length;
        }

        /// <summary>
        ///     An overloaded method for when the byte-array contains ONLY the value
        /// </summary>
        /// <param name="input">The value for this instance of the TLV object</param>
        public void ParseValue(byte[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            ParseValue(input, input.Length);
        }
    }
}