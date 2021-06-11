# Bess.IO.Rest.Nexus3.Api.SecurityManagementRealmsApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActiveRealms**](SecurityManagementRealmsApi.md#getactiverealms) | **GET** /v1/security/realms/active | List the active realm IDs in order
[**GetRealms**](SecurityManagementRealmsApi.md#getrealms) | **GET** /v1/security/realms/available | List the available realms
[**SetActiveRealms**](SecurityManagementRealmsApi.md#setactiverealms) | **PUT** /v1/security/realms/active | Set the active security realms in the order they should be used


<a name="getactiverealms"></a>
# **GetActiveRealms**
> List<string> GetActiveRealms ()

List the active realm IDs in order

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetActiveRealmsExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRealmsApi();

            try
            {
                // List the active realm IDs in order
                List&lt;string&gt; result = apiInstance.GetActiveRealms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRealmsApi.GetActiveRealms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrealms"></a>
# **GetRealms**
> List<RealmApiXO> GetRealms ()

List the available realms

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRealmsExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRealmsApi();

            try
            {
                // List the available realms
                List&lt;RealmApiXO&gt; result = apiInstance.GetRealms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRealmsApi.GetRealms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RealmApiXO>**](RealmApiXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setactiverealms"></a>
# **SetActiveRealms**
> void SetActiveRealms (List<string> body = null)

Set the active security realms in the order they should be used

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SetActiveRealmsExample
    {
        public void main()
        {
            var apiInstance = new SecurityManagementRealmsApi();
            var body = ;  // List<string> | The realm IDs (optional) 

            try
            {
                // Set the active security realms in the order they should be used
                apiInstance.SetActiveRealms(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityManagementRealmsApi.SetActiveRealms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| The realm IDs | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

