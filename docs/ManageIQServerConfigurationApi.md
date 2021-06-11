# Bess.IO.Rest.Nexus3.Api.ManageIQServerConfigurationApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DisableIq**](ManageIQServerConfigurationApi.md#disableiq) | **POST** /v1/iq/disable | Disable IQ server
[**EnableIq**](ManageIQServerConfigurationApi.md#enableiq) | **POST** /v1/iq/enable | Enable IQ server
[**GetConfiguration**](ManageIQServerConfigurationApi.md#getconfiguration) | **GET** /v1/iq | Get IQ server configuration
[**UpdateConfiguration**](ManageIQServerConfigurationApi.md#updateconfiguration) | **PUT** /v1/iq | Update IQ server configuration
[**VerifyConnection**](ManageIQServerConfigurationApi.md#verifyconnection) | **POST** /v1/iq/verify-connection | Verify IQ server connection


<a name="disableiq"></a>
# **DisableIq**
> void DisableIq ()

Disable IQ server

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DisableIqExample
    {
        public void main()
        {
            var apiInstance = new ManageIQServerConfigurationApi();

            try
            {
                // Disable IQ server
                apiInstance.DisableIq();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageIQServerConfigurationApi.DisableIq: " + e.Message );
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

<a name="enableiq"></a>
# **EnableIq**
> void EnableIq ()

Enable IQ server

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class EnableIqExample
    {
        public void main()
        {
            var apiInstance = new ManageIQServerConfigurationApi();

            try
            {
                // Enable IQ server
                apiInstance.EnableIq();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageIQServerConfigurationApi.EnableIq: " + e.Message );
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

<a name="getconfiguration"></a>
# **GetConfiguration**
> void GetConfiguration ()

Get IQ server configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetConfigurationExample
    {
        public void main()
        {
            var apiInstance = new ManageIQServerConfigurationApi();

            try
            {
                // Get IQ server configuration
                apiInstance.GetConfiguration();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageIQServerConfigurationApi.GetConfiguration: " + e.Message );
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

<a name="updateconfiguration"></a>
# **UpdateConfiguration**
> void UpdateConfiguration (IqConnectionXo body = null)

Update IQ server configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateConfigurationExample
    {
        public void main()
        {
            var apiInstance = new ManageIQServerConfigurationApi();
            var body = new IqConnectionXo(); // IqConnectionXo |  (optional) 

            try
            {
                // Update IQ server configuration
                apiInstance.UpdateConfiguration(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageIQServerConfigurationApi.UpdateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IqConnectionXo**](IqConnectionXo.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyconnection"></a>
# **VerifyConnection**
> void VerifyConnection ()

Verify IQ server connection

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class VerifyConnectionExample
    {
        public void main()
        {
            var apiInstance = new ManageIQServerConfigurationApi();

            try
            {
                // Verify IQ server connection
                apiInstance.VerifyConnection();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageIQServerConfigurationApi.VerifyConnection: " + e.Message );
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

