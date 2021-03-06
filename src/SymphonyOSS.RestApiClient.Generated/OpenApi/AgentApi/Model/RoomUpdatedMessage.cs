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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// Generated when a room is updated.
    /// </summary>
    [DataContract]
    public partial class RoomUpdatedMessage : V2BaseMessage,  IEquatable<RoomUpdatedMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomUpdatedMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomUpdatedMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomUpdatedMessage" /> class.
        /// </summary>
        /// <param name="Id">The messageId is assigned by the ingestor service when a message is sent..</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="V2messageType">V2messageType (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        /// <param name="OldName">OldName.</param>
        /// <param name="NewName">NewName.</param>
        /// <param name="Keywords">Keywords.</param>
        /// <param name="OldDescription">OldDescription.</param>
        /// <param name="NewDescription">NewDescription.</param>
        /// <param name="MembersCanInvite">MembersCanInvite.</param>
        /// <param name="Discoverable">Discoverable.</param>
        /// <param name="_ReadOnly">_ReadOnly.</param>
        /// <param name="CopyProtected">CopyProtected.</param>
        public RoomUpdatedMessage(string Id = null, string Timestamp = null, string V2messageType = null, string StreamId = null, string OldName = null, string NewName = null, List<RoomTag> Keywords = null, string OldDescription = null, string NewDescription = null, bool? MembersCanInvite = null, bool? Discoverable = null, bool? _ReadOnly = null, bool? CopyProtected = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for RoomUpdatedMessage and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "V2messageType" is required (not null)
            if (V2messageType == null)
            {
                throw new InvalidDataException("V2messageType is a required property for RoomUpdatedMessage and cannot be null");
            }
            else
            {
                this.V2messageType = V2messageType;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for RoomUpdatedMessage and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            
            
                        this.Id = Id;
            
                        this.OldName = OldName;
            
                        this.NewName = NewName;
            
                        this.Keywords = Keywords;
            
                        this.OldDescription = OldDescription;
            
                        this.NewDescription = NewDescription;
            
                        this.MembersCanInvite = MembersCanInvite;
            
                        this.Discoverable = Discoverable;
            
                        this._ReadOnly = _ReadOnly;
            
                        this.CopyProtected = CopyProtected;
            
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
        /// Gets or Sets OldName
        /// </summary>
        [DataMember(Name="oldName", EmitDefaultValue=false)]
        public string OldName { get; set; }
        /// <summary>
        /// Gets or Sets NewName
        /// </summary>
        [DataMember(Name="newName", EmitDefaultValue=false)]
        public string NewName { get; set; }
        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<RoomTag> Keywords { get; set; }
        /// <summary>
        /// Gets or Sets OldDescription
        /// </summary>
        [DataMember(Name="oldDescription", EmitDefaultValue=false)]
        public string OldDescription { get; set; }
        /// <summary>
        /// Gets or Sets NewDescription
        /// </summary>
        [DataMember(Name="newDescription", EmitDefaultValue=false)]
        public string NewDescription { get; set; }
        /// <summary>
        /// Gets or Sets MembersCanInvite
        /// </summary>
        [DataMember(Name="membersCanInvite", EmitDefaultValue=false)]
        public bool? MembersCanInvite { get; set; }
        /// <summary>
        /// Gets or Sets Discoverable
        /// </summary>
        [DataMember(Name="discoverable", EmitDefaultValue=false)]
        public bool? Discoverable { get; set; }
        /// <summary>
        /// Gets or Sets _ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }
        /// <summary>
        /// Gets or Sets CopyProtected
        /// </summary>
        [DataMember(Name="copyProtected", EmitDefaultValue=false)]
        public bool? CopyProtected { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomUpdatedMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
sb.Append("  V2messageType: ").Append(V2messageType).Append("\n");
sb.Append("  StreamId: ").Append(StreamId).Append("\n");
sb.Append("  OldName: ").Append(OldName).Append("\n");
sb.Append("  NewName: ").Append(NewName).Append("\n");
sb.Append("  Keywords: ").Append(Keywords).Append("\n");
sb.Append("  OldDescription: ").Append(OldDescription).Append("\n");
sb.Append("  NewDescription: ").Append(NewDescription).Append("\n");
sb.Append("  MembersCanInvite: ").Append(MembersCanInvite).Append("\n");
sb.Append("  Discoverable: ").Append(Discoverable).Append("\n");
sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
sb.Append("  CopyProtected: ").Append(CopyProtected).Append("\n");
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
            return this.Equals(obj as RoomUpdatedMessage);
        }

        /// <summary>
        /// Returns true if RoomUpdatedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomUpdatedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomUpdatedMessage other)
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
                    this.OldName == other.OldName ||
                    this.OldName != null &&
                    this.OldName.Equals(other.OldName)
                ) && 
                (
                    this.NewName == other.NewName ||
                    this.NewName != null &&
                    this.NewName.Equals(other.NewName)
                ) && 
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
                ) && 
                (
                    this.OldDescription == other.OldDescription ||
                    this.OldDescription != null &&
                    this.OldDescription.Equals(other.OldDescription)
                ) && 
                (
                    this.NewDescription == other.NewDescription ||
                    this.NewDescription != null &&
                    this.NewDescription.Equals(other.NewDescription)
                ) && 
                (
                    this.MembersCanInvite == other.MembersCanInvite ||
                    this.MembersCanInvite != null &&
                    this.MembersCanInvite.Equals(other.MembersCanInvite)
                ) && 
                (
                    this.Discoverable == other.Discoverable ||
                    this.Discoverable != null &&
                    this.Discoverable.Equals(other.Discoverable)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.CopyProtected == other.CopyProtected ||
                    this.CopyProtected != null &&
                    this.CopyProtected.Equals(other.CopyProtected)
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
                if (this.OldName != null)
                    hash = hash * 59 + this.OldName.GetHashCode();
                if (this.NewName != null)
                    hash = hash * 59 + this.NewName.GetHashCode();
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                if (this.OldDescription != null)
                    hash = hash * 59 + this.OldDescription.GetHashCode();
                if (this.NewDescription != null)
                    hash = hash * 59 + this.NewDescription.GetHashCode();
                if (this.MembersCanInvite != null)
                    hash = hash * 59 + this.MembersCanInvite.GetHashCode();
                if (this.Discoverable != null)
                    hash = hash * 59 + this.Discoverable.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.CopyProtected != null)
                    hash = hash * 59 + this.CopyProtected.GetHashCode();
                return hash;
            }
        }
    }

}
