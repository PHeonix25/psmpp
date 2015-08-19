//--------------------------------------------------------------------------
// This project is licensed under the LGPLv3 as detailed in the LICENSE file
//--------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace PSMPP.Core
{
    /// <summary>
    ///     A nice wrapper for a generic exception that includes specific details on what
    ///     part of the SMPP specification was violated
    /// </summary>
    [Serializable]
    public class PduException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PduException" /> class.
        /// </summary>
        /// <param name="errorCode">The error code that was thrown</param>
        public PduException(SmppErrorCode errorCode)
            : this(errorCode, null, null)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PduException" /> class.
        /// </summary>
        /// <param name="errorCode">The error code that was thrown</param>
        /// <param name="message">The custom reason that this exception was thrown</param>
        public PduException(SmppErrorCode errorCode, string message)
            : this(errorCode, message, null)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PduException" /> class.
        /// </summary>
        /// <param name="errorCode">The error code that was thrown</param>
        /// <param name="message">The custom reason that this exception was thrown</param>
        /// <param name="innerException">The nested exception that should be examined</param>
        public PduException(SmppErrorCode errorCode, string message, Exception innerException)
            : base(message, innerException)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        ///     Gets the error code that was generated according to the SMPP protocol
        /// </summary>
        public SmppErrorCode ErrorCode { get; }

        /// <summary>
        ///     Populates a <see cref="SerializationInfo" /> with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo" /> to populate with data.</param>
        /// <param name="context">The destination (see <see cref="StreamingContext" />) for this serialization.</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ErrorCode", ErrorCode);
        }
    }
}