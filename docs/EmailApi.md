# Bess.IO.Rest.Nexus3.Api.EmailApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEmailConfiguration**](EmailApi.md#deleteemailconfiguration) | **DELETE** /v1/email | Disable and clear the email configuration
[**GetEmailConfiguration**](EmailApi.md#getemailconfiguration) | **GET** /v1/email | Retrieve the current email configuration
[**SetEmailConfiguration**](EmailApi.md#setemailconfiguration) | **PUT** /v1/email | Set the current email configuration
[**TestEmailConfiguration**](EmailApi.md#testemailconfiguration) | **POST** /v1/email/verify | Send a test email to the email address provided in the request body


<a name="deleteemailconfiguration"></a>
# **DeleteEmailConfiguration**
> void DeleteEmailConfiguration ()

Disable and clear the email configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteEmailConfigurationExample
    {
        public void main()
        {
            var apiInstance = new EmailApi();

            try
            {
                // Disable and clear the email configuration
                apiInstance.DeleteEmailConfiguration();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.DeleteEmailConfiguration: " + e.Message );
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

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailconfiguration"></a>
# **GetEmailConfiguration**
> ApiEmailConfiguration GetEmailConfiguration ()

Retrieve the current email configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetEmailConfigurationExample
    {
        public void main()
        {
            var apiInstance = new EmailApi();

            try
            {
                // Retrieve the current email configuration
                ApiEmailConfiguration result = apiInstance.GetEmailConfiguration();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.GetEmailConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiEmailConfiguration**](ApiEmailConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setemailconfiguration"></a>
# **SetEmailConfiguration**
> void SetEmailConfiguration (ApiEmailConfiguration body)

Set the current email configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SetEmailConfigurationExample
    {
        public void main()
        {
            var apiInstance = new EmailApi();
            var body = new ApiEmailConfiguration(); // ApiEmailConfiguration | 

            try
            {
                // Set the current email configuration
                apiInstance.SetEmailConfiguration(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.SetEmailConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiEmailConfiguration**](ApiEmailConfiguration.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testemailconfiguration"></a>
# **TestEmailConfiguration**
> ApiEmailValidation TestEmailConfiguration (string body)

Send a test email to the email address provided in the request body

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class TestEmailConfigurationExample
    {
        public void main()
        {
            var apiInstance = new EmailApi();
            var body = body_example;  // string | An email address to send a test email to

            try
            {
                // Send a test email to the email address provided in the request body
                ApiEmailValidation result = apiInstance.TestEmailConfiguration(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.TestEmailConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| An email address to send a test email to | 

### Return type

[**ApiEmailValidation**](ApiEmailValidation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

