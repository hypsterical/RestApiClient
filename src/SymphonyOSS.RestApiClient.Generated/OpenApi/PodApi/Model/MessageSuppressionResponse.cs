﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model
{
    /// <summary>
    /// The suppression state of a message
    /// </summary>
    [DataContract]
    public partial class MessageSuppressionResponse :  IEquatable<MessageSuppressionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSuppressionResponse" /> class.
        /// </summary>
        /// <param name="MessageId">MessageId.</param>
        /// <param name="Suppressed">Suppressed.</param>
        /// <param name="SuppressionDate">The date when this message was suppressed..</param>
        public MessageSuppressionResponse(string MessageId = null, bool? Suppressed = null, long? SuppressionDate = null)
        {
            
            
                        this.MessageId = MessageId;
            
                        this.Suppressed = Suppressed;
            
                        this.SuppressionDate = SuppressionDate;
            
        }
        
        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }
        /// <summary>
        /// Gets or Sets Suppressed
        /// </summary>
        [DataMember(Name="suppressed", EmitDefaultValue=false)]
        public bool? Suppressed { get; set; }
        /// <summary>
        /// The date when this message was suppressed.
        /// </summary>
        /// <value>The date when this message was suppressed.</value>
        [DataMember(Name="suppressionDate", EmitDefaultValue=false)]
        public long? SuppressionDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageSuppressionResponse {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
sb.Append("  SuppressionDate: ").Append(SuppressionDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MessageSuppressionResponse);
        }

        /// <summary>
        /// Returns true if MessageSuppressionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageSuppressionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSuppressionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) && 
                (
                    this.Suppressed == other.Suppressed ||
                    this.Suppressed != null &&
                    this.Suppressed.Equals(other.Suppressed)
                ) && 
                (
                    this.SuppressionDate == other.SuppressionDate ||
                    this.SuppressionDate != null &&
                    this.SuppressionDate.Equals(other.SuppressionDate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                if (this.Suppressed != null)
                    hash = hash * 59 + this.Suppressed.GetHashCode();
                if (this.SuppressionDate != null)
                    hash = hash * 59 + this.SuppressionDate.GetHashCode();
                return hash;
            }
        }
    }

}
