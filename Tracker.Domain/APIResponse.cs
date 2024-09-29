#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : APIResponse.cs
// Purpose         : 
// Creation Date   : 27SEP2024
// Author          : Vibin P
//
// Change History
// Changed by   :                         Date : 
// Purpose      : 
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.Runtime.Serialization;
#endregion


namespace Tracker.Domain
{
    [DataContract]
    public class APIResponse
    {
        [DataMember]
        public object Data { get; set; }

        [DataMember]
        public List<Error> Errors { get; }

        [DataMember]
        public string InfoMessage { get; set; }

        public APIResponse(object data = null, List<Error> errors = null, string infoMessage = null)
        {
            this.Data = data;
            this.Errors = errors;
            this.InfoMessage = infoMessage;
        }
    }

    public class Error
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
}
