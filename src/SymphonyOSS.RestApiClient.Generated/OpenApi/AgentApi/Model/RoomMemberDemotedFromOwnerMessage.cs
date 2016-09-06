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
/* 
 * Agent API
 *
 * This document refers to Symphony API calls to send and receive messages and content. They need the on-premise Agent installed to perform decryption/encryption of content.  - sessionToken and keyManagerToken can be obtained by calling the authenticationAPI on the symphony back end and the key manager respectively. Refer to the methods described in authenticatorAPI.yaml. - Actions are defined to be atomic, ie will succeed in their entirety or fail and have changed nothing. - If it returns a 40X status then it will have sent no message to any stream even if a request to aome subset of the requested streams would have succeeded. - If this contract cannot be met for any reason then this is an error and the response code will be 50X. - MessageML is a markup language for messages. See reference here: https://developers.symphony.com/documentation/message_format_reference 
 *
 * OpenAPI spec version: 1.38.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// Generated when a room member is promoted to owner.
    /// </summary>
    [DataContract]
    public partial class RoomMemberDemotedFromOwnerMessage : V2BaseMessage,  IEquatable<RoomMemberDemotedFromOwnerMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMemberDemotedFromOwnerMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomMemberDemotedFromOwnerMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMemberDemotedFromOwnerMessage" /> class.
        /// </summary>
        /// <param name="Id">The messageId is assigned by the ingestor service when a message is sent..</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="V2messageType">V2messageType (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        /// <param name="DemotedByUserId">DemotedByUserId.</param>
        /// <param name="DemotedUserId">DemotedUserId.</param>
        public RoomMemberDemotedFromOwnerMessage(string Id = null, string Timestamp = null, string V2messageType = null, string StreamId = null, long? DemotedByUserId = null, long? DemotedUserId = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for RoomMemberDemotedFromOwnerMessage and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "V2messageType" is required (not null)
            if (V2messageType == null)
            {
                throw new InvalidDataException("V2messageType is a required property for RoomMemberDemotedFromOwnerMessage and cannot be null");
            }
            else
            {
                this.V2messageType = V2messageType;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for RoomMemberDemotedFromOwnerMessage and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            this.Id = Id;
            this.DemotedByUserId = DemotedByUserId;
            this.DemotedUserId = DemotedUserId;
        }
        
        /// <summary>
        /// The messageId is assigned by the ingestor service when a message is sent.
        /// </summary>
        /// <value>The messageId is assigned by the ingestor service when a message is sent.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets V2messageType
        /// </summary>
        [DataMember(Name="v2messageType", EmitDefaultValue=false)]
        public string V2messageType { get; set; }
        /// <summary>
        /// Gets or Sets StreamId
        /// </summary>
        [DataMember(Name="streamId", EmitDefaultValue=false)]
        public string StreamId { get; set; }
        /// <summary>
        /// Gets or Sets DemotedByUserId
        /// </summary>
        [DataMember(Name="demotedByUserId", EmitDefaultValue=false)]
        public long? DemotedByUserId { get; set; }
        /// <summary>
        /// Gets or Sets DemotedUserId
        /// </summary>
        [DataMember(Name="demotedUserId", EmitDefaultValue=false)]
        public long? DemotedUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomMemberDemotedFromOwnerMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  V2messageType: ").Append(V2messageType).Append("\n");
            sb.Append("  StreamId: ").Append(StreamId).Append("\n");
            sb.Append("  DemotedByUserId: ").Append(DemotedByUserId).Append("\n");
            sb.Append("  DemotedUserId: ").Append(DemotedUserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as RoomMemberDemotedFromOwnerMessage);
        }

        /// <summary>
        /// Returns true if RoomMemberDemotedFromOwnerMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomMemberDemotedFromOwnerMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomMemberDemotedFromOwnerMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.V2messageType == other.V2messageType ||
                    this.V2messageType != null &&
                    this.V2messageType.Equals(other.V2messageType)
                ) && 
                (
                    this.StreamId == other.StreamId ||
                    this.StreamId != null &&
                    this.StreamId.Equals(other.StreamId)
                ) && 
                (
                    this.DemotedByUserId == other.DemotedByUserId ||
                    this.DemotedByUserId != null &&
                    this.DemotedByUserId.Equals(other.DemotedByUserId)
                ) && 
                (
                    this.DemotedUserId == other.DemotedUserId ||
                    this.DemotedUserId != null &&
                    this.DemotedUserId.Equals(other.DemotedUserId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.V2messageType != null)
                    hash = hash * 59 + this.V2messageType.GetHashCode();
                if (this.StreamId != null)
                    hash = hash * 59 + this.StreamId.GetHashCode();
                if (this.DemotedByUserId != null)
                    hash = hash * 59 + this.DemotedByUserId.GetHashCode();
                if (this.DemotedUserId != null)
                    hash = hash * 59 + this.DemotedUserId.GetHashCode();
                return hash;
            }
        }
    }

}
