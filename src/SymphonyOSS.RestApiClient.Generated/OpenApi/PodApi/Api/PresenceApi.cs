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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPresenceApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get presence information about all company (pod) users.
        /// </summary>
        /// <remarks>
        /// The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>PresenceList</returns>
        PresenceList V1PresenceGet (string sessionToken);

        /// <summary>
        /// Get presence information about all company (pod) users.
        /// </summary>
        /// <remarks>
        /// The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of PresenceList</returns>
        ApiResponse<PresenceList> V1PresenceGetWithHttpInfo (string sessionToken);
        /// <summary>
        /// Get presence information about a particular user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Presence</returns>
        Presence V1UserUidPresenceGet (long? uid, string sessionToken);

        /// <summary>
        /// Get presence information about a particular user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of Presence</returns>
        ApiResponse<Presence> V1UserUidPresenceGetWithHttpInfo (long? uid, string sessionToken);
        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user.
        /// </summary>
        /// <remarks>
        /// Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>Presence</returns>
        Presence V1UserUidPresencePost (long? uid, string sessionToken, Presence presence);

        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user.
        /// </summary>
        /// <remarks>
        /// Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>ApiResponse of Presence</returns>
        ApiResponse<Presence> V1UserUidPresencePostWithHttpInfo (long? uid, string sessionToken, Presence presence);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get presence information about all company (pod) users.
        /// </summary>
        /// <remarks>
        /// The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of PresenceList</returns>
        System.Threading.Tasks.Task<PresenceList> V1PresenceGetAsync (string sessionToken);

        /// <summary>
        /// Get presence information about all company (pod) users.
        /// </summary>
        /// <remarks>
        /// The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (PresenceList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PresenceList>> V1PresenceGetAsyncWithHttpInfo (string sessionToken);
        /// <summary>
        /// Get presence information about a particular user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of Presence</returns>
        System.Threading.Tasks.Task<Presence> V1UserUidPresenceGetAsync (long? uid, string sessionToken);

        /// <summary>
        /// Get presence information about a particular user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (Presence)</returns>
        System.Threading.Tasks.Task<ApiResponse<Presence>> V1UserUidPresenceGetAsyncWithHttpInfo (long? uid, string sessionToken);
        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user.
        /// </summary>
        /// <remarks>
        /// Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>Task of Presence</returns>
        System.Threading.Tasks.Task<Presence> V1UserUidPresencePostAsync (long? uid, string sessionToken, Presence presence);

        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user.
        /// </summary>
        /// <remarks>
        /// Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>Task of ApiResponse (Presence)</returns>
        System.Threading.Tasks.Task<ApiResponse<Presence>> V1UserUidPresencePostAsyncWithHttpInfo (long? uid, string sessionToken, Presence presence);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PresenceApi : IPresenceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PresenceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PresenceApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get presence information about all company (pod) users. The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>PresenceList</returns>
        public PresenceList V1PresenceGet (string sessionToken)
        {
             ApiResponse<PresenceList> localVarResponse = V1PresenceGetWithHttpInfo(sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get presence information about all company (pod) users. The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of PresenceList</returns>
        public ApiResponse< PresenceList > V1PresenceGetWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling PresenceApi->V1PresenceGet");

            var localVarPath = "/v1/presence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1PresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1PresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PresenceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PresenceList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceList)));
            
        }

        /// <summary>
        /// Get presence information about all company (pod) users. The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of PresenceList</returns>
        public async System.Threading.Tasks.Task<PresenceList> V1PresenceGetAsync (string sessionToken)
        {
             ApiResponse<PresenceList> localVarResponse = await V1PresenceGetAsyncWithHttpInfo(sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get presence information about all company (pod) users. The returned data is taken from the in-memory cache for performance\nreasons which means inactive users may be omitted from the response.\n\nAll non-inactive users WILL be returned and some inactive users MAY\nbe included. Any omitted user IS inactive.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (PresenceList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PresenceList>> V1PresenceGetAsyncWithHttpInfo (string sessionToken)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling PresenceApi->V1PresenceGet");

            var localVarPath = "/v1/presence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1PresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1PresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PresenceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PresenceList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceList)));
            
        }

        /// <summary>
        /// Get presence information about a particular user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Presence</returns>
        public Presence V1UserUidPresenceGet (long? uid, string sessionToken)
        {
             ApiResponse<Presence> localVarResponse = V1UserUidPresenceGetWithHttpInfo(uid, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get presence information about a particular user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of Presence</returns>
        public ApiResponse< Presence > V1UserUidPresenceGetWithHttpInfo (long? uid, string sessionToken)
        {
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling PresenceApi->V1UserUidPresenceGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling PresenceApi->V1UserUidPresenceGet");

            var localVarPath = "/v1/user/{uid}/presence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Presence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Presence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Presence)));
            
        }

        /// <summary>
        /// Get presence information about a particular user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of Presence</returns>
        public async System.Threading.Tasks.Task<Presence> V1UserUidPresenceGetAsync (long? uid, string sessionToken)
        {
             ApiResponse<Presence> localVarResponse = await V1UserUidPresenceGetAsyncWithHttpInfo(uid, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get presence information about a particular user. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (Presence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Presence>> V1UserUidPresenceGetAsyncWithHttpInfo (long? uid, string sessionToken)
        {
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling PresenceApi->V1UserUidPresenceGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling PresenceApi->V1UserUidPresenceGet");

            var localVarPath = "/v1/user/{uid}/presence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Presence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Presence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Presence)));
            
        }

        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user. Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>Presence</returns>
        public Presence V1UserUidPresencePost (long? uid, string sessionToken, Presence presence)
        {
             ApiResponse<Presence> localVarResponse = V1UserUidPresencePostWithHttpInfo(uid, sessionToken, presence);
             return localVarResponse.Data;
        }

        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user. Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>ApiResponse of Presence</returns>
        public ApiResponse< Presence > V1UserUidPresencePostWithHttpInfo (long? uid, string sessionToken, Presence presence)
        {
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling PresenceApi->V1UserUidPresencePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling PresenceApi->V1UserUidPresencePost");
            // verify the required parameter 'presence' is set
            if (presence == null)
                throw new ApiException(400, "Missing required parameter 'presence' when calling PresenceApi->V1UserUidPresencePost");

            var localVarPath = "/v1/user/{uid}/presence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (presence.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(presence); // http body (model) parameter
            }
            else
            {
                localVarPostBody = presence; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresencePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresencePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Presence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Presence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Presence)));
            
        }

        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user. Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>Task of Presence</returns>
        public async System.Threading.Tasks.Task<Presence> V1UserUidPresencePostAsync (long? uid, string sessionToken, Presence presence)
        {
             ApiResponse<Presence> localVarResponse = await V1UserUidPresencePostAsyncWithHttpInfo(uid, sessionToken, presence);
             return localVarResponse.Data;

        }

        /// <summary>
        /// LIMITED RELEASE Set presence information for a particular user. Only the following states can be set\nAVAILABLE\nBUSY\nON_THE_PHONE\nAWAY\n\nAttempts to set other states will result in a 403 FORBIDDEN response.\n\nThe UNDEFINED value is an error case used to represent the case if the value stored in the\nsystem cannot be represented by the values known to the API.\n\nThe other states are reserved for future use.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID as a decimal integer\n</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="presence"></param>
        /// <returns>Task of ApiResponse (Presence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Presence>> V1UserUidPresencePostAsyncWithHttpInfo (long? uid, string sessionToken, Presence presence)
        {
            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new ApiException(400, "Missing required parameter 'uid' when calling PresenceApi->V1UserUidPresencePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling PresenceApi->V1UserUidPresencePost");
            // verify the required parameter 'presence' is set
            if (presence == null)
                throw new ApiException(400, "Missing required parameter 'presence' when calling PresenceApi->V1UserUidPresencePost");

            var localVarPath = "/v1/user/{uid}/presence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (uid != null) localVarPathParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (presence.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(presence); // http body (model) parameter
            }
            else
            {
                localVarPostBody = presence; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresencePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserUidPresencePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Presence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Presence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Presence)));
            
        }

    }
}
