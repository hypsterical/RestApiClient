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
    /// StreamAttributes
    /// </summary>
    [DataContract]
    public partial class StreamAttributes :  IEquatable<StreamAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamAttributes" /> class.
        /// </summary>
        /// <param name="Id">The stream ID..</param>
        /// <param name="CrossPod">If true, this is a cross-pod stream..</param>
        /// <param name="Active">If true, this stream is active..</param>
        /// <param name="StreamType">The type of the stream (IM, multi-IM, chat room, user wall)..</param>
        /// <param name="_StreamAttributes">Additional stream details applicable to IMs, MIMs and user walls..</param>
        /// <param name="RoomAttributes">Additional stream details applicable to chatrooms..</param>
        public StreamAttributes(string Id = null, bool? CrossPod = null, bool? Active = null, StreamType StreamType = null, ConversationSpecificStreamAttributes _StreamAttributes = null, RoomSpecificStreamAttributes RoomAttributes = null)
        {
            
            
                        this.Id = Id;
            
                        this.CrossPod = CrossPod;
            
                        this.Active = Active;
            
                        this.StreamType = StreamType;
            
                        this._StreamAttributes = _StreamAttributes;
            
                        this.RoomAttributes = RoomAttributes;
            
        }
        
        /// <summary>
        /// The stream ID.
        /// </summary>
        /// <value>The stream ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// If true, this is a cross-pod stream.
        /// </summary>
        /// <value>If true, this is a cross-pod stream.</value>
        [DataMember(Name="crossPod", EmitDefaultValue=false)]
        public bool? CrossPod { get; set; }
        /// <summary>
        /// If true, this stream is active.
        /// </summary>
        /// <value>If true, this stream is active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// The type of the stream (IM, multi-IM, chat room, user wall).
        /// </summary>
        /// <value>The type of the stream (IM, multi-IM, chat room, user wall).</value>
        [DataMember(Name="streamType", EmitDefaultValue=false)]
        public StreamType StreamType { get; set; }
        /// <summary>
        /// Additional stream details applicable to IMs, MIMs and user walls.
        /// </summary>
        /// <value>Additional stream details applicable to IMs, MIMs and user walls.</value>
        [DataMember(Name="streamAttributes", EmitDefaultValue=false)]
        public ConversationSpecificStreamAttributes _StreamAttributes { get; set; }
        /// <summary>
        /// Additional stream details applicable to chatrooms.
        /// </summary>
        /// <value>Additional stream details applicable to chatrooms.</value>
        [DataMember(Name="roomAttributes", EmitDefaultValue=false)]
        public RoomSpecificStreamAttributes RoomAttributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamAttributes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  CrossPod: ").Append(CrossPod).Append("\n");
sb.Append("  Active: ").Append(Active).Append("\n");
sb.Append("  StreamType: ").Append(StreamType).Append("\n");
sb.Append("  _StreamAttributes: ").Append(_StreamAttributes).Append("\n");
sb.Append("  RoomAttributes: ").Append(RoomAttributes).Append("\n");
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
            return this.Equals(obj as StreamAttributes);
        }

        /// <summary>
        /// Returns true if StreamAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of StreamAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamAttributes other)
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
                    this.CrossPod == other.CrossPod ||
                    this.CrossPod != null &&
                    this.CrossPod.Equals(other.CrossPod)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.StreamType == other.StreamType ||
                    this.StreamType != null &&
                    this.StreamType.Equals(other.StreamType)
                ) && 
                (
                    this._StreamAttributes == other._StreamAttributes ||
                    this._StreamAttributes != null &&
                    this._StreamAttributes.Equals(other._StreamAttributes)
                ) && 
                (
                    this.RoomAttributes == other.RoomAttributes ||
                    this.RoomAttributes != null &&
                    this.RoomAttributes.Equals(other.RoomAttributes)
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
                if (this.CrossPod != null)
                    hash = hash * 59 + this.CrossPod.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.StreamType != null)
                    hash = hash * 59 + this.StreamType.GetHashCode();
                if (this._StreamAttributes != null)
                    hash = hash * 59 + this._StreamAttributes.GetHashCode();
                if (this.RoomAttributes != null)
                    hash = hash * 59 + this.RoomAttributes.GetHashCode();
                return hash;
            }
        }
    }

}
