//--------------------------------------------------------------------------
// This project is licensed under the LGPLv3 as detailed in the LICENSE file
//--------------------------------------------------------------------------

namespace PSMPP.Core.TLV
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A nice wrapper for a <see cref="PduException "/> that includes specific details on 
    /// what went wrong inside the TLV (including the appropriate <see cref="SmppErrorCode"/>)
    /// </summary>
    [Serializable]
    public class TlvException : PduException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TlvException" /> class.
        /// </summary>
        public TlvException()
            : this("Error in the optional part of the pdu body") 
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TlvException" /> class.
        /// </summary>
        /// <param name="message">An appropriate message that should assist the consumer</param>
        public TlvException(string message)
            : base(SmppErrorCode.ESME_RINVOPTPARSTREAM, message) 
        {
        }

        /// <summary>
        /// Populates a <see cref="SerializationInfo"/> with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> to populate with data.</param>
        /// <param name="context">The destination (see <see cref="StreamingContext"/>) for this serialization.</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
