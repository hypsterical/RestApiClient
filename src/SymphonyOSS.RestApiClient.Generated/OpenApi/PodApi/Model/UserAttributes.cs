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
    /// User record.
    /// </summary>
    [DataContract]
    public partial class UserAttributes :  IEquatable<UserAttributes>
    {
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            
            /// <summary>
            /// Enum Normal for "NORMAL"
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            Normal,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System
        }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAttributes" /> class.
        /// </summary>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Department">Department.</param>
        /// <param name="Division">Division.</param>
        /// <param name="Title">Title.</param>
        /// <param name="WorkPhoneNumber">WorkPhoneNumber.</param>
        /// <param name="MobilePhoneNumber">MobilePhoneNumber.</param>
        /// <param name="SmsNumber">SmsNumber.</param>
        /// <param name="AccountType">AccountType.</param>
        /// <param name="Location">Location.</param>
        /// <param name="JobFunction">JobFunction.</param>
        /// <param name="AssetClasses">AssetClasses.</param>
        /// <param name="Industries">Industries.</param>
        public UserAttributes(string EmailAddress = null, string FirstName = null, string LastName = null, string UserName = null, string DisplayName = null, string Department = null, string Division = null, string Title = null, string WorkPhoneNumber = null, string MobilePhoneNumber = null, string SmsNumber = null, AccountTypeEnum? AccountType = null, string Location = null, string JobFunction = null, List<string> AssetClasses = null, List<string> Industries = null)
        {
            
            
                        this.EmailAddress = EmailAddress;
            
                        this.FirstName = FirstName;
            
                        this.LastName = LastName;
            
                        this.UserName = UserName;
            
                        this.DisplayName = DisplayName;
            
                        this.Department = Department;
            
                        this.Division = Division;
            
                        this.Title = Title;
            
                        this.WorkPhoneNumber = WorkPhoneNumber;
            
                        this.MobilePhoneNumber = MobilePhoneNumber;
            
                        this.SmsNumber = SmsNumber;
            
                        this.AccountType = AccountType;
            
                        this.Location = Location;
            
                        this.JobFunction = JobFunction;
            
                        this.AssetClasses = AssetClasses;
            
                        this.Industries = Industries;
            
        }
        
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
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public string Division { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets WorkPhoneNumber
        /// </summary>
        [DataMember(Name="workPhoneNumber", EmitDefaultValue=false)]
        public string WorkPhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets MobilePhoneNumber
        /// </summary>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
        public string MobilePhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets SmsNumber
        /// </summary>
        [DataMember(Name="smsNumber", EmitDefaultValue=false)]
        public string SmsNumber { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// Gets or Sets JobFunction
        /// </summary>
        [DataMember(Name="jobFunction", EmitDefaultValue=false)]
        public string JobFunction { get; set; }
        /// <summary>
        /// Gets or Sets AssetClasses
        /// </summary>
        [DataMember(Name="assetClasses", EmitDefaultValue=false)]
        public List<string> AssetClasses { get; set; }
        /// <summary>
        /// Gets or Sets Industries
        /// </summary>
        [DataMember(Name="industries", EmitDefaultValue=false)]
        public List<string> Industries { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAttributes {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
sb.Append("  FirstName: ").Append(FirstName).Append("\n");
sb.Append("  LastName: ").Append(LastName).Append("\n");
sb.Append("  UserName: ").Append(UserName).Append("\n");
sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
sb.Append("  Department: ").Append(Department).Append("\n");
sb.Append("  Division: ").Append(Division).Append("\n");
sb.Append("  Title: ").Append(Title).Append("\n");
sb.Append("  WorkPhoneNumber: ").Append(WorkPhoneNumber).Append("\n");
sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
sb.Append("  SmsNumber: ").Append(SmsNumber).Append("\n");
sb.Append("  AccountType: ").Append(AccountType).Append("\n");
sb.Append("  Location: ").Append(Location).Append("\n");
sb.Append("  JobFunction: ").Append(JobFunction).Append("\n");
sb.Append("  AssetClasses: ").Append(AssetClasses).Append("\n");
sb.Append("  Industries: ").Append(Industries).Append("\n");
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
            return this.Equals(obj as UserAttributes);
        }

        /// <summary>
        /// Returns true if UserAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.WorkPhoneNumber == other.WorkPhoneNumber ||
                    this.WorkPhoneNumber != null &&
                    this.WorkPhoneNumber.Equals(other.WorkPhoneNumber)
                ) && 
                (
                    this.MobilePhoneNumber == other.MobilePhoneNumber ||
                    this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(other.MobilePhoneNumber)
                ) && 
                (
                    this.SmsNumber == other.SmsNumber ||
                    this.SmsNumber != null &&
                    this.SmsNumber.Equals(other.SmsNumber)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.JobFunction == other.JobFunction ||
                    this.JobFunction != null &&
                    this.JobFunction.Equals(other.JobFunction)
                ) && 
                (
                    this.AssetClasses == other.AssetClasses ||
                    this.AssetClasses != null &&
                    this.AssetClasses.SequenceEqual(other.AssetClasses)
                ) && 
                (
                    this.Industries == other.Industries ||
                    this.Industries != null &&
                    this.Industries.SequenceEqual(other.Industries)
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
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.WorkPhoneNumber != null)
                    hash = hash * 59 + this.WorkPhoneNumber.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hash = hash * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.SmsNumber != null)
                    hash = hash * 59 + this.SmsNumber.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.JobFunction != null)
                    hash = hash * 59 + this.JobFunction.GetHashCode();
                if (this.AssetClasses != null)
                    hash = hash * 59 + this.AssetClasses.GetHashCode();
                if (this.Industries != null)
                    hash = hash * 59 + this.Industries.GetHashCode();
                return hash;
            }
        }
    }

}
