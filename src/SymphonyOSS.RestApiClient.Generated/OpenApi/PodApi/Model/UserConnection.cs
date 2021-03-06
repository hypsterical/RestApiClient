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
    /// Connection status between two users
    /// </summary>
    [DataContract]
    public partial class UserConnection :  IEquatable<UserConnection>
    {
        /// <summary>
        /// Connection status between the requesting user and the request sender
        /// </summary>
        /// <value>Connection status between the requesting user and the request sender</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PendingIncoming for "pending_incoming"
            /// </summary>
            [EnumMember(Value = "pending_incoming")]
            PendingIncoming,
            
            /// <summary>
            /// Enum PendingOutgoing for "pending_outgoing"
            /// </summary>
            [EnumMember(Value = "pending_outgoing")]
            PendingOutgoing,
            
            /// <summary>
            /// Enum Accepted for "accepted"
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Rejected for "rejected"
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected
        }

        /// <summary>
        /// Connection status between the requesting user and the request sender
        /// </summary>
        /// <value>Connection status between the requesting user and the request sender</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConnection" /> class.
        /// </summary>
        /// <param name="UserId">user id.</param>
        /// <param name="Status">Connection status between the requesting user and the request sender.</param>
        /// <param name="FirstRequestedAt">unix timestamp when the first request was made.</param>
        /// <param name="UpdatedAt">unix timestamp on the last updated date.</param>
        /// <param name="RequestCounter">number of requests made.</param>
        public UserConnection(long? UserId = null, StatusEnum? Status = null, long? FirstRequestedAt = null, long? UpdatedAt = null, int? RequestCounter = null)
        {
            
            
                        this.UserId = UserId;
            
                        this.Status = Status;
            
                        this.FirstRequestedAt = FirstRequestedAt;
            
                        this.UpdatedAt = UpdatedAt;
            
                        this.RequestCounter = RequestCounter;
            
        }
        
        /// <summary>
        /// user id
        /// </summary>
        /// <value>user id</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }
        /// <summary>
        /// unix timestamp when the first request was made
        /// </summary>
        /// <value>unix timestamp when the first request was made</value>
        [DataMember(Name="firstRequestedAt", EmitDefaultValue=false)]
        public long? FirstRequestedAt { get; set; }
        /// <summary>
        /// unix timestamp on the last updated date
        /// </summary>
        /// <value>unix timestamp on the last updated date</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// number of requests made
        /// </summary>
        /// <value>number of requests made</value>
        [DataMember(Name="requestCounter", EmitDefaultValue=false)]
        public int? RequestCounter { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConnection {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
sb.Append("  Status: ").Append(Status).Append("\n");
sb.Append("  FirstRequestedAt: ").Append(FirstRequestedAt).Append("\n");
sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
sb.Append("  RequestCounter: ").Append(RequestCounter).Append("\n");
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
            return this.Equals(obj as UserConnection);
        }

        /// <summary>
        /// Returns true if UserConnection instances are equal
        /// </summary>
        /// <param name="other">Instance of UserConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConnection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.FirstRequestedAt == other.FirstRequestedAt ||
                    this.FirstRequestedAt != null &&
                    this.FirstRequestedAt.Equals(other.FirstRequestedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.RequestCounter == other.RequestCounter ||
                    this.RequestCounter != null &&
                    this.RequestCounter.Equals(other.RequestCounter)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.FirstRequestedAt != null)
                    hash = hash * 59 + this.FirstRequestedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.RequestCounter != null)
                    hash = hash * 59 + this.RequestCounter.GetHashCode();
                return hash;
            }
        }
    }

}
