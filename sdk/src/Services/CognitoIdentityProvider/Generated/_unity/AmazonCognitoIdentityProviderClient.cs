/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// Implementation for accessing CognitoIdentityProvider
    ///
    /// Using the Amazon Cognito User Pools API, you can create a user pool to manage directories
    /// and users. You can authenticate a user to obtain tokens related to user identity and
    /// access policies.
    /// 
    ///  
    /// <para>
    /// This API reference provides information about user pools in Amazon Cognito User Pools.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the Amazon Cognito Documentation.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoIdentityProviderClient : AmazonServiceClient, IAmazonCognitoIdentityProvider
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoIdentityProviderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials and an
        /// AmazonCognitoIdentityProviderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityProviderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityProviderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityProviderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityProviderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddCustomAttributes
        internal virtual AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request)
        {
            var marshaller = AddCustomAttributesRequestMarshaller.Instance;
            var unmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return Invoke<AddCustomAttributesRequest,AddCustomAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        public virtual void AddCustomAttributesAsync(AddCustomAttributesRequest request, AmazonServiceCallback<AddCustomAttributesRequest, AddCustomAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AddCustomAttributesRequestMarshaller.Instance;
            var unmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AddCustomAttributesRequest,AddCustomAttributesResponse> responseObject 
                            = new AmazonServiceResult<AddCustomAttributesRequest,AddCustomAttributesResponse>((AddCustomAttributesRequest)req, (AddCustomAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AddCustomAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminAddUserToGroup
        internal virtual AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request)
        {
            var marshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            var unmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AdminAddUserToGroupRequest,AdminAddUserToGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminAddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminAddUserToGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        public virtual void AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, AmazonServiceCallback<AdminAddUserToGroupRequest, AdminAddUserToGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            var unmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminAddUserToGroupRequest,AdminAddUserToGroupResponse> responseObject 
                            = new AmazonServiceResult<AdminAddUserToGroupRequest,AdminAddUserToGroupResponse>((AdminAddUserToGroupRequest)req, (AdminAddUserToGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminAddUserToGroupRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminConfirmSignUp
        internal virtual AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request)
        {
            var marshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            var unmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<AdminConfirmSignUpRequest,AdminConfirmSignUpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        public virtual void AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, AmazonServiceCallback<AdminConfirmSignUpRequest, AdminConfirmSignUpResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            var unmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminConfirmSignUpRequest,AdminConfirmSignUpResponse> responseObject 
                            = new AmazonServiceResult<AdminConfirmSignUpRequest,AdminConfirmSignUpResponse>((AdminConfirmSignUpRequest)req, (AdminConfirmSignUpResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminConfirmSignUpRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminCreateUser
        internal virtual AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request)
        {
            var marshaller = AdminCreateUserRequestMarshaller.Instance;
            var unmarshaller = AdminCreateUserResponseUnmarshaller.Instance;

            return Invoke<AdminCreateUserRequest,AdminCreateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminCreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminCreateUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        public virtual void AdminCreateUserAsync(AdminCreateUserRequest request, AmazonServiceCallback<AdminCreateUserRequest, AdminCreateUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminCreateUserRequestMarshaller.Instance;
            var unmarshaller = AdminCreateUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminCreateUserRequest,AdminCreateUserResponse> responseObject 
                            = new AmazonServiceResult<AdminCreateUserRequest,AdminCreateUserResponse>((AdminCreateUserRequest)req, (AdminCreateUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminCreateUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDeleteUser
        internal virtual AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request)
        {
            var marshaller = AdminDeleteUserRequestMarshaller.Instance;
            var unmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserRequest,AdminDeleteUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        public virtual void AdminDeleteUserAsync(AdminDeleteUserRequest request, AmazonServiceCallback<AdminDeleteUserRequest, AdminDeleteUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminDeleteUserRequestMarshaller.Instance;
            var unmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDeleteUserRequest,AdminDeleteUserResponse> responseObject 
                            = new AmazonServiceResult<AdminDeleteUserRequest,AdminDeleteUserResponse>((AdminDeleteUserRequest)req, (AdminDeleteUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminDeleteUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDeleteUserAttributes
        internal virtual AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request)
        {
            var marshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            var unmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserAttributesRequest,AdminDeleteUserAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        public virtual void AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, AmazonServiceCallback<AdminDeleteUserAttributesRequest, AdminDeleteUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            var unmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDeleteUserAttributesRequest,AdminDeleteUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<AdminDeleteUserAttributesRequest,AdminDeleteUserAttributesResponse>((AdminDeleteUserAttributesRequest)req, (AdminDeleteUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminDeleteUserAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDisableProviderForUser
        internal virtual AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request)
        {
            var marshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            var unmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableProviderForUserRequest,AdminDisableProviderForUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        public virtual void AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, AmazonServiceCallback<AdminDisableProviderForUserRequest, AdminDisableProviderForUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            var unmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDisableProviderForUserRequest,AdminDisableProviderForUserResponse> responseObject 
                            = new AmazonServiceResult<AdminDisableProviderForUserRequest,AdminDisableProviderForUserResponse>((AdminDisableProviderForUserRequest)req, (AdminDisableProviderForUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminDisableProviderForUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDisableUser
        internal virtual AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request)
        {
            var marshaller = AdminDisableUserRequestMarshaller.Instance;
            var unmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableUserRequest,AdminDisableUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        public virtual void AdminDisableUserAsync(AdminDisableUserRequest request, AmazonServiceCallback<AdminDisableUserRequest, AdminDisableUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminDisableUserRequestMarshaller.Instance;
            var unmarshaller = AdminDisableUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDisableUserRequest,AdminDisableUserResponse> responseObject 
                            = new AmazonServiceResult<AdminDisableUserRequest,AdminDisableUserResponse>((AdminDisableUserRequest)req, (AdminDisableUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminDisableUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminEnableUser
        internal virtual AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request)
        {
            var marshaller = AdminEnableUserRequestMarshaller.Instance;
            var unmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return Invoke<AdminEnableUserRequest,AdminEnableUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        public virtual void AdminEnableUserAsync(AdminEnableUserRequest request, AmazonServiceCallback<AdminEnableUserRequest, AdminEnableUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminEnableUserRequestMarshaller.Instance;
            var unmarshaller = AdminEnableUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminEnableUserRequest,AdminEnableUserResponse> responseObject 
                            = new AmazonServiceResult<AdminEnableUserRequest,AdminEnableUserResponse>((AdminEnableUserRequest)req, (AdminEnableUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminEnableUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminForgetDevice
        internal virtual AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request)
        {
            var marshaller = AdminForgetDeviceRequestMarshaller.Instance;
            var unmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminForgetDeviceRequest,AdminForgetDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        public virtual void AdminForgetDeviceAsync(AdminForgetDeviceRequest request, AmazonServiceCallback<AdminForgetDeviceRequest, AdminForgetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminForgetDeviceRequestMarshaller.Instance;
            var unmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminForgetDeviceRequest,AdminForgetDeviceResponse> responseObject 
                            = new AmazonServiceResult<AdminForgetDeviceRequest,AdminForgetDeviceResponse>((AdminForgetDeviceRequest)req, (AdminForgetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminForgetDeviceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminGetDevice
        internal virtual AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request)
        {
            var marshaller = AdminGetDeviceRequestMarshaller.Instance;
            var unmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminGetDeviceRequest,AdminGetDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        public virtual void AdminGetDeviceAsync(AdminGetDeviceRequest request, AmazonServiceCallback<AdminGetDeviceRequest, AdminGetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminGetDeviceRequestMarshaller.Instance;
            var unmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminGetDeviceRequest,AdminGetDeviceResponse> responseObject 
                            = new AmazonServiceResult<AdminGetDeviceRequest,AdminGetDeviceResponse>((AdminGetDeviceRequest)req, (AdminGetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminGetDeviceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminGetUser
        internal virtual AdminGetUserResponse AdminGetUser(AdminGetUserRequest request)
        {
            var marshaller = AdminGetUserRequestMarshaller.Instance;
            var unmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return Invoke<AdminGetUserRequest,AdminGetUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        public virtual void AdminGetUserAsync(AdminGetUserRequest request, AmazonServiceCallback<AdminGetUserRequest, AdminGetUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminGetUserRequestMarshaller.Instance;
            var unmarshaller = AdminGetUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminGetUserRequest,AdminGetUserResponse> responseObject 
                            = new AmazonServiceResult<AdminGetUserRequest,AdminGetUserResponse>((AdminGetUserRequest)req, (AdminGetUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminGetUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminInitiateAuth
        internal virtual AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request)
        {
            var marshaller = AdminInitiateAuthRequestMarshaller.Instance;
            var unmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;

            return Invoke<AdminInitiateAuthRequest,AdminInitiateAuthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        public virtual void AdminInitiateAuthAsync(AdminInitiateAuthRequest request, AmazonServiceCallback<AdminInitiateAuthRequest, AdminInitiateAuthResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminInitiateAuthRequestMarshaller.Instance;
            var unmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminInitiateAuthRequest,AdminInitiateAuthResponse> responseObject 
                            = new AmazonServiceResult<AdminInitiateAuthRequest,AdminInitiateAuthResponse>((AdminInitiateAuthRequest)req, (AdminInitiateAuthResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminInitiateAuthRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminLinkProviderForUser
        internal virtual AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request)
        {
            var marshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            var unmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminLinkProviderForUserRequest,AdminLinkProviderForUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminLinkProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        public virtual void AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, AmazonServiceCallback<AdminLinkProviderForUserRequest, AdminLinkProviderForUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            var unmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminLinkProviderForUserRequest,AdminLinkProviderForUserResponse> responseObject 
                            = new AmazonServiceResult<AdminLinkProviderForUserRequest,AdminLinkProviderForUserResponse>((AdminLinkProviderForUserRequest)req, (AdminLinkProviderForUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminLinkProviderForUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminListDevices
        internal virtual AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request)
        {
            var marshaller = AdminListDevicesRequestMarshaller.Instance;
            var unmarshaller = AdminListDevicesResponseUnmarshaller.Instance;

            return Invoke<AdminListDevicesRequest,AdminListDevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        public virtual void AdminListDevicesAsync(AdminListDevicesRequest request, AmazonServiceCallback<AdminListDevicesRequest, AdminListDevicesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminListDevicesRequestMarshaller.Instance;
            var unmarshaller = AdminListDevicesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminListDevicesRequest,AdminListDevicesResponse> responseObject 
                            = new AmazonServiceResult<AdminListDevicesRequest,AdminListDevicesResponse>((AdminListDevicesRequest)req, (AdminListDevicesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminListDevicesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminListGroupsForUser
        internal virtual AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request)
        {
            var marshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            var unmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<AdminListGroupsForUserRequest,AdminListGroupsForUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListGroupsForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        public virtual void AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, AmazonServiceCallback<AdminListGroupsForUserRequest, AdminListGroupsForUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            var unmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminListGroupsForUserRequest,AdminListGroupsForUserResponse> responseObject 
                            = new AmazonServiceResult<AdminListGroupsForUserRequest,AdminListGroupsForUserResponse>((AdminListGroupsForUserRequest)req, (AdminListGroupsForUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminListGroupsForUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminListUserAuthEvents
        internal virtual AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request)
        {
            var marshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            var unmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;

            return Invoke<AdminListUserAuthEventsRequest,AdminListUserAuthEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListUserAuthEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListUserAuthEvents operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        public virtual void AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, AmazonServiceCallback<AdminListUserAuthEventsRequest, AdminListUserAuthEventsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            var unmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminListUserAuthEventsRequest,AdminListUserAuthEventsResponse> responseObject 
                            = new AmazonServiceResult<AdminListUserAuthEventsRequest,AdminListUserAuthEventsResponse>((AdminListUserAuthEventsRequest)req, (AdminListUserAuthEventsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminListUserAuthEventsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminRemoveUserFromGroup
        internal virtual AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request)
        {
            var marshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            var unmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<AdminRemoveUserFromGroupRequest,AdminRemoveUserFromGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminRemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRemoveUserFromGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        public virtual void AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, AmazonServiceCallback<AdminRemoveUserFromGroupRequest, AdminRemoveUserFromGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            var unmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminRemoveUserFromGroupRequest,AdminRemoveUserFromGroupResponse> responseObject 
                            = new AmazonServiceResult<AdminRemoveUserFromGroupRequest,AdminRemoveUserFromGroupResponse>((AdminRemoveUserFromGroupRequest)req, (AdminRemoveUserFromGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminRemoveUserFromGroupRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminResetUserPassword
        internal virtual AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request)
        {
            var marshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            var unmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminResetUserPasswordRequest,AdminResetUserPasswordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        public virtual void AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, AmazonServiceCallback<AdminResetUserPasswordRequest, AdminResetUserPasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            var unmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminResetUserPasswordRequest,AdminResetUserPasswordResponse> responseObject 
                            = new AmazonServiceResult<AdminResetUserPasswordRequest,AdminResetUserPasswordResponse>((AdminResetUserPasswordRequest)req, (AdminResetUserPasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminResetUserPasswordRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminRespondToAuthChallenge
        internal virtual AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request)
        {
            var marshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            var unmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<AdminRespondToAuthChallengeRequest,AdminRespondToAuthChallengeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        public virtual void AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, AmazonServiceCallback<AdminRespondToAuthChallengeRequest, AdminRespondToAuthChallengeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            var unmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminRespondToAuthChallengeRequest,AdminRespondToAuthChallengeResponse> responseObject 
                            = new AmazonServiceResult<AdminRespondToAuthChallengeRequest,AdminRespondToAuthChallengeResponse>((AdminRespondToAuthChallengeRequest)req, (AdminRespondToAuthChallengeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminRespondToAuthChallengeRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminSetUserMFAPreference
        internal virtual AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request)
        {
            var marshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            var unmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserMFAPreferenceRequest,AdminSetUserMFAPreferenceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        public virtual void AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, AmazonServiceCallback<AdminSetUserMFAPreferenceRequest, AdminSetUserMFAPreferenceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            var unmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminSetUserMFAPreferenceRequest,AdminSetUserMFAPreferenceResponse> responseObject 
                            = new AmazonServiceResult<AdminSetUserMFAPreferenceRequest,AdminSetUserMFAPreferenceResponse>((AdminSetUserMFAPreferenceRequest)req, (AdminSetUserMFAPreferenceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminSetUserMFAPreferenceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminSetUserSettings
        internal virtual AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request)
        {
            var marshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            var unmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserSettingsRequest,AdminSetUserSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        public virtual void AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, AmazonServiceCallback<AdminSetUserSettingsRequest, AdminSetUserSettingsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            var unmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminSetUserSettingsRequest,AdminSetUserSettingsResponse> responseObject 
                            = new AmazonServiceResult<AdminSetUserSettingsRequest,AdminSetUserSettingsResponse>((AdminSetUserSettingsRequest)req, (AdminSetUserSettingsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminSetUserSettingsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUpdateAuthEventFeedback
        internal virtual AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request)
        {
            var marshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            var unmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateAuthEventFeedbackRequest,AdminUpdateAuthEventFeedbackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        public virtual void AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, AmazonServiceCallback<AdminUpdateAuthEventFeedbackRequest, AdminUpdateAuthEventFeedbackResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            var unmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUpdateAuthEventFeedbackRequest,AdminUpdateAuthEventFeedbackResponse> responseObject 
                            = new AmazonServiceResult<AdminUpdateAuthEventFeedbackRequest,AdminUpdateAuthEventFeedbackResponse>((AdminUpdateAuthEventFeedbackRequest)req, (AdminUpdateAuthEventFeedbackResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminUpdateAuthEventFeedbackRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUpdateDeviceStatus
        internal virtual AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request)
        {
            var marshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            var unmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateDeviceStatusRequest,AdminUpdateDeviceStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        public virtual void AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, AmazonServiceCallback<AdminUpdateDeviceStatusRequest, AdminUpdateDeviceStatusResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            var unmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUpdateDeviceStatusRequest,AdminUpdateDeviceStatusResponse> responseObject 
                            = new AmazonServiceResult<AdminUpdateDeviceStatusRequest,AdminUpdateDeviceStatusResponse>((AdminUpdateDeviceStatusRequest)req, (AdminUpdateDeviceStatusResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminUpdateDeviceStatusRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUpdateUserAttributes
        internal virtual AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request)
        {
            var marshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            var unmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateUserAttributesRequest,AdminUpdateUserAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        public virtual void AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, AmazonServiceCallback<AdminUpdateUserAttributesRequest, AdminUpdateUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            var unmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUpdateUserAttributesRequest,AdminUpdateUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<AdminUpdateUserAttributesRequest,AdminUpdateUserAttributesResponse>((AdminUpdateUserAttributesRequest)req, (AdminUpdateUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminUpdateUserAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUserGlobalSignOut
        internal virtual AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request)
        {
            var marshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            var unmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<AdminUserGlobalSignOutRequest,AdminUserGlobalSignOutResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        public virtual void AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, AmazonServiceCallback<AdminUserGlobalSignOutRequest, AdminUserGlobalSignOutResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            var unmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUserGlobalSignOutRequest,AdminUserGlobalSignOutResponse> responseObject 
                            = new AmazonServiceResult<AdminUserGlobalSignOutRequest,AdminUserGlobalSignOutResponse>((AdminUserGlobalSignOutRequest)req, (AdminUserGlobalSignOutResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AdminUserGlobalSignOutRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  AssociateSoftwareToken
        internal virtual AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request)
        {
            var marshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            var unmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<AssociateSoftwareTokenRequest,AssociateSoftwareTokenResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        public virtual void AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, AmazonServiceCallback<AssociateSoftwareTokenRequest, AssociateSoftwareTokenResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            var unmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AssociateSoftwareTokenRequest,AssociateSoftwareTokenResponse> responseObject 
                            = new AmazonServiceResult<AssociateSoftwareTokenRequest,AssociateSoftwareTokenResponse>((AssociateSoftwareTokenRequest)req, (AssociateSoftwareTokenResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AssociateSoftwareTokenRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ChangePassword
        internal virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var marshaller = ChangePasswordRequestMarshaller.Instance;
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordRequest,ChangePasswordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        public virtual void ChangePasswordAsync(ChangePasswordRequest request, AmazonServiceCallback<ChangePasswordRequest, ChangePasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ChangePasswordRequestMarshaller.Instance;
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ChangePasswordRequest,ChangePasswordResponse> responseObject 
                            = new AmazonServiceResult<ChangePasswordRequest,ChangePasswordResponse>((ChangePasswordRequest)req, (ChangePasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ChangePasswordRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ConfirmDevice
        internal virtual ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request)
        {
            var marshaller = ConfirmDeviceRequestMarshaller.Instance;
            var unmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;

            return Invoke<ConfirmDeviceRequest,ConfirmDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        public virtual void ConfirmDeviceAsync(ConfirmDeviceRequest request, AmazonServiceCallback<ConfirmDeviceRequest, ConfirmDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ConfirmDeviceRequestMarshaller.Instance;
            var unmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ConfirmDeviceRequest,ConfirmDeviceResponse> responseObject 
                            = new AmazonServiceResult<ConfirmDeviceRequest,ConfirmDeviceResponse>((ConfirmDeviceRequest)req, (ConfirmDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ConfirmDeviceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ConfirmForgotPassword
        internal virtual ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request)
        {
            var marshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            var unmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ConfirmForgotPasswordRequest,ConfirmForgotPasswordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        public virtual void ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, AmazonServiceCallback<ConfirmForgotPasswordRequest, ConfirmForgotPasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            var unmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ConfirmForgotPasswordRequest,ConfirmForgotPasswordResponse> responseObject 
                            = new AmazonServiceResult<ConfirmForgotPasswordRequest,ConfirmForgotPasswordResponse>((ConfirmForgotPasswordRequest)req, (ConfirmForgotPasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ConfirmForgotPasswordRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ConfirmSignUp
        internal virtual ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request)
        {
            var marshaller = ConfirmSignUpRequestMarshaller.Instance;
            var unmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<ConfirmSignUpRequest,ConfirmSignUpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        public virtual void ConfirmSignUpAsync(ConfirmSignUpRequest request, AmazonServiceCallback<ConfirmSignUpRequest, ConfirmSignUpResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ConfirmSignUpRequestMarshaller.Instance;
            var unmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ConfirmSignUpRequest,ConfirmSignUpResponse> responseObject 
                            = new AmazonServiceResult<ConfirmSignUpRequest,ConfirmSignUpResponse>((ConfirmSignUpRequest)req, (ConfirmSignUpResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ConfirmSignUpRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateGroup
        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupRequest,CreateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual void CreateGroupAsync(CreateGroupRequest request, AmazonServiceCallback<CreateGroupRequest, CreateGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateGroupRequest,CreateGroupResponse> responseObject 
                            = new AmazonServiceResult<CreateGroupRequest,CreateGroupResponse>((CreateGroupRequest)req, (CreateGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateGroupRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateIdentityProvider
        internal virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
        {
            var marshaller = CreateIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityProviderRequest,CreateIdentityProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        public virtual void CreateIdentityProviderAsync(CreateIdentityProviderRequest request, AmazonServiceCallback<CreateIdentityProviderRequest, CreateIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateIdentityProviderRequest,CreateIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<CreateIdentityProviderRequest,CreateIdentityProviderResponse>((CreateIdentityProviderRequest)req, (CreateIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateIdentityProviderRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateResourceServer
        internal virtual CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request)
        {
            var marshaller = CreateResourceServerRequestMarshaller.Instance;
            var unmarshaller = CreateResourceServerResponseUnmarshaller.Instance;

            return Invoke<CreateResourceServerRequest,CreateResourceServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        public virtual void CreateResourceServerAsync(CreateResourceServerRequest request, AmazonServiceCallback<CreateResourceServerRequest, CreateResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateResourceServerRequestMarshaller.Instance;
            var unmarshaller = CreateResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateResourceServerRequest,CreateResourceServerResponse> responseObject 
                            = new AmazonServiceResult<CreateResourceServerRequest,CreateResourceServerResponse>((CreateResourceServerRequest)req, (CreateResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateResourceServerRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserImportJob
        internal virtual CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request)
        {
            var marshaller = CreateUserImportJobRequestMarshaller.Instance;
            var unmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateUserImportJobRequest,CreateUserImportJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        public virtual void CreateUserImportJobAsync(CreateUserImportJobRequest request, AmazonServiceCallback<CreateUserImportJobRequest, CreateUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateUserImportJobRequestMarshaller.Instance;
            var unmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserImportJobRequest,CreateUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<CreateUserImportJobRequest,CreateUserImportJobResponse>((CreateUserImportJobRequest)req, (CreateUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateUserImportJobRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserPool
        internal virtual CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
        {
            var marshaller = CreateUserPoolRequestMarshaller.Instance;
            var unmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolRequest,CreateUserPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        public virtual void CreateUserPoolAsync(CreateUserPoolRequest request, AmazonServiceCallback<CreateUserPoolRequest, CreateUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateUserPoolRequestMarshaller.Instance;
            var unmarshaller = CreateUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserPoolRequest,CreateUserPoolResponse> responseObject 
                            = new AmazonServiceResult<CreateUserPoolRequest,CreateUserPoolResponse>((CreateUserPoolRequest)req, (CreateUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateUserPoolRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserPoolClient
        internal virtual CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
        {
            var marshaller = CreateUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolClientRequest,CreateUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        public virtual void CreateUserPoolClientAsync(CreateUserPoolClientRequest request, AmazonServiceCallback<CreateUserPoolClientRequest, CreateUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserPoolClientRequest,CreateUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<CreateUserPoolClientRequest,CreateUserPoolClientResponse>((CreateUserPoolClientRequest)req, (CreateUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateUserPoolClientRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserPoolDomain
        internal virtual CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request)
        {
            var marshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            var unmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolDomainRequest,CreateUserPoolDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        public virtual void CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, AmazonServiceCallback<CreateUserPoolDomainRequest, CreateUserPoolDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            var unmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserPoolDomainRequest,CreateUserPoolDomainResponse> responseObject 
                            = new AmazonServiceResult<CreateUserPoolDomainRequest,CreateUserPoolDomainResponse>((CreateUserPoolDomainRequest)req, (CreateUserPoolDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateUserPoolDomainRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteGroup
        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual void DeleteGroupAsync(DeleteGroupRequest request, AmazonServiceCallback<DeleteGroupRequest, DeleteGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteGroupRequest,DeleteGroupResponse> responseObject 
                            = new AmazonServiceResult<DeleteGroupRequest,DeleteGroupResponse>((DeleteGroupRequest)req, (DeleteGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteGroupRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteIdentityProvider
        internal virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
        {
            var marshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityProviderRequest,DeleteIdentityProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        public virtual void DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, AmazonServiceCallback<DeleteIdentityProviderRequest, DeleteIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteIdentityProviderRequest,DeleteIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<DeleteIdentityProviderRequest,DeleteIdentityProviderResponse>((DeleteIdentityProviderRequest)req, (DeleteIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteIdentityProviderRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteResourceServer
        internal virtual DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request)
        {
            var marshaller = DeleteResourceServerRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceServerRequest,DeleteResourceServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        public virtual void DeleteResourceServerAsync(DeleteResourceServerRequest request, AmazonServiceCallback<DeleteResourceServerRequest, DeleteResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteResourceServerRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteResourceServerRequest,DeleteResourceServerResponse> responseObject 
                            = new AmazonServiceResult<DeleteResourceServerRequest,DeleteResourceServerResponse>((DeleteResourceServerRequest)req, (DeleteResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteResourceServerRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUser
        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual void DeleteUserAsync(DeleteUserRequest request, AmazonServiceCallback<DeleteUserRequest, DeleteUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserRequest,DeleteUserResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserRequest,DeleteUserResponse>((DeleteUserRequest)req, (DeleteUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserAttributes
        internal virtual DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request)
        {
            var marshaller = DeleteUserAttributesRequestMarshaller.Instance;
            var unmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteUserAttributesRequest,DeleteUserAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        public virtual void DeleteUserAttributesAsync(DeleteUserAttributesRequest request, AmazonServiceCallback<DeleteUserAttributesRequest, DeleteUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteUserAttributesRequestMarshaller.Instance;
            var unmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserAttributesRequest,DeleteUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserAttributesRequest,DeleteUserAttributesResponse>((DeleteUserAttributesRequest)req, (DeleteUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteUserAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPool
        internal virtual DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
        {
            var marshaller = DeleteUserPoolRequestMarshaller.Instance;
            var unmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolRequest,DeleteUserPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        public virtual void DeleteUserPoolAsync(DeleteUserPoolRequest request, AmazonServiceCallback<DeleteUserPoolRequest, DeleteUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteUserPoolRequestMarshaller.Instance;
            var unmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPoolRequest,DeleteUserPoolResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPoolRequest,DeleteUserPoolResponse>((DeleteUserPoolRequest)req, (DeleteUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteUserPoolRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPoolClient
        internal virtual DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
        {
            var marshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolClientRequest,DeleteUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        public virtual void DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, AmazonServiceCallback<DeleteUserPoolClientRequest, DeleteUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPoolClientRequest,DeleteUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPoolClientRequest,DeleteUserPoolClientResponse>((DeleteUserPoolClientRequest)req, (DeleteUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteUserPoolClientRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPoolDomain
        internal virtual DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request)
        {
            var marshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            var unmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolDomainRequest,DeleteUserPoolDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        public virtual void DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, AmazonServiceCallback<DeleteUserPoolDomainRequest, DeleteUserPoolDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            var unmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPoolDomainRequest,DeleteUserPoolDomainResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPoolDomainRequest,DeleteUserPoolDomainResponse>((DeleteUserPoolDomainRequest)req, (DeleteUserPoolDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteUserPoolDomainRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeIdentityProvider
        internal virtual DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request)
        {
            var marshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderRequest,DescribeIdentityProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        public virtual void DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, AmazonServiceCallback<DescribeIdentityProviderRequest, DescribeIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeIdentityProviderRequest,DescribeIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<DescribeIdentityProviderRequest,DescribeIdentityProviderResponse>((DescribeIdentityProviderRequest)req, (DescribeIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeIdentityProviderRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeResourceServer
        internal virtual DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request)
        {
            var marshaller = DescribeResourceServerRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceServerRequest,DescribeResourceServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        public virtual void DescribeResourceServerAsync(DescribeResourceServerRequest request, AmazonServiceCallback<DescribeResourceServerRequest, DescribeResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeResourceServerRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeResourceServerRequest,DescribeResourceServerResponse> responseObject 
                            = new AmazonServiceResult<DescribeResourceServerRequest,DescribeResourceServerResponse>((DescribeResourceServerRequest)req, (DescribeResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeResourceServerRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeRiskConfiguration
        internal virtual DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request)
        {
            var marshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            var unmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRiskConfigurationRequest,DescribeRiskConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        public virtual void DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, AmazonServiceCallback<DescribeRiskConfigurationRequest, DescribeRiskConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            var unmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeRiskConfigurationRequest,DescribeRiskConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DescribeRiskConfigurationRequest,DescribeRiskConfigurationResponse>((DescribeRiskConfigurationRequest)req, (DescribeRiskConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeRiskConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserImportJob
        internal virtual DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request)
        {
            var marshaller = DescribeUserImportJobRequestMarshaller.Instance;
            var unmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeUserImportJobRequest,DescribeUserImportJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        public virtual void DescribeUserImportJobAsync(DescribeUserImportJobRequest request, AmazonServiceCallback<DescribeUserImportJobRequest, DescribeUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeUserImportJobRequestMarshaller.Instance;
            var unmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserImportJobRequest,DescribeUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserImportJobRequest,DescribeUserImportJobResponse>((DescribeUserImportJobRequest)req, (DescribeUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeUserImportJobRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserPool
        internal virtual DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request)
        {
            var marshaller = DescribeUserPoolRequestMarshaller.Instance;
            var unmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolRequest,DescribeUserPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        public virtual void DescribeUserPoolAsync(DescribeUserPoolRequest request, AmazonServiceCallback<DescribeUserPoolRequest, DescribeUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeUserPoolRequestMarshaller.Instance;
            var unmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserPoolRequest,DescribeUserPoolResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserPoolRequest,DescribeUserPoolResponse>((DescribeUserPoolRequest)req, (DescribeUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeUserPoolRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserPoolClient
        internal virtual DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request)
        {
            var marshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolClientRequest,DescribeUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        public virtual void DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, AmazonServiceCallback<DescribeUserPoolClientRequest, DescribeUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserPoolClientRequest,DescribeUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserPoolClientRequest,DescribeUserPoolClientResponse>((DescribeUserPoolClientRequest)req, (DescribeUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeUserPoolClientRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserPoolDomain
        internal virtual DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request)
        {
            var marshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            var unmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolDomainRequest,DescribeUserPoolDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        public virtual void DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, AmazonServiceCallback<DescribeUserPoolDomainRequest, DescribeUserPoolDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            var unmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserPoolDomainRequest,DescribeUserPoolDomainResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserPoolDomainRequest,DescribeUserPoolDomainResponse>((DescribeUserPoolDomainRequest)req, (DescribeUserPoolDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeUserPoolDomainRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ForgetDevice
        internal virtual ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request)
        {
            var marshaller = ForgetDeviceRequestMarshaller.Instance;
            var unmarshaller = ForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<ForgetDeviceRequest,ForgetDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        public virtual void ForgetDeviceAsync(ForgetDeviceRequest request, AmazonServiceCallback<ForgetDeviceRequest, ForgetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ForgetDeviceRequestMarshaller.Instance;
            var unmarshaller = ForgetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ForgetDeviceRequest,ForgetDeviceResponse> responseObject 
                            = new AmazonServiceResult<ForgetDeviceRequest,ForgetDeviceResponse>((ForgetDeviceRequest)req, (ForgetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ForgetDeviceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ForgotPassword
        internal virtual ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request)
        {
            var marshaller = ForgotPasswordRequestMarshaller.Instance;
            var unmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ForgotPasswordRequest,ForgotPasswordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        public virtual void ForgotPasswordAsync(ForgotPasswordRequest request, AmazonServiceCallback<ForgotPasswordRequest, ForgotPasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ForgotPasswordRequestMarshaller.Instance;
            var unmarshaller = ForgotPasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ForgotPasswordRequest,ForgotPasswordResponse> responseObject 
                            = new AmazonServiceResult<ForgotPasswordRequest,ForgotPasswordResponse>((ForgotPasswordRequest)req, (ForgotPasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ForgotPasswordRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetCSVHeader
        internal virtual GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request)
        {
            var marshaller = GetCSVHeaderRequestMarshaller.Instance;
            var unmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;

            return Invoke<GetCSVHeaderRequest,GetCSVHeaderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        public virtual void GetCSVHeaderAsync(GetCSVHeaderRequest request, AmazonServiceCallback<GetCSVHeaderRequest, GetCSVHeaderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetCSVHeaderRequestMarshaller.Instance;
            var unmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCSVHeaderRequest,GetCSVHeaderResponse> responseObject 
                            = new AmazonServiceResult<GetCSVHeaderRequest,GetCSVHeaderResponse>((GetCSVHeaderRequest)req, (GetCSVHeaderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetCSVHeaderRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetDevice
        internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var marshaller = GetDeviceRequestMarshaller.Instance;
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceRequest,GetDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual void GetDeviceAsync(GetDeviceRequest request, AmazonServiceCallback<GetDeviceRequest, GetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetDeviceRequestMarshaller.Instance;
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetDeviceRequest,GetDeviceResponse> responseObject 
                            = new AmazonServiceResult<GetDeviceRequest,GetDeviceResponse>((GetDeviceRequest)req, (GetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetDeviceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetGroup
        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var marshaller = GetGroupRequestMarshaller.Instance;
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupRequest,GetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual void GetGroupAsync(GetGroupRequest request, AmazonServiceCallback<GetGroupRequest, GetGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetGroupRequestMarshaller.Instance;
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetGroupRequest,GetGroupResponse> responseObject 
                            = new AmazonServiceResult<GetGroupRequest,GetGroupResponse>((GetGroupRequest)req, (GetGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetGroupRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetIdentityProviderByIdentifier
        internal virtual GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request)
        {
            var marshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            var unmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;

            return Invoke<GetIdentityProviderByIdentifierRequest,GetIdentityProviderByIdentifierResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityProviderByIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProviderByIdentifier operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        public virtual void GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, AmazonServiceCallback<GetIdentityProviderByIdentifierRequest, GetIdentityProviderByIdentifierResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            var unmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetIdentityProviderByIdentifierRequest,GetIdentityProviderByIdentifierResponse> responseObject 
                            = new AmazonServiceResult<GetIdentityProviderByIdentifierRequest,GetIdentityProviderByIdentifierResponse>((GetIdentityProviderByIdentifierRequest)req, (GetIdentityProviderByIdentifierResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetIdentityProviderByIdentifierRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetSigningCertificate
        internal virtual GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request)
        {
            var marshaller = GetSigningCertificateRequestMarshaller.Instance;
            var unmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<GetSigningCertificateRequest,GetSigningCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningCertificate operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        public virtual void GetSigningCertificateAsync(GetSigningCertificateRequest request, AmazonServiceCallback<GetSigningCertificateRequest, GetSigningCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetSigningCertificateRequestMarshaller.Instance;
            var unmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetSigningCertificateRequest,GetSigningCertificateResponse> responseObject 
                            = new AmazonServiceResult<GetSigningCertificateRequest,GetSigningCertificateResponse>((GetSigningCertificateRequest)req, (GetSigningCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetSigningCertificateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetUICustomization
        internal virtual GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request)
        {
            var marshaller = GetUICustomizationRequestMarshaller.Instance;
            var unmarshaller = GetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<GetUICustomizationRequest,GetUICustomizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        public virtual void GetUICustomizationAsync(GetUICustomizationRequest request, AmazonServiceCallback<GetUICustomizationRequest, GetUICustomizationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetUICustomizationRequestMarshaller.Instance;
            var unmarshaller = GetUICustomizationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUICustomizationRequest,GetUICustomizationResponse> responseObject 
                            = new AmazonServiceResult<GetUICustomizationRequest,GetUICustomizationResponse>((GetUICustomizationRequest)req, (GetUICustomizationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetUICustomizationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetUser
        internal virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var marshaller = GetUserRequestMarshaller.Instance;
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserRequest,GetUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual void GetUserAsync(GetUserRequest request, AmazonServiceCallback<GetUserRequest, GetUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetUserRequestMarshaller.Instance;
            var unmarshaller = GetUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserRequest,GetUserResponse> responseObject 
                            = new AmazonServiceResult<GetUserRequest,GetUserResponse>((GetUserRequest)req, (GetUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetUserRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetUserAttributeVerificationCode
        internal virtual GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request)
        {
            var marshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            var unmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<GetUserAttributeVerificationCodeRequest,GetUserAttributeVerificationCodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        public virtual void GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, AmazonServiceCallback<GetUserAttributeVerificationCodeRequest, GetUserAttributeVerificationCodeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            var unmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserAttributeVerificationCodeRequest,GetUserAttributeVerificationCodeResponse> responseObject 
                            = new AmazonServiceResult<GetUserAttributeVerificationCodeRequest,GetUserAttributeVerificationCodeResponse>((GetUserAttributeVerificationCodeRequest)req, (GetUserAttributeVerificationCodeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetUserAttributeVerificationCodeRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetUserPoolMfaConfig
        internal virtual GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request)
        {
            var marshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            var unmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<GetUserPoolMfaConfigRequest,GetUserPoolMfaConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        public virtual void GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, AmazonServiceCallback<GetUserPoolMfaConfigRequest, GetUserPoolMfaConfigResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            var unmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserPoolMfaConfigRequest,GetUserPoolMfaConfigResponse> responseObject 
                            = new AmazonServiceResult<GetUserPoolMfaConfigRequest,GetUserPoolMfaConfigResponse>((GetUserPoolMfaConfigRequest)req, (GetUserPoolMfaConfigResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetUserPoolMfaConfigRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GlobalSignOut
        internal virtual GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request)
        {
            var marshaller = GlobalSignOutRequestMarshaller.Instance;
            var unmarshaller = GlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<GlobalSignOutRequest,GlobalSignOutResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        public virtual void GlobalSignOutAsync(GlobalSignOutRequest request, AmazonServiceCallback<GlobalSignOutRequest, GlobalSignOutResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GlobalSignOutRequestMarshaller.Instance;
            var unmarshaller = GlobalSignOutResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GlobalSignOutRequest,GlobalSignOutResponse> responseObject 
                            = new AmazonServiceResult<GlobalSignOutRequest,GlobalSignOutResponse>((GlobalSignOutRequest)req, (GlobalSignOutResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GlobalSignOutRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  InitiateAuth
        internal virtual InitiateAuthResponse InitiateAuth(InitiateAuthRequest request)
        {
            var marshaller = InitiateAuthRequestMarshaller.Instance;
            var unmarshaller = InitiateAuthResponseUnmarshaller.Instance;

            return Invoke<InitiateAuthRequest,InitiateAuthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        public virtual void InitiateAuthAsync(InitiateAuthRequest request, AmazonServiceCallback<InitiateAuthRequest, InitiateAuthResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = InitiateAuthRequestMarshaller.Instance;
            var unmarshaller = InitiateAuthResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<InitiateAuthRequest,InitiateAuthResponse> responseObject 
                            = new AmazonServiceResult<InitiateAuthRequest,InitiateAuthResponse>((InitiateAuthRequest)req, (InitiateAuthResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<InitiateAuthRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListDevices
        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var marshaller = ListDevicesRequestMarshaller.Instance;
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesRequest,ListDevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual void ListDevicesAsync(ListDevicesRequest request, AmazonServiceCallback<ListDevicesRequest, ListDevicesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListDevicesRequestMarshaller.Instance;
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListDevicesRequest,ListDevicesResponse> responseObject 
                            = new AmazonServiceResult<ListDevicesRequest,ListDevicesResponse>((ListDevicesRequest)req, (ListDevicesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListDevicesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListGroups
        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsRequest,ListGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual void ListGroupsAsync(ListGroupsRequest request, AmazonServiceCallback<ListGroupsRequest, ListGroupsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListGroupsRequest,ListGroupsResponse> responseObject 
                            = new AmazonServiceResult<ListGroupsRequest,ListGroupsResponse>((ListGroupsRequest)req, (ListGroupsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListGroupsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListIdentityProviders
        internal virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            var marshaller = ListIdentityProvidersRequestMarshaller.Instance;
            var unmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProvidersRequest,ListIdentityProvidersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual void ListIdentityProvidersAsync(ListIdentityProvidersRequest request, AmazonServiceCallback<ListIdentityProvidersRequest, ListIdentityProvidersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListIdentityProvidersRequestMarshaller.Instance;
            var unmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListIdentityProvidersRequest,ListIdentityProvidersResponse> responseObject 
                            = new AmazonServiceResult<ListIdentityProvidersRequest,ListIdentityProvidersResponse>((ListIdentityProvidersRequest)req, (ListIdentityProvidersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListIdentityProvidersRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListResourceServers
        internal virtual ListResourceServersResponse ListResourceServers(ListResourceServersRequest request)
        {
            var marshaller = ListResourceServersRequestMarshaller.Instance;
            var unmarshaller = ListResourceServersResponseUnmarshaller.Instance;

            return Invoke<ListResourceServersRequest,ListResourceServersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceServers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        public virtual void ListResourceServersAsync(ListResourceServersRequest request, AmazonServiceCallback<ListResourceServersRequest, ListResourceServersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListResourceServersRequestMarshaller.Instance;
            var unmarshaller = ListResourceServersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListResourceServersRequest,ListResourceServersResponse> responseObject 
                            = new AmazonServiceResult<ListResourceServersRequest,ListResourceServersResponse>((ListResourceServersRequest)req, (ListResourceServersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListResourceServersRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserImportJobs
        internal virtual ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request)
        {
            var marshaller = ListUserImportJobsRequestMarshaller.Instance;
            var unmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListUserImportJobsRequest,ListUserImportJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        public virtual void ListUserImportJobsAsync(ListUserImportJobsRequest request, AmazonServiceCallback<ListUserImportJobsRequest, ListUserImportJobsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListUserImportJobsRequestMarshaller.Instance;
            var unmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserImportJobsRequest,ListUserImportJobsResponse> responseObject 
                            = new AmazonServiceResult<ListUserImportJobsRequest,ListUserImportJobsResponse>((ListUserImportJobsRequest)req, (ListUserImportJobsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListUserImportJobsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserPoolClients
        internal virtual ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
        {
            var marshaller = ListUserPoolClientsRequestMarshaller.Instance;
            var unmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolClientsRequest,ListUserPoolClientsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        public virtual void ListUserPoolClientsAsync(ListUserPoolClientsRequest request, AmazonServiceCallback<ListUserPoolClientsRequest, ListUserPoolClientsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListUserPoolClientsRequestMarshaller.Instance;
            var unmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserPoolClientsRequest,ListUserPoolClientsResponse> responseObject 
                            = new AmazonServiceResult<ListUserPoolClientsRequest,ListUserPoolClientsResponse>((ListUserPoolClientsRequest)req, (ListUserPoolClientsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListUserPoolClientsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserPools
        internal virtual ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
        {
            var marshaller = ListUserPoolsRequestMarshaller.Instance;
            var unmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolsRequest,ListUserPoolsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        public virtual void ListUserPoolsAsync(ListUserPoolsRequest request, AmazonServiceCallback<ListUserPoolsRequest, ListUserPoolsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListUserPoolsRequestMarshaller.Instance;
            var unmarshaller = ListUserPoolsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserPoolsRequest,ListUserPoolsResponse> responseObject 
                            = new AmazonServiceResult<ListUserPoolsRequest,ListUserPoolsResponse>((ListUserPoolsRequest)req, (ListUserPoolsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListUserPoolsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListUsers
        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual void ListUsersAsync(ListUsersRequest request, AmazonServiceCallback<ListUsersRequest, ListUsersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUsersRequest,ListUsersResponse> responseObject 
                            = new AmazonServiceResult<ListUsersRequest,ListUsersResponse>((ListUsersRequest)req, (ListUsersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListUsersRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListUsersInGroup
        internal virtual ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request)
        {
            var marshaller = ListUsersInGroupRequestMarshaller.Instance;
            var unmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;

            return Invoke<ListUsersInGroupRequest,ListUsersInGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsersInGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsersInGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        public virtual void ListUsersInGroupAsync(ListUsersInGroupRequest request, AmazonServiceCallback<ListUsersInGroupRequest, ListUsersInGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListUsersInGroupRequestMarshaller.Instance;
            var unmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUsersInGroupRequest,ListUsersInGroupResponse> responseObject 
                            = new AmazonServiceResult<ListUsersInGroupRequest,ListUsersInGroupResponse>((ListUsersInGroupRequest)req, (ListUsersInGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListUsersInGroupRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ResendConfirmationCode
        internal virtual ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request)
        {
            var marshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            var unmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return Invoke<ResendConfirmationCodeRequest,ResendConfirmationCodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        public virtual void ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, AmazonServiceCallback<ResendConfirmationCodeRequest, ResendConfirmationCodeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            var unmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ResendConfirmationCodeRequest,ResendConfirmationCodeResponse> responseObject 
                            = new AmazonServiceResult<ResendConfirmationCodeRequest,ResendConfirmationCodeResponse>((ResendConfirmationCodeRequest)req, (ResendConfirmationCodeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ResendConfirmationCodeRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  RespondToAuthChallenge
        internal virtual RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request)
        {
            var marshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            var unmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<RespondToAuthChallengeRequest,RespondToAuthChallengeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        public virtual void RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, AmazonServiceCallback<RespondToAuthChallengeRequest, RespondToAuthChallengeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            var unmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RespondToAuthChallengeRequest,RespondToAuthChallengeResponse> responseObject 
                            = new AmazonServiceResult<RespondToAuthChallengeRequest,RespondToAuthChallengeResponse>((RespondToAuthChallengeRequest)req, (RespondToAuthChallengeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<RespondToAuthChallengeRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetRiskConfiguration
        internal virtual SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request)
        {
            var marshaller = SetRiskConfigurationRequestMarshaller.Instance;
            var unmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetRiskConfigurationRequest,SetRiskConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        public virtual void SetRiskConfigurationAsync(SetRiskConfigurationRequest request, AmazonServiceCallback<SetRiskConfigurationRequest, SetRiskConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetRiskConfigurationRequestMarshaller.Instance;
            var unmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetRiskConfigurationRequest,SetRiskConfigurationResponse> responseObject 
                            = new AmazonServiceResult<SetRiskConfigurationRequest,SetRiskConfigurationResponse>((SetRiskConfigurationRequest)req, (SetRiskConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetRiskConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetUICustomization
        internal virtual SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request)
        {
            var marshaller = SetUICustomizationRequestMarshaller.Instance;
            var unmarshaller = SetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<SetUICustomizationRequest,SetUICustomizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        public virtual void SetUICustomizationAsync(SetUICustomizationRequest request, AmazonServiceCallback<SetUICustomizationRequest, SetUICustomizationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetUICustomizationRequestMarshaller.Instance;
            var unmarshaller = SetUICustomizationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUICustomizationRequest,SetUICustomizationResponse> responseObject 
                            = new AmazonServiceResult<SetUICustomizationRequest,SetUICustomizationResponse>((SetUICustomizationRequest)req, (SetUICustomizationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetUICustomizationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetUserMFAPreference
        internal virtual SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request)
        {
            var marshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            var unmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<SetUserMFAPreferenceRequest,SetUserMFAPreferenceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        public virtual void SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, AmazonServiceCallback<SetUserMFAPreferenceRequest, SetUserMFAPreferenceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            var unmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUserMFAPreferenceRequest,SetUserMFAPreferenceResponse> responseObject 
                            = new AmazonServiceResult<SetUserMFAPreferenceRequest,SetUserMFAPreferenceResponse>((SetUserMFAPreferenceRequest)req, (SetUserMFAPreferenceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetUserMFAPreferenceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetUserPoolMfaConfig
        internal virtual SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request)
        {
            var marshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            var unmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<SetUserPoolMfaConfigRequest,SetUserPoolMfaConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        public virtual void SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, AmazonServiceCallback<SetUserPoolMfaConfigRequest, SetUserPoolMfaConfigResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            var unmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUserPoolMfaConfigRequest,SetUserPoolMfaConfigResponse> responseObject 
                            = new AmazonServiceResult<SetUserPoolMfaConfigRequest,SetUserPoolMfaConfigResponse>((SetUserPoolMfaConfigRequest)req, (SetUserPoolMfaConfigResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetUserPoolMfaConfigRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetUserSettings
        internal virtual SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request)
        {
            var marshaller = SetUserSettingsRequestMarshaller.Instance;
            var unmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<SetUserSettingsRequest,SetUserSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        public virtual void SetUserSettingsAsync(SetUserSettingsRequest request, AmazonServiceCallback<SetUserSettingsRequest, SetUserSettingsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetUserSettingsRequestMarshaller.Instance;
            var unmarshaller = SetUserSettingsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUserSettingsRequest,SetUserSettingsResponse> responseObject 
                            = new AmazonServiceResult<SetUserSettingsRequest,SetUserSettingsResponse>((SetUserSettingsRequest)req, (SetUserSettingsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetUserSettingsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SignUp
        internal virtual SignUpResponse SignUp(SignUpRequest request)
        {
            var marshaller = SignUpRequestMarshaller.Instance;
            var unmarshaller = SignUpResponseUnmarshaller.Instance;

            return Invoke<SignUpRequest,SignUpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        public virtual void SignUpAsync(SignUpRequest request, AmazonServiceCallback<SignUpRequest, SignUpResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SignUpRequestMarshaller.Instance;
            var unmarshaller = SignUpResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SignUpRequest,SignUpResponse> responseObject 
                            = new AmazonServiceResult<SignUpRequest,SignUpResponse>((SignUpRequest)req, (SignUpResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SignUpRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  StartUserImportJob
        internal virtual StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request)
        {
            var marshaller = StartUserImportJobRequestMarshaller.Instance;
            var unmarshaller = StartUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StartUserImportJobRequest,StartUserImportJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        public virtual void StartUserImportJobAsync(StartUserImportJobRequest request, AmazonServiceCallback<StartUserImportJobRequest, StartUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = StartUserImportJobRequestMarshaller.Instance;
            var unmarshaller = StartUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartUserImportJobRequest,StartUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<StartUserImportJobRequest,StartUserImportJobResponse>((StartUserImportJobRequest)req, (StartUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<StartUserImportJobRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  StopUserImportJob
        internal virtual StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request)
        {
            var marshaller = StopUserImportJobRequestMarshaller.Instance;
            var unmarshaller = StopUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StopUserImportJobRequest,StopUserImportJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        public virtual void StopUserImportJobAsync(StopUserImportJobRequest request, AmazonServiceCallback<StopUserImportJobRequest, StopUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = StopUserImportJobRequestMarshaller.Instance;
            var unmarshaller = StopUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StopUserImportJobRequest,StopUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<StopUserImportJobRequest,StopUserImportJobResponse>((StopUserImportJobRequest)req, (StopUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<StopUserImportJobRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateAuthEventFeedback
        internal virtual UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request)
        {
            var marshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthEventFeedbackRequest,UpdateAuthEventFeedbackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        public virtual void UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, AmazonServiceCallback<UpdateAuthEventFeedbackRequest, UpdateAuthEventFeedbackResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateAuthEventFeedbackRequest,UpdateAuthEventFeedbackResponse> responseObject 
                            = new AmazonServiceResult<UpdateAuthEventFeedbackRequest,UpdateAuthEventFeedbackResponse>((UpdateAuthEventFeedbackRequest)req, (UpdateAuthEventFeedbackResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateAuthEventFeedbackRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateDeviceStatus
        internal virtual UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request)
        {
            var marshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceStatusRequest,UpdateDeviceStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        public virtual void UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, AmazonServiceCallback<UpdateDeviceStatusRequest, UpdateDeviceStatusResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateDeviceStatusRequest,UpdateDeviceStatusResponse> responseObject 
                            = new AmazonServiceResult<UpdateDeviceStatusRequest,UpdateDeviceStatusResponse>((UpdateDeviceStatusRequest)req, (UpdateDeviceStatusResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateDeviceStatusRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateGroup
        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual void UpdateGroupAsync(UpdateGroupRequest request, AmazonServiceCallback<UpdateGroupRequest, UpdateGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateGroupRequest,UpdateGroupResponse> responseObject 
                            = new AmazonServiceResult<UpdateGroupRequest,UpdateGroupResponse>((UpdateGroupRequest)req, (UpdateGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateGroupRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateIdentityProvider
        internal virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
        {
            var marshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderRequest,UpdateIdentityProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        public virtual void UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, AmazonServiceCallback<UpdateIdentityProviderRequest, UpdateIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            var unmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateIdentityProviderRequest,UpdateIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<UpdateIdentityProviderRequest,UpdateIdentityProviderResponse>((UpdateIdentityProviderRequest)req, (UpdateIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateIdentityProviderRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateResourceServer
        internal virtual UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request)
        {
            var marshaller = UpdateResourceServerRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceServerRequest,UpdateResourceServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        public virtual void UpdateResourceServerAsync(UpdateResourceServerRequest request, AmazonServiceCallback<UpdateResourceServerRequest, UpdateResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateResourceServerRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateResourceServerRequest,UpdateResourceServerResponse> responseObject 
                            = new AmazonServiceResult<UpdateResourceServerRequest,UpdateResourceServerResponse>((UpdateResourceServerRequest)req, (UpdateResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateResourceServerRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUserAttributes
        internal virtual UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request)
        {
            var marshaller = UpdateUserAttributesRequestMarshaller.Instance;
            var unmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateUserAttributesRequest,UpdateUserAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        public virtual void UpdateUserAttributesAsync(UpdateUserAttributesRequest request, AmazonServiceCallback<UpdateUserAttributesRequest, UpdateUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateUserAttributesRequestMarshaller.Instance;
            var unmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserAttributesRequest,UpdateUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserAttributesRequest,UpdateUserAttributesResponse>((UpdateUserAttributesRequest)req, (UpdateUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateUserAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUserPool
        internal virtual UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
        {
            var marshaller = UpdateUserPoolRequestMarshaller.Instance;
            var unmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolRequest,UpdateUserPoolResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        public virtual void UpdateUserPoolAsync(UpdateUserPoolRequest request, AmazonServiceCallback<UpdateUserPoolRequest, UpdateUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateUserPoolRequestMarshaller.Instance;
            var unmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserPoolRequest,UpdateUserPoolResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserPoolRequest,UpdateUserPoolResponse>((UpdateUserPoolRequest)req, (UpdateUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateUserPoolRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUserPoolClient
        internal virtual UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
        {
            var marshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolClientRequest,UpdateUserPoolClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        public virtual void UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, AmazonServiceCallback<UpdateUserPoolClientRequest, UpdateUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            var unmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserPoolClientRequest,UpdateUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserPoolClientRequest,UpdateUserPoolClientResponse>((UpdateUserPoolClientRequest)req, (UpdateUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateUserPoolClientRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  VerifySoftwareToken
        internal virtual VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request)
        {
            var marshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            var unmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<VerifySoftwareTokenRequest,VerifySoftwareTokenResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifySoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        public virtual void VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, AmazonServiceCallback<VerifySoftwareTokenRequest, VerifySoftwareTokenResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            var unmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifySoftwareTokenRequest,VerifySoftwareTokenResponse> responseObject 
                            = new AmazonServiceResult<VerifySoftwareTokenRequest,VerifySoftwareTokenResponse>((VerifySoftwareTokenRequest)req, (VerifySoftwareTokenResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<VerifySoftwareTokenRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  VerifyUserAttribute
        internal virtual VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request)
        {
            var marshaller = VerifyUserAttributeRequestMarshaller.Instance;
            var unmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return Invoke<VerifyUserAttributeRequest,VerifyUserAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        public virtual void VerifyUserAttributeAsync(VerifyUserAttributeRequest request, AmazonServiceCallback<VerifyUserAttributeRequest, VerifyUserAttributeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = VerifyUserAttributeRequestMarshaller.Instance;
            var unmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifyUserAttributeRequest,VerifyUserAttributeResponse> responseObject 
                            = new AmazonServiceResult<VerifyUserAttributeRequest,VerifyUserAttributeResponse>((VerifyUserAttributeRequest)req, (VerifyUserAttributeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<VerifyUserAttributeRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
    }
}