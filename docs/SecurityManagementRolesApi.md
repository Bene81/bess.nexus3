# Bess.IO.Rest.Nexus3.Api.SecurityManagementRolesApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](SecurityManagementRolesApi.md#create) | **POST** /v1/security/roles | Create role
[**Delete**](SecurityManagementRolesApi.md#delete) | **DELETE** /v1/security/roles/{id} | Delete role
[**GetRole**](SecurityManagementRolesApi.md#getrole) | **GET** /v1/security/roles/{id} | Get role
[**GetRoles**](SecurityManagementRolesApi.md#getroles) | **GET** /v1/security/roles | List roles
[**Update1**](SecurityManagementRolesApi.md#update1) | **PUT** /v1/security/roles/{id} | Update role


<a name="create"></a>
# **Create**
> RoleXOResponse Create (RoleXORequest body)

Create role

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRolesApi();
            var body = new RoleXORequest(); // RoleXORequest | A role configuration

            try
            {
                // Create role
                RoleXOResponse result = apiInstance.Create(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRolesApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RoleXORequest**](RoleXORequest.md)| A role configuration | 

### Return type

[**RoleXOResponse**](RoleXOResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string id)

Delete role

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRolesApi();
            var id = id_example;  // string | The id of the role to delete

            try
            {
                // Delete role
                apiInstance.Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRolesApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the role to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrole"></a>
# **GetRole**
> RoleXOResponse GetRole (string id, string source = null)

Get role

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRoleExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRolesApi();
            var id = id_example;  // string | The id of the role to get
            var source = source_example;  // string | The id of the user source to filter the roles by. Available sources can be fetched using the 'User Sources' endpoint. (optional)  (default to default)

            try
            {
                // Get role
                RoleXOResponse result = apiInstance.GetRole(id, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRolesApi.GetRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the role to get | 
 **source** | **string**| The id of the user source to filter the roles by. Available sources can be fetched using the &#39;User Sources&#39; endpoint. | [optional] [default to default]

### Return type

[**RoleXOResponse**](RoleXOResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> List<RoleXOResponse> GetRoles (string source = null)

List roles

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRolesApi();
            var source = source_example;  // string | The id of the user source to filter the roles by, if supplied. Otherwise roles from all user sources will be returned. (optional) 

            try
            {
                // List roles
                List&lt;RoleXOResponse&gt; result = apiInstance.GetRoles(source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRolesApi.GetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| The id of the user source to filter the roles by, if supplied. Otherwise roles from all user sources will be returned. | [optional] 

### Return type

[**List<RoleXOResponse>**](RoleXOResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update1"></a>
# **Update1**
> void Update1 (string id, RoleXORequest body)

Update role

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class Update1Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRolesApi();
            var id = id_example;  // string | The id of the role to update
            var body = new RoleXORequest(); // RoleXORequest | A role configuration

            try
            {
                // Update role
                apiInstance.Update1(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRolesApi.Update1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the role to update | 
 **body** | [**RoleXORequest**](RoleXORequest.md)| A role configuration | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

