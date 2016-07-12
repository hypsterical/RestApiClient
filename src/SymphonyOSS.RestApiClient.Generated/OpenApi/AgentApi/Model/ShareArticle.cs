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
    /// ShareArticle
    /// </summary>
    [DataContract]
    public partial class ShareArticle :  IEquatable<ShareArticle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareArticle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShareArticle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareArticle" /> class.
        /// </summary>
        /// <param name="ArticleId">An ID for this article that should be unique to the calling application. (required).</param>
        /// <param name="Title">The title of the article (required).</param>
        /// <param name="SubTitle">The subtitle of the article.</param>
        /// <param name="Message">The message text that can be send along with the shared article.</param>
        /// <param name="Publisher">Publisher of the article (required).</param>
        /// <param name="ThumbnailUrl">Url to the thumbnail image.</param>
        /// <param name="Author">Author of the article (required).</param>
        /// <param name="ArticleUrl">Url to the article.</param>
        /// <param name="Summary">Preview summary of the article.</param>
        /// <param name="AppId">App ID of the calling application (required).</param>
        /// <param name="AppName">App name of the calling application.</param>
        /// <param name="AppIconUrl">App icon url of the calling application.</param>
        public ShareArticle(string ArticleId = null, string Title = null, string SubTitle = null, string Message = null, string Publisher = null, string ThumbnailUrl = null, string Author = null, string ArticleUrl = null, string Summary = null, string AppId = null, string AppName = null, string AppIconUrl = null)
        {
            // to ensure "ArticleId" is required (not null)
            if (ArticleId == null)
            {
                throw new InvalidDataException("ArticleId is a required property for ShareArticle and cannot be null");
            }
            else
            {
                this.ArticleId = ArticleId;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for ShareArticle and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "Publisher" is required (not null)
            if (Publisher == null)
            {
                throw new InvalidDataException("Publisher is a required property for ShareArticle and cannot be null");
            }
            else
            {
                this.Publisher = Publisher;
            }
            // to ensure "Author" is required (not null)
            if (Author == null)
            {
                throw new InvalidDataException("Author is a required property for ShareArticle and cannot be null");
            }
            else
            {
                this.Author = Author;
            }
            // to ensure "AppId" is required (not null)
            if (AppId == null)
            {
                throw new InvalidDataException("AppId is a required property for ShareArticle and cannot be null");
            }
            else
            {
                this.AppId = AppId;
            }
            
            
                        this.SubTitle = SubTitle;
            
                        this.Message = Message;
            
                        this.ThumbnailUrl = ThumbnailUrl;
            
                        this.ArticleUrl = ArticleUrl;
            
                        this.Summary = Summary;
            
                        this.AppName = AppName;
            
                        this.AppIconUrl = AppIconUrl;
            
        }
        
        /// <summary>
        /// An ID for this article that should be unique to the calling application.
        /// </summary>
        /// <value>An ID for this article that should be unique to the calling application.</value>
        [DataMember(Name="articleId", EmitDefaultValue=false)]
        public string ArticleId { get; set; }
        /// <summary>
        /// The title of the article
        /// </summary>
        /// <value>The title of the article</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// The subtitle of the article
        /// </summary>
        /// <value>The subtitle of the article</value>
        [DataMember(Name="subTitle", EmitDefaultValue=false)]
        public string SubTitle { get; set; }
        /// <summary>
        /// The message text that can be send along with the shared article
        /// </summary>
        /// <value>The message text that can be send along with the shared article</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Publisher of the article
        /// </summary>
        /// <value>Publisher of the article</value>
        [DataMember(Name="publisher", EmitDefaultValue=false)]
        public string Publisher { get; set; }
        /// <summary>
        /// Url to the thumbnail image
        /// </summary>
        /// <value>Url to the thumbnail image</value>
        [DataMember(Name="thumbnailUrl", EmitDefaultValue=false)]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Author of the article
        /// </summary>
        /// <value>Author of the article</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }
        /// <summary>
        /// Url to the article
        /// </summary>
        /// <value>Url to the article</value>
        [DataMember(Name="articleUrl", EmitDefaultValue=false)]
        public string ArticleUrl { get; set; }
        /// <summary>
        /// Preview summary of the article
        /// </summary>
        /// <value>Preview summary of the article</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }
        /// <summary>
        /// App ID of the calling application
        /// </summary>
        /// <value>App ID of the calling application</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }
        /// <summary>
        /// App name of the calling application
        /// </summary>
        /// <value>App name of the calling application</value>
        [DataMember(Name="appName", EmitDefaultValue=false)]
        public string AppName { get; set; }
        /// <summary>
        /// App icon url of the calling application
        /// </summary>
        /// <value>App icon url of the calling application</value>
        [DataMember(Name="appIconUrl", EmitDefaultValue=false)]
        public string AppIconUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareArticle {\n");
            sb.Append("  ArticleId: ").Append(ArticleId).Append("\n");
sb.Append("  Title: ").Append(Title).Append("\n");
sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
sb.Append("  Message: ").Append(Message).Append("\n");
sb.Append("  Publisher: ").Append(Publisher).Append("\n");
sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
sb.Append("  Author: ").Append(Author).Append("\n");
sb.Append("  ArticleUrl: ").Append(ArticleUrl).Append("\n");
sb.Append("  Summary: ").Append(Summary).Append("\n");
sb.Append("  AppId: ").Append(AppId).Append("\n");
sb.Append("  AppName: ").Append(AppName).Append("\n");
sb.Append("  AppIconUrl: ").Append(AppIconUrl).Append("\n");
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
            return this.Equals(obj as ShareArticle);
        }

        /// <summary>
        /// Returns true if ShareArticle instances are equal
        /// </summary>
        /// <param name="other">Instance of ShareArticle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareArticle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ArticleId == other.ArticleId ||
                    this.ArticleId != null &&
                    this.ArticleId.Equals(other.ArticleId)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.SubTitle == other.SubTitle ||
                    this.SubTitle != null &&
                    this.SubTitle.Equals(other.SubTitle)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Publisher == other.Publisher ||
                    this.Publisher != null &&
                    this.Publisher.Equals(other.Publisher)
                ) && 
                (
                    this.ThumbnailUrl == other.ThumbnailUrl ||
                    this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(other.ThumbnailUrl)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.ArticleUrl == other.ArticleUrl ||
                    this.ArticleUrl != null &&
                    this.ArticleUrl.Equals(other.ArticleUrl)
                ) && 
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) && 
                (
                    this.AppId == other.AppId ||
                    this.AppId != null &&
                    this.AppId.Equals(other.AppId)
                ) && 
                (
                    this.AppName == other.AppName ||
                    this.AppName != null &&
                    this.AppName.Equals(other.AppName)
                ) && 
                (
                    this.AppIconUrl == other.AppIconUrl ||
                    this.AppIconUrl != null &&
                    this.AppIconUrl.Equals(other.AppIconUrl)
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
                if (this.ArticleId != null)
                    hash = hash * 59 + this.ArticleId.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.SubTitle != null)
                    hash = hash * 59 + this.SubTitle.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Publisher != null)
                    hash = hash * 59 + this.Publisher.GetHashCode();
                if (this.ThumbnailUrl != null)
                    hash = hash * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.ArticleUrl != null)
                    hash = hash * 59 + this.ArticleUrl.GetHashCode();
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();
                if (this.AppId != null)
                    hash = hash * 59 + this.AppId.GetHashCode();
                if (this.AppName != null)
                    hash = hash * 59 + this.AppName.GetHashCode();
                if (this.AppIconUrl != null)
                    hash = hash * 59 + this.AppIconUrl.GetHashCode();
                return hash;
            }
        }
    }

}
