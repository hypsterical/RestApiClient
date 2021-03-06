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
    /// CompanyCertInfo
    /// </summary>
    [DataContract]
    public partial class CompanyCertInfo :  IEquatable<CompanyCertInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCertInfo" /> class.
        /// </summary>
        /// <param name="FingerPrint">Unique identifier.</param>
        /// <param name="IssuerFingerPrint">Unique identifier of issuer cert if known.</param>
        /// <param name="LastSeen">Date when we last saw this certificate presented.</param>
        /// <param name="UpdatedAt">Date when this cert was last updated by administrator.</param>
        /// <param name="UpdatedBy">User ID of administrator who last updated this cert.</param>
        /// <param name="CommonName">The Symphony account name which this certificate authenticates.</param>
        /// <param name="ExpiryDate">Expiry date of this cert.</param>
        public CompanyCertInfo(string FingerPrint = null, string IssuerFingerPrint = null, long? LastSeen = null, long? UpdatedAt = null, long? UpdatedBy = null, string CommonName = null, long? ExpiryDate = null)
        {
            
            
                        this.FingerPrint = FingerPrint;
            
                        this.IssuerFingerPrint = IssuerFingerPrint;
            
                        this.LastSeen = LastSeen;
            
                        this.UpdatedAt = UpdatedAt;
            
                        this.UpdatedBy = UpdatedBy;
            
                        this.CommonName = CommonName;
            
                        this.ExpiryDate = ExpiryDate;
            
        }
        
        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
        [DataMember(Name="fingerPrint", EmitDefaultValue=false)]
        public string FingerPrint { get; set; }
        /// <summary>
        /// Unique identifier of issuer cert if known
        /// </summary>
        /// <value>Unique identifier of issuer cert if known</value>
        [DataMember(Name="issuerFingerPrint", EmitDefaultValue=false)]
        public string IssuerFingerPrint { get; set; }
        /// <summary>
        /// Date when we last saw this certificate presented
        /// </summary>
        /// <value>Date when we last saw this certificate presented</value>
        [DataMember(Name="lastSeen", EmitDefaultValue=false)]
        public long? LastSeen { get; set; }
        /// <summary>
        /// Date when this cert was last updated by administrator
        /// </summary>
        /// <value>Date when this cert was last updated by administrator</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// User ID of administrator who last updated this cert
        /// </summary>
        /// <value>User ID of administrator who last updated this cert</value>
        [DataMember(Name="updatedBy", EmitDefaultValue=false)]
        public long? UpdatedBy { get; set; }
        /// <summary>
        /// The Symphony account name which this certificate authenticates
        /// </summary>
        /// <value>The Symphony account name which this certificate authenticates</value>
        [DataMember(Name="commonName", EmitDefaultValue=false)]
        public string CommonName { get; set; }
        /// <summary>
        /// Expiry date of this cert
        /// </summary>
        /// <value>Expiry date of this cert</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public long? ExpiryDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyCertInfo {\n");
            sb.Append("  FingerPrint: ").Append(FingerPrint).Append("\n");
sb.Append("  IssuerFingerPrint: ").Append(IssuerFingerPrint).Append("\n");
sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
sb.Append("  CommonName: ").Append(CommonName).Append("\n");
sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(obj as CompanyCertInfo);
        }

        /// <summary>
        /// Returns true if CompanyCertInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyCertInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyCertInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FingerPrint == other.FingerPrint ||
                    this.FingerPrint != null &&
                    this.FingerPrint.Equals(other.FingerPrint)
                ) && 
                (
                    this.IssuerFingerPrint == other.IssuerFingerPrint ||
                    this.IssuerFingerPrint != null &&
                    this.IssuerFingerPrint.Equals(other.IssuerFingerPrint)
                ) && 
                (
                    this.LastSeen == other.LastSeen ||
                    this.LastSeen != null &&
                    this.LastSeen.Equals(other.LastSeen)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.UpdatedBy == other.UpdatedBy ||
                    this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(other.UpdatedBy)
                ) && 
                (
                    this.CommonName == other.CommonName ||
                    this.CommonName != null &&
                    this.CommonName.Equals(other.CommonName)
                ) && 
                (
                    this.ExpiryDate == other.ExpiryDate ||
                    this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(other.ExpiryDate)
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
                if (this.FingerPrint != null)
                    hash = hash * 59 + this.FingerPrint.GetHashCode();
                if (this.IssuerFingerPrint != null)
                    hash = hash * 59 + this.IssuerFingerPrint.GetHashCode();
                if (this.LastSeen != null)
                    hash = hash * 59 + this.LastSeen.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.UpdatedBy != null)
                    hash = hash * 59 + this.UpdatedBy.GetHashCode();
                if (this.CommonName != null)
                    hash = hash * 59 + this.CommonName.GetHashCode();
                if (this.ExpiryDate != null)
                    hash = hash * 59 + this.ExpiryDate.GetHashCode();
                return hash;
            }
        }
    }

}
