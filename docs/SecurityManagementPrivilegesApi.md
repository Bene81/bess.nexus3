# Bess.IO.Rest.Nexus3.Api.SecurityManagementPrivilegesApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePrivilege**](SecurityManagementPrivilegesApi.md#createprivilege) | **POST** /v1/security/privileges/wildcard | Create a wildcard type privilege.
[**CreatePrivilege1**](SecurityManagementPrivilegesApi.md#createprivilege1) | **POST** /v1/security/privileges/application | Create an application type privilege.
[**CreatePrivilege2**](SecurityManagementPrivilegesApi.md#createprivilege2) | **POST** /v1/security/privileges/repository-content-selector | Create a repository content selector type privilege.
[**CreatePrivilege3**](SecurityManagementPrivilegesApi.md#createprivilege3) | **POST** /v1/security/privileges/repository-admin | Create a repository admin type privilege.
[**CreatePrivilege4**](SecurityManagementPrivilegesApi.md#createprivilege4) | **POST** /v1/security/privileges/repository-view | Create a repository view type privilege.
[**CreatePrivilege5**](SecurityManagementPrivilegesApi.md#createprivilege5) | **POST** /v1/security/privileges/script | Create a script type privilege.
[**DeletePrivilege**](SecurityManagementPrivilegesApi.md#deleteprivilege) | **DELETE** /v1/security/privileges/{privilegeId} | Delete a privilege by id.
[**GetPrivilege**](SecurityManagementPrivilegesApi.md#getprivilege) | **GET** /v1/security/privileges/{privilegeId} | Retrieve a privilege by id.
[**GetPrivileges**](SecurityManagementPrivilegesApi.md#getprivileges) | **GET** /v1/security/privileges | Retrieve a list of privileges.
[**UpdatePrivilege**](SecurityManagementPrivilegesApi.md#updateprivilege) | **PUT** /v1/security/privileges/wildcard/{privilegeId} | Update a wildcard type privilege.
[**UpdatePrivilege1**](SecurityManagementPrivilegesApi.md#updateprivilege1) | **PUT** /v1/security/privileges/application/{privilegeId} | Update an application type privilege.
[**UpdatePrivilege2**](SecurityManagementPrivilegesApi.md#updateprivilege2) | **PUT** /v1/security/privileges/repository-view/{privilegeId} | Update a repository view type privilege.
[**UpdatePrivilege3**](SecurityManagementPrivilegesApi.md#updateprivilege3) | **PUT** /v1/security/privileges/repository-content-selector/{privilegeId} | Update a repository content selector type privilege.
[**UpdatePrivilege4**](SecurityManagementPrivilegesApi.md#updateprivilege4) | **PUT** /v1/security/privileges/repository-admin/{privilegeId} | Update a repository admin type privilege.
[**UpdatePrivilege5**](SecurityManagementPrivilegesApi.md#updateprivilege5) | **PUT** /v1/security/privileges/script/{privilegeId} | Update a script type privilege.


<a name="createprivilege"></a>
# **CreatePrivilege**
> void CreatePrivilege (ApiPrivilegeWildcardRequest body = null)

Create a wildcard type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreatePrivilegeExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var body = new ApiPrivilegeWildcardRequest(); // ApiPrivilegeWildcardRequest | The privilege to create. (optional) 

            try
            {
                // Create a wildcard type privilege.
                apiInstance.CreatePrivilege(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.CreatePrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiPrivilegeWildcardRequest**](ApiPrivilegeWildcardRequest.md)| The privilege to create. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprivilege1"></a>
# **CreatePrivilege1**
> void CreatePrivilege1 (ApiPrivilegeApplicationRequest body = null)

Create an application type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreatePrivilege1Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var body = new ApiPrivilegeApplicationRequest(); // ApiPrivilegeApplicationRequest | The privilege to create. (optional) 

            try
            {
                // Create an application type privilege.
                apiInstance.CreatePrivilege1(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.CreatePrivilege1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiPrivilegeApplicationRequest**](ApiPrivilegeApplicationRequest.md)| The privilege to create. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprivilege2"></a>
# **CreatePrivilege2**
> void CreatePrivilege2 (ApiPrivilegeRepositoryContentSelectorRequest body = null)

Create a repository content selector type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreatePrivilege2Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var body = new ApiPrivilegeRepositoryContentSelectorRequest(); // ApiPrivilegeRepositoryContentSelectorRequest | The privilege to create. (optional) 

            try
            {
                // Create a repository content selector type privilege.
                apiInstance.CreatePrivilege2(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.CreatePrivilege2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiPrivilegeRepositoryContentSelectorRequest**](ApiPrivilegeRepositoryContentSelectorRequest.md)| The privilege to create. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprivilege3"></a>
# **CreatePrivilege3**
> void CreatePrivilege3 (ApiPrivilegeRepositoryAdminRequest body = null)

Create a repository admin type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreatePrivilege3Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var body = new ApiPrivilegeRepositoryAdminRequest(); // ApiPrivilegeRepositoryAdminRequest | The privilege to create. (optional) 

            try
            {
                // Create a repository admin type privilege.
                apiInstance.CreatePrivilege3(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.CreatePrivilege3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiPrivilegeRepositoryAdminRequest**](ApiPrivilegeRepositoryAdminRequest.md)| The privilege to create. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprivilege4"></a>
# **CreatePrivilege4**
> void CreatePrivilege4 (ApiPrivilegeRepositoryViewRequest body = null)

Create a repository view type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreatePrivilege4Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var body = new ApiPrivilegeRepositoryViewRequest(); // ApiPrivilegeRepositoryViewRequest | The privilege to create. (optional) 

            try
            {
                // Create a repository view type privilege.
                apiInstance.CreatePrivilege4(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.CreatePrivilege4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiPrivilegeRepositoryViewRequest**](ApiPrivilegeRepositoryViewRequest.md)| The privilege to create. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprivilege5"></a>
# **CreatePrivilege5**
> void CreatePrivilege5 (ApiPrivilegeScriptRequest body = null)

Create a script type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreatePrivilege5Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var body = new ApiPrivilegeScriptRequest(); // ApiPrivilegeScriptRequest | The privilege to create. (optional) 

            try
            {
                // Create a script type privilege.
                apiInstance.CreatePrivilege5(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.CreatePrivilege5: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiPrivilegeScriptRequest**](ApiPrivilegeScriptRequest.md)| The privilege to create. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprivilege"></a>
# **DeletePrivilege**
> void DeletePrivilege (string privilegeId)

Delete a privilege by id.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeletePrivilegeExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to delete.

            try
            {
                // Delete a privilege by id.
                apiInstance.DeletePrivilege(privilegeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.DeletePrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprivilege"></a>
# **GetPrivilege**
> ApiPrivilege GetPrivilege (string privilegeId)

Retrieve a privilege by id.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetPrivilegeExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to retrieve.

            try
            {
                // Retrieve a privilege by id.
                ApiPrivilege result = apiInstance.GetPrivilege(privilegeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.GetPrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to retrieve. | 

### Return type

[**ApiPrivilege**](ApiPrivilege.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprivileges"></a>
# **GetPrivileges**
> List<ApiPrivilege> GetPrivileges ()

Retrieve a list of privileges.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetPrivilegesExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();

            try
            {
                // Retrieve a list of privileges.
                List&lt;ApiPrivilege&gt; result = apiInstance.GetPrivileges();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.GetPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ApiPrivilege>**](ApiPrivilege.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprivilege"></a>
# **UpdatePrivilege**
> void UpdatePrivilege (string privilegeId, ApiPrivilegeWildcardRequest body = null)

Update a wildcard type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdatePrivilegeExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to update.
            var body = new ApiPrivilegeWildcardRequest(); // ApiPrivilegeWildcardRequest | The privilege to update. (optional) 

            try
            {
                // Update a wildcard type privilege.
                apiInstance.UpdatePrivilege(privilegeId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.UpdatePrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to update. | 
 **body** | [**ApiPrivilegeWildcardRequest**](ApiPrivilegeWildcardRequest.md)| The privilege to update. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprivilege1"></a>
# **UpdatePrivilege1**
> void UpdatePrivilege1 (string privilegeId, ApiPrivilegeApplicationRequest body = null)

Update an application type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdatePrivilege1Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to update.
            var body = new ApiPrivilegeApplicationRequest(); // ApiPrivilegeApplicationRequest | The privilege to update. (optional) 

            try
            {
                // Update an application type privilege.
                apiInstance.UpdatePrivilege1(privilegeId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.UpdatePrivilege1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to update. | 
 **body** | [**ApiPrivilegeApplicationRequest**](ApiPrivilegeApplicationRequest.md)| The privilege to update. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprivilege2"></a>
# **UpdatePrivilege2**
> void UpdatePrivilege2 (string privilegeId, ApiPrivilegeRepositoryViewRequest body = null)

Update a repository view type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdatePrivilege2Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to update.
            var body = new ApiPrivilegeRepositoryViewRequest(); // ApiPrivilegeRepositoryViewRequest | The privilege to update. (optional) 

            try
            {
                // Update a repository view type privilege.
                apiInstance.UpdatePrivilege2(privilegeId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.UpdatePrivilege2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to update. | 
 **body** | [**ApiPrivilegeRepositoryViewRequest**](ApiPrivilegeRepositoryViewRequest.md)| The privilege to update. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprivilege3"></a>
# **UpdatePrivilege3**
> void UpdatePrivilege3 (string privilegeId, ApiPrivilegeRepositoryContentSelectorRequest body = null)

Update a repository content selector type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdatePrivilege3Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to update.
            var body = new ApiPrivilegeRepositoryContentSelectorRequest(); // ApiPrivilegeRepositoryContentSelectorRequest | The privilege to update. (optional) 

            try
            {
                // Update a repository content selector type privilege.
                apiInstance.UpdatePrivilege3(privilegeId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.UpdatePrivilege3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to update. | 
 **body** | [**ApiPrivilegeRepositoryContentSelectorRequest**](ApiPrivilegeRepositoryContentSelectorRequest.md)| The privilege to update. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprivilege4"></a>
# **UpdatePrivilege4**
> void UpdatePrivilege4 (string privilegeId, ApiPrivilegeRepositoryAdminRequest body = null)

Update a repository admin type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdatePrivilege4Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to update.
            var body = new ApiPrivilegeRepositoryAdminRequest(); // ApiPrivilegeRepositoryAdminRequest | The privilege to update. (optional) 

            try
            {
                // Update a repository admin type privilege.
                apiInstance.UpdatePrivilege4(privilegeId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.UpdatePrivilege4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to update. | 
 **body** | [**ApiPrivilegeRepositoryAdminRequest**](ApiPrivilegeRepositoryAdminRequest.md)| The privilege to update. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprivilege5"></a>
# **UpdatePrivilege5**
> void UpdatePrivilege5 (string privilegeId, ApiPrivilegeScriptRequest body = null)

Update a script type privilege.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdatePrivilege5Example
    {
        public void main()
        {
            var apiInstance = new SecurityManagementPrivilegesApi();
            var privilegeId = privilegeId_example;  // string | The id of the privilege to update.
            var body = new ApiPrivilegeScriptRequest(); // ApiPrivilegeScriptRequest | The privilege to update. (optional) 

            try
            {
                // Update a script type privilege.
                apiInstance.UpdatePrivilege5(privilegeId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementPrivilegesApi.UpdatePrivilege5: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privilegeId** | **string**| The id of the privilege to update. | 
 **body** | [**ApiPrivilegeScriptRequest**](ApiPrivilegeScriptRequest.md)| The privilege to update. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

