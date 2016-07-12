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
    public interface IUsersApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get user information by email address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>User</returns>
        User V1UserGet (string email, string sessionToken, bool? local = null);

        /// <summary>
        /// Get user information by email address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> V1UserGetWithHttpInfo (string email, string sessionToken, bool? local = null);
        /// <summary>
        /// Get user information by user (login) name.
        /// </summary>
        /// <remarks>
        /// Searches for a user in the local pod with the given user name.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>User</returns>
        User V1UserNameUserNameGetGet (string userName, string sessionToken);

        /// <summary>
        /// Get user information by user (login) name.
        /// </summary>
        /// <remarks>
        /// Searches for a user in the local pod with the given user name.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> V1UserNameUserNameGetGetWithHttpInfo (string userName, string sessionToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get user information by email address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> V1UserGetAsync (string email, string sessionToken, bool? local = null);

        /// <summary>
        /// Get user information by email address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> V1UserGetAsyncWithHttpInfo (string email, string sessionToken, bool? local = null);
        /// <summary>
        /// Get user information by user (login) name.
        /// </summary>
        /// <remarks>
        /// Searches for a user in the local pod with the given user name.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> V1UserNameUserNameGetGetAsync (string userName, string sessionToken);

        /// <summary>
        /// Get user information by user (login) name.
        /// </summary>
        /// <remarks>
        /// Searches for a user in the local pod with the given user name.\n
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> V1UserNameUserNameGetGetAsyncWithHttpInfo (string userName, string sessionToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        /// Get user information by email address. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>User</returns>
        public User V1UserGet (string email, string sessionToken, bool? local = null)
        {
             ApiResponse<User> localVarResponse = V1UserGetWithHttpInfo(email, sessionToken, local);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user information by email address. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > V1UserGetWithHttpInfo (string email, string sessionToken, bool? local = null)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->V1UserGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UsersApi->V1UserGet");

            var localVarPath = "/v1/user";
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
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (local != null) localVarQueryParams.Add("local", Configuration.ApiClient.ParameterToString(local)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get user information by email address. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> V1UserGetAsync (string email, string sessionToken, bool? local = null)
        {
             ApiResponse<User> localVarResponse = await V1UserGetAsyncWithHttpInfo(email, sessionToken, local);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user information by email address. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">Email address</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <param name="local">If true then a local DB search will be performed and only local pod users will be\nreturned. If absent or false then a directory search will be performed and users\nfrom other pods who are visible to the calling user will also be returned.\n (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> V1UserGetAsyncWithHttpInfo (string email, string sessionToken, bool? local = null)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->V1UserGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UsersApi->V1UserGet");

            var localVarPath = "/v1/user";
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
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (local != null) localVarQueryParams.Add("local", Configuration.ApiClient.ParameterToString(local)); // query parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get user information by user (login) name. Searches for a user in the local pod with the given user name.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>User</returns>
        public User V1UserNameUserNameGetGet (string userName, string sessionToken)
        {
             ApiResponse<User> localVarResponse = V1UserNameUserNameGetGetWithHttpInfo(userName, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user information by user (login) name. Searches for a user in the local pod with the given user name.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > V1UserNameUserNameGetGetWithHttpInfo (string userName, string sessionToken)
        {
            // verify the required parameter 'userName' is set
            if (userName == null)
                throw new ApiException(400, "Missing required parameter 'userName' when calling UsersApi->V1UserNameUserNameGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UsersApi->V1UserNameUserNameGetGet");

            var localVarPath = "/v1/user/name/{userName}/get";
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
            if (userName != null) localVarPathParams.Add("userName", Configuration.ApiClient.ParameterToString(userName)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserNameUserNameGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserNameUserNameGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        /// <summary>
        /// Get user information by user (login) name. Searches for a user in the local pod with the given user name.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> V1UserNameUserNameGetGetAsync (string userName, string sessionToken)
        {
             ApiResponse<User> localVarResponse = await V1UserNameUserNameGetGetAsyncWithHttpInfo(userName, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user information by user (login) name. Searches for a user in the local pod with the given user name.\n
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">User login name</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> V1UserNameUserNameGetGetAsyncWithHttpInfo (string userName, string sessionToken)
        {
            // verify the required parameter 'userName' is set
            if (userName == null)
                throw new ApiException(400, "Missing required parameter 'userName' when calling UsersApi->V1UserNameUserNameGetGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling UsersApi->V1UserNameUserNameGetGet");

            var localVarPath = "/v1/user/name/{userName}/get";
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
            if (userName != null) localVarPathParams.Add("userName", Configuration.ApiClient.ParameterToString(userName)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1UserNameUserNameGetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1UserNameUserNameGetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

    }
}
