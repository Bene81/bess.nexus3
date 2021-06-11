# Bess.IO.Rest.Nexus3.Api.SecurityManagementAnonymousAccessApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Read**](SecurityManagementAnonymousAccessApi.md#read) | **GET** /v1/security/anonymous | Get Anonymous Access settings
[**Update**](SecurityManagementAnonymousAccessApi.md#update) | **PUT** /v1/security/anonymous | Update Anonymous Access settings


<a name="read"></a>
# **Read**
> AnonymousAccessSettingsXO Read ()

Get Anonymous Access settings

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class ReadExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementAnonymousAccessApi();

            try
            {
                // Get Anonymous Access settings
                AnonymousAccessSettingsXO result = apiInstance.Read();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementAnonymousAccessApi.Read: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AnonymousAccessSettingsXO**](AnonymousAccessSettingsXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> AnonymousAccessSettingsXO Update (AnonymousAccessSettingsXO body = null)

Update Anonymous Access settings

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementAnonymousAccessApi();
            var body = new AnonymousAccessSettingsXO(); // AnonymousAccessSettingsXO |  (optional) 

            try
            {
                // Update Anonymous Access settings
                AnonymousAccessSettingsXO result = apiInstance.Update(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementAnonymousAccessApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AnonymousAccessSettingsXO**](AnonymousAccessSettingsXO.md)|  | [optional] 

### Return type

[**AnonymousAccessSettingsXO**](AnonymousAccessSettingsXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

