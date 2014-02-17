//--------------------------------------------------------------------------
// This project is licensed under the LGPLv3 as detailed in the LICENSE file
//--------------------------------------------------------------------------

namespace PSMPP.Core.TLV
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contains the list of all possible Tag types according to the SMPP v3.4 spec
    /// </summary>
    public enum Tag : ushort
    {
        /// <summary>
        /// The dest_addr_subunit parameter is used to route messages when received by a mobile 
        /// station, for example to a smart card in the mobile station or to an external device
        /// connected to the mobile station
        /// </summary>
        dest_addr_subunit = 0x0005,

        /// <summary>
        /// The dest_network_type parameter is used to indicate a network type associated with 
        /// the destination address of a message. In the case that the receiving system (SMSC) 
        /// does not support the indicated network type, it may treat this a failure and return 
        /// a response PDU reporting a failure
        /// </summary>
        dest_network_type = 0x0006,

        /// <summary>
        /// The dest_bearer_type parameter is used to request the desired bearer for delivery of 
        /// the message to the destination address. In the case that the receiving system (SMSC) 
        /// does not support the indicated bearer type, it may treat this a failure and return a 
        /// response PDU reporting a failure
        /// </summary>
        dest_bearer_type = 0x0007,

        /// <summary>
        /// This parameter defines the telematic interworking to be used by the delivering system 
        /// for the destination address. This is only useful when a specific dest_bearer_type 
        /// parameter has also been specified as the value is bearer dependent. In the case that 
        /// the receiving system (SMSC) does not support the indicated telematic interworking, 
        /// it may treat this a failure and return a response PDU reporting a failure.
        /// </summary>
        dest_telematics_id = 0x0008,

        /// <summary>
        /// The source_addr_subunit parameter is used to indicate where a message originated in 
        /// the mobile station, for example a smart card in the mobile station or an external 
        /// device connected to the mobile station
        /// </summary>
        source_addr_subunit = 0x000D,

        /// <summary>
        /// The source_network_type parameter is used to indicate the network type associated 
        /// with the device that originated the message
        /// </summary>
        source_network_type = 0x000E,

        /// <summary>
        /// The source_bearer_type parameter indicates the wireless bearer over which the message
        /// originated
        /// </summary>
        source_bearer_type = 0x000F,

        /// <summary>
        /// The source_telematics_id parameter indicates the type of telematics interface over 
        /// which the message originated
        /// </summary>
        source_telematics_id = 0x0010,

        /// <summary>
        /// This parameter defines the number of seconds which the sender requests the SMSC to 
        /// keep the message if undelivered before it is deemed expired and not worth delivering. 
        /// If the parameter is not present, the SMSC may apply a default value
        /// </summary>
        qos_time_to_live = 0x0017,

        /// <summary>
        /// The payload_type parameter defines the higher layer PDU type contained in the message 
        /// payload.
        /// </summary>
        payload_type = 0x0019,

        /// <summary>
        /// The additional_status_info_text parameter gives an ASCII textual description of the
        /// meaning of a response PDU. It is to be used by an implementation to allow easy 
        /// diagnosis of problems.
        /// </summary>
        additional_status_info_text = 0x001D,

        /// <summary>
        /// The receipted_message_id parameter indicates the ID of the message being receipted in
        /// an SMSC Delivery Receipt. This is the opaque SMSC message identifier that was returned 
        /// in the message_id parameter of the SMPP response PDU that acknowledged the submission 
        /// of the original message
        /// </summary>
        receipted_message_id = 0x001E,

        /// <summary>
        /// The ms_msg_wait_facilities parameter allows an indication to be provided to an MS that 
        /// there are messages waiting for the subscriber on systems on the PLMN. The indication 
        /// can be an icon on the MS screen or other MMI indication. The ms_msg_wait_facilities can 
        /// also specify the type of message associated with the message waiting indication
        /// </summary>
        ms_msg_wait_facilities = 0x0030,

        /// <summary>
        /// The privacy_indicator indicates the privacy level of the message
        /// </summary>
        privacy_indicator = 0x0201,

        /// <summary>
        /// The source_subaddress parameter specifies a subaddress associated with the originator 
        /// of the message
        /// </summary>
        source_subaddress = 0x0202,

        /// <summary>
        /// The dest_subaddress parameter specifies a subaddress associated with the destination 
        /// of the message
        /// </summary>
        dest_subaddress = 0x0203,

        /// <summary>
        /// A reference assigned by the originating SME to the short message.
        /// </summary>
        user_message_reference = 0x0204,

        /// <summary>
        /// A response code set by the user in a User Acknowledgement/Reply message. The response 
        /// codes are application specific.
        /// </summary>
        user_response_code = 0x0205,

        /// <summary>
        /// The source_port parameter is used to indicate the application port number associated 
        /// with the source address of the message
        /// </summary>
        source_port = 0x020A,

        /// <summary>
        /// The destination_port parameter is used to indicate the application port number associated 
        /// with the destination address of the message
        /// </summary>
        destination_port = 0x020B,

        /// <summary>
        /// The sar_msg_ref_num parameter is used to indicate the reference number for a particular
        /// concatenated short message
        /// </summary>
        sar_msg_ref_num = 0x020C,

        /// <summary>
        /// The language_indicator parameter is used to indicate the language of the short message
        /// </summary>
        language_indicator = 0x020D,

        /// <summary>
        /// The sar_total_segments parameter is used to indicate the total number of short messages
        /// within the concatenated short message
        /// </summary>
        sar_total_segments = 0x020E,

        /// <summary>
        /// The sar_segment_seqnum parameter is used to indicate the sequence number of a particular
        /// short message within the concatenated short message
        /// </summary>
        sar_segment_seqnum = 0x020F,

        /// <summary>
        /// The sc_interface_version parameter is used to indicate the SMPP version supported by the
        /// SMSC. It is returned in the bind response PDUs
        /// </summary>
        sc_interface_version = 0x0210,

        /// <summary>
        /// This parameter controls the presentation indication and screening of the CallBackNumber 
        /// at the mobile station. If present, the callback_num parameter must also be present
        /// </summary>
        callback_num_pres_ind = 0x0302,

        /// <summary>
        /// The callback_num_atag parameter associates an alphanumeric display with the call back number
        /// </summary>
        callback_num_atag = 0x0303,

        /// <summary>
        /// The number_of_messages parameter is used to indicate the number of messages stored in a mailbox
        /// </summary>
        number_of_messages = 0x0304,

        /// <summary>
        /// The callback_num parameter associates a call back number with the message. In TDMA networks, 
        /// it is possible to send and receive multiple callback numbers to/from TDMA mobile stations
        /// </summary>
        callback_num = 0x0381,
        
        /// <summary>
        /// The dpf_result parameter is used in the data_sm_resp PDU to indicate if delivery pending 
        /// flag (DPF) was set for a delivery failure of the short message. If the dpf_result parameter 
        /// is not included in the data_sm_resp PDU, the ESME should assume that DPF is not set.
        /// Currently this parameter is only applicable for the Transaction message mode.
        /// </summary>
        dpf_result = 0x0420,

        /// <summary>
        /// An ESME may use the set_dpf parameter to request the setting of a delivery pending flag (DPF)
        /// for certain delivery failure scenarios, such as "MS is unavailable for message delivery"
        /// The SMSC should respond to such a request with an alert_notification PDU when it detects that
        /// the destination MS has become available. The delivery failure scenarios under which DPF is set 
        /// is SMSC implementation and network implementation specific. If a delivery pending flag is set 
        /// by the SMSC or network (e.g. HLR), then the SMSC should indicate this to the ESME in the 
        /// data_sm_resp message via the dpf_result parameter
        /// </summary>
        set_dpf = 0x0421,

        /// <summary>
        /// The ms_availability_status parameter is used in the alert_notification operation to indicate 
        /// the availability state of the MS to the ESME. If the SMSC does not include the parameter in the
        /// alert_notification operation, the ESME should assume that the MS is in an "available" state
        /// </summary>
        ms_availability_status = 0x0422,

        /// <summary>
        /// The network_error_code parameter is used to indicate the actual network error code for a
        /// delivery failure. The network error code is technology specific
        /// </summary>
        network_error_code = 0x0423,

        /// <summary>
        /// The message_payload parameter contains the user data
        /// </summary>
        message_payload = 0x0424,

        /// <summary>
        /// The delivery_failure_reason parameter is used in the data_sm_resp operation to indicate the
        /// outcome of the message delivery attempt (only applicable for transaction message mode). 
        /// If a delivery failure due to a network error is indicated, the ESME may check the network_error_code
        /// parameter (if present) for the actual network error code. The delivery_failure_reason parameter 
        /// is not included if the delivery attempt was successful
        /// </summary>
        delivery_failure_reason = 0x0425,

        /// <summary>
        /// The more_messages_to_send parameter is used by the ESME in the submit_sm and data_sm operations 
        /// to indicate to the SMSC that there are further messages for the same destination SME. The SMSC 
        /// may use this setting for network resource optimization
        /// </summary>
        more_messages_to_send = 0x0426,

        /// <summary>
        /// The message_state optional parameter is used by the SMSC in the deliver_sm and data_sm PDUs 
        /// to indicate to the ESME the final message state for an SMSC Delivery Receipt
        /// </summary>
        message_state = 0x0427,

        /// <summary>
        /// The ussd_service_op parameter is required to define the USSD service operation when SMPP
        /// is being used as an interface to a (GSM) USSD system
        /// </summary>
        ussd_service_op = 0x0501,

        /// <summary>
        /// The display_time parameter is used to associate a display time of the short message on the MS
        /// </summary>
        display_time = 0x1201,

        /// <summary>
        /// The sms_signal parameter is used to provide a TDMA MS with alert tone information associated 
        /// with the received short message
        /// </summary>
        sms_signal = 0x1203,

        /// <summary>
        /// The ms_validity parameter is used to provide an MS with validity information associated 
        /// with the received short message
        /// </summary>
        ms_validity = 0x1204,

        /// <summary>
        /// The alert_on_message_delivery parameter is set to instruct a MS to alert the user (in a MS
        /// implementation specific manner) when the short message arrives at the MS
        /// </summary>
        alert_on_message_delivery = 0x130C,

        /// <summary>
        /// The its_reply_type parameter is a required parameter for the CDMA Interactive Tele-service 
        /// as defined by the Korean PCS carriers [KORITS]. It indicates and controls the MS user's 
        /// reply method to an SMS delivery message received from the ESME
        /// </summary>
        its_reply_type = 0x1380,

        /// <summary>
        /// The its_session_info parameter is a required parameter for the CDMA Interactive 
        /// Tele-service as defined by the Korean PCS carriers [KORITS]. It contains control information 
        /// for the interactive session between an MS and an ESME
        /// </summary>
        its_session_info = 0x1383
    }
}
