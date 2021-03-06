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
    /// User record version 2
    /// </summary>
    [DataContract]
    public partial class UserV2 :  IEquatable<UserV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserV2" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Company">Company.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Avatars">avatar urls for both original size and small size.</param>
        public UserV2(long? Id = null, string EmailAddress = null, string FirstName = null, string LastName = null, string DisplayName = null, string Title = null, string Company = null, string Username = null, string Location = null, AvatarList Avatars = null)
        {
            
            
                        this.Id = Id;
            
                        this.EmailAddress = EmailAddress;
            
                        this.FirstName = FirstName;
            
                        this.LastName = LastName;
            
                        this.DisplayName = DisplayName;
            
                        this.Title = Title;
            
                        this.Company = Company;
            
                        this.Username = Username;
            
                        this.Location = Location;
            
                        this.Avatars = Avatars;
            
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// avatar urls for both original size and small size
        /// </summary>
        /// <value>avatar urls for both original size and small size</value>
        [DataMember(Name="avatars", EmitDefaultValue=false)]
        public AvatarList Avatars { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserV2 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
sb.Append("  FirstName: ").Append(FirstName).Append("\n");
sb.Append("  LastName: ").Append(LastName).Append("\n");
sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
sb.Append("  Title: ").Append(Title).Append("\n");
sb.Append("  Company: ").Append(Company).Append("\n");
sb.Append("  Username: ").Append(Username).Append("\n");
sb.Append("  Location: ").Append(Location).Append("\n");
sb.Append("  Avatars: ").Append(Avatars).Append("\n");
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
            return this.Equals(obj as UserV2);
        }

        /// <summary>
        /// Returns true if UserV2 instances are equal
        /// </summary>
        /// <param name="other">Instance of UserV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserV2 other)
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
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Avatars == other.Avatars ||
                    this.Avatars != null &&
                    this.Avatars.Equals(other.Avatars)
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
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Avatars != null)
                    hash = hash * 59 + this.Avatars.GetHashCode();
                return hash;
            }
        }
    }

}
