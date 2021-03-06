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
    /// A list of search results and counts per search parameter.
    /// </summary>
    [DataContract]
    public partial class RoomSearchResults :  IEquatable<RoomSearchResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomSearchResults" /> class.
        /// </summary>
        /// <param name="Count">The total number of rooms matched by the search..</param>
        /// <param name="Skip">The number of skipped results..</param>
        /// <param name="Limit">The number of returned results..</param>
        /// <param name="Query">The search query that produced this result..</param>
        /// <param name="Rooms">A list of rooms matched by the query..</param>
        /// <param name="FacetedMatchCount">Detailed counts of matched rooms per search criterion..</param>
        public RoomSearchResults(long? Count = null, int? Skip = null, int? Limit = null, RoomSearchCriteria Query = null, List<V2RoomDetail> Rooms = null, List<FacetedMatchCount> FacetedMatchCount = null)
        {
            
            
                        this.Count = Count;
            
                        this.Skip = Skip;
            
                        this.Limit = Limit;
            
                        this.Query = Query;
            
                        this.Rooms = Rooms;
            
                        this.FacetedMatchCount = FacetedMatchCount;
            
        }
        
        /// <summary>
        /// The total number of rooms matched by the search.
        /// </summary>
        /// <value>The total number of rooms matched by the search.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
        /// <summary>
        /// The number of skipped results.
        /// </summary>
        /// <value>The number of skipped results.</value>
        [DataMember(Name="skip", EmitDefaultValue=false)]
        public int? Skip { get; set; }
        /// <summary>
        /// The number of returned results.
        /// </summary>
        /// <value>The number of returned results.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// The search query that produced this result.
        /// </summary>
        /// <value>The search query that produced this result.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public RoomSearchCriteria Query { get; set; }
        /// <summary>
        /// A list of rooms matched by the query.
        /// </summary>
        /// <value>A list of rooms matched by the query.</value>
        [DataMember(Name="rooms", EmitDefaultValue=false)]
        public List<V2RoomDetail> Rooms { get; set; }
        /// <summary>
        /// Detailed counts of matched rooms per search criterion.
        /// </summary>
        /// <value>Detailed counts of matched rooms per search criterion.</value>
        [DataMember(Name="facetedMatchCount", EmitDefaultValue=false)]
        public List<FacetedMatchCount> FacetedMatchCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomSearchResults {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
sb.Append("  Skip: ").Append(Skip).Append("\n");
sb.Append("  Limit: ").Append(Limit).Append("\n");
sb.Append("  Query: ").Append(Query).Append("\n");
sb.Append("  Rooms: ").Append(Rooms).Append("\n");
sb.Append("  FacetedMatchCount: ").Append(FacetedMatchCount).Append("\n");
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
            return this.Equals(obj as RoomSearchResults);
        }

        /// <summary>
        /// Returns true if RoomSearchResults instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomSearchResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomSearchResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Skip == other.Skip ||
                    this.Skip != null &&
                    this.Skip.Equals(other.Skip)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Rooms == other.Rooms ||
                    this.Rooms != null &&
                    this.Rooms.SequenceEqual(other.Rooms)
                ) && 
                (
                    this.FacetedMatchCount == other.FacetedMatchCount ||
                    this.FacetedMatchCount != null &&
                    this.FacetedMatchCount.SequenceEqual(other.FacetedMatchCount)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Skip != null)
                    hash = hash * 59 + this.Skip.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.Rooms != null)
                    hash = hash * 59 + this.Rooms.GetHashCode();
                if (this.FacetedMatchCount != null)
                    hash = hash * 59 + this.FacetedMatchCount.GetHashCode();
                return hash;
            }
        }
    }

}
