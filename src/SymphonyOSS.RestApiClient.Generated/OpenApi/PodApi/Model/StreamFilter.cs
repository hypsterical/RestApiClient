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
    /// Stream filtering parameters.
    /// </summary>
    [DataContract]
    public partial class StreamFilter :  IEquatable<StreamFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamFilter" /> class.
        /// </summary>
        /// <param name="StreamTypes">Types of streams to search for..</param>
        /// <param name="IncludeInactiveStreams">Whether to include inactive streams in the list of results..</param>
        public StreamFilter(List<StreamType> StreamTypes = null, bool? IncludeInactiveStreams = null)
        {
            
            
                        this.StreamTypes = StreamTypes;
            
                        this.IncludeInactiveStreams = IncludeInactiveStreams;
            
        }
        
        /// <summary>
        /// Types of streams to search for.
        /// </summary>
        /// <value>Types of streams to search for.</value>
        [DataMember(Name="streamTypes", EmitDefaultValue=false)]
        public List<StreamType> StreamTypes { get; set; }
        /// <summary>
        /// Whether to include inactive streams in the list of results.
        /// </summary>
        /// <value>Whether to include inactive streams in the list of results.</value>
        [DataMember(Name="includeInactiveStreams", EmitDefaultValue=false)]
        public bool? IncludeInactiveStreams { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamFilter {\n");
            sb.Append("  StreamTypes: ").Append(StreamTypes).Append("\n");
sb.Append("  IncludeInactiveStreams: ").Append(IncludeInactiveStreams).Append("\n");
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
            return this.Equals(obj as StreamFilter);
        }

        /// <summary>
        /// Returns true if StreamFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of StreamFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StreamTypes == other.StreamTypes ||
                    this.StreamTypes != null &&
                    this.StreamTypes.SequenceEqual(other.StreamTypes)
                ) && 
                (
                    this.IncludeInactiveStreams == other.IncludeInactiveStreams ||
                    this.IncludeInactiveStreams != null &&
                    this.IncludeInactiveStreams.Equals(other.IncludeInactiveStreams)
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
                if (this.StreamTypes != null)
                    hash = hash * 59 + this.StreamTypes.GetHashCode();
                if (this.IncludeInactiveStreams != null)
                    hash = hash * 59 + this.IncludeInactiveStreams.GetHashCode();
                return hash;
            }
        }
    }

}
