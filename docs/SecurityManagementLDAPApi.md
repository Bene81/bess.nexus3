# Bess.IO.Rest.Nexus3.Api.SecurityManagementLDAPApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeOrder**](SecurityManagementLDAPApi.md#changeorder) | **POST** /v1/security/ldap/change-order | Change LDAP server order
[**CreateLdapServer**](SecurityManagementLDAPApi.md#createldapserver) | **POST** /v1/security/ldap | Create LDAP server
[**DeleteLdapServer**](SecurityManagementLDAPApi.md#deleteldapserver) | **DELETE** /v1/security/ldap/{name} | Delete LDAP server
[**GetLdapServer**](SecurityManagementLDAPApi.md#getldapserver) | **GET** /v1/security/ldap/{name} | Get LDAP server
[**GetLdapServers**](SecurityManagementLDAPApi.md#getldapservers) | **GET** /v1/security/ldap | List LDAP servers
[**UpdateLdapServer**](SecurityManagementLDAPApi.md#updateldapserver) | **PUT** /v1/security/ldap/{name} | Update LDAP server


<a name="changeorder"></a>
# **ChangeOrder**
> void ChangeOrder (List<string> body = null)

Change LDAP server order

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class ChangeOrderExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementLDAPApi();
            var body = ;  // List<string> | Ordered list of LDAP server names (optional) 

            try
            {
                // Change LDAP server order
                apiInstance.ChangeOrder(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementLDAPApi.ChangeOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| Ordered list of LDAP server names | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createldapserver"></a>
# **CreateLdapServer**
> void CreateLdapServer (CreateLdapServerXo body = null)

Create LDAP server

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateLdapServerExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementLDAPApi();
            var body = new CreateLdapServerXo(); // CreateLdapServerXo |  (optional) 

            try
            {
                // Create LDAP server
                apiInstance.CreateLdapServer(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementLDAPApi.CreateLdapServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateLdapServerXo**](CreateLdapServerXo.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteldapserver"></a>
# **DeleteLdapServer**
> void DeleteLdapServer (string name)

Delete LDAP server

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteLdapServerExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementLDAPApi();
            var name = name_example;  // string | Name of the LDAP server to delete

            try
            {
                // Delete LDAP server
                apiInstance.DeleteLdapServer(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementLDAPApi.DeleteLdapServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP server to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getldapserver"></a>
# **GetLdapServer**
> void GetLdapServer (string name)

Get LDAP server

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetLdapServerExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementLDAPApi();
            var name = name_example;  // string | Name of the LDAP server to retrieve

            try
            {
                // Get LDAP server
                apiInstance.GetLdapServer(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementLDAPApi.GetLdapServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP server to retrieve | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getldapservers"></a>
# **GetLdapServers**
> void GetLdapServers ()

List LDAP servers

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetLdapServersExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementLDAPApi();

            try
            {
                // List LDAP servers
                apiInstance.GetLdapServers();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementLDAPApi.GetLdapServers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateldapserver"></a>
# **UpdateLdapServer**
> void UpdateLdapServer (string name, UpdateLdapServerXo body = null)

Update LDAP server

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateLdapServerExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementLDAPApi();
            var name = name_example;  // string | Name of the LDAP server to update
            var body = new UpdateLdapServerXo(); // UpdateLdapServerXo | Updated values of LDAP server (optional) 

            try
            {
                // Update LDAP server
                apiInstance.UpdateLdapServer(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementLDAPApi.UpdateLdapServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the LDAP server to update | 
 **body** | [**UpdateLdapServerXo**](UpdateLdapServerXo.md)| Updated values of LDAP server | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

