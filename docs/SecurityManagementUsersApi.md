# Bess.IO.Rest.Nexus3.Api.SecurityManagementUsersApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePassword**](SecurityManagementUsersApi.md#changepassword) | **PUT** /v1/security/users/{userId}/change-password | Change a user&#39;s password.
[**CreateUser**](SecurityManagementUsersApi.md#createuser) | **POST** /v1/security/users | Create a new user in the default source.
[**DeleteUser**](SecurityManagementUsersApi.md#deleteuser) | **DELETE** /v1/security/users/{userId} | Delete a user.
[**GetUsers**](SecurityManagementUsersApi.md#getusers) | **GET** /v1/security/users | Retrieve a list of users. Note if the source is not &#39;default&#39; the response is limited to 100 users.
[**UpdateUser**](SecurityManagementUsersApi.md#updateuser) | **PUT** /v1/security/users/{userId} | Update an existing user.


<a name="changepassword"></a>
# **ChangePassword**
> void ChangePassword (string userId, string body = null)

Change a user's password.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementUsersApi();
            var userId = userId_example;  // string | The userid the request should apply to.
            var body = body_example;  // string | The new password to use. (optional) 

            try
            {
                // Change a user's password.
                apiInstance.ChangePassword(userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementUsersApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The userid the request should apply to. | 
 **body** | **string**| The new password to use. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> ApiUser CreateUser (ApiCreateUser body = null)

Create a new user in the default source.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementUsersApi();
            var body = new ApiCreateUser(); // ApiCreateUser | A representation of the user to create. (optional) 

            try
            {
                // Create a new user in the default source.
                ApiUser result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementUsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiCreateUser**](ApiCreateUser.md)| A representation of the user to create. | [optional] 

### Return type

[**ApiUser**](ApiUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string userId)

Delete a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementUsersApi();
            var userId = userId_example;  // string | The userid the request should apply to.

            try
            {
                // Delete a user.
                apiInstance.DeleteUser(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementUsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The userid the request should apply to. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> List<ApiUser> GetUsers (string userId = null, string source = null)

Retrieve a list of users. Note if the source is not 'default' the response is limited to 100 users.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementUsersApi();
            var userId = userId_example;  // string | An optional term to search userids for. (optional) 
            var source = source_example;  // string | An optional user source to restrict the search to. (optional) 

            try
            {
                // Retrieve a list of users. Note if the source is not 'default' the response is limited to 100 users.
                List&lt;ApiUser&gt; result = apiInstance.GetUsers(userId, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementUsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| An optional term to search userids for. | [optional] 
 **source** | **string**| An optional user source to restrict the search to. | [optional] 

### Return type

[**List<ApiUser>**](ApiUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (string userId, ApiUser body = null)

Update an existing user.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementUsersApi();
            var userId = userId_example;  // string | The userid the request should apply to.
            var body = new ApiUser(); // ApiUser | A representation of the user to update. (optional) 

            try
            {
                // Update an existing user.
                apiInstance.UpdateUser(userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementUsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The userid the request should apply to. | 
 **body** | [**ApiUser**](ApiUser.md)| A representation of the user to update. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

