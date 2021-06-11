# Bess.IO.Rest.Nexus3.Api.ProductLicensingApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLicenseStatus**](ProductLicensingApi.md#getlicensestatus) | **GET** /v1/system/license | Get the current license status.
[**RemoveLicense**](ProductLicensingApi.md#removelicense) | **DELETE** /v1/system/license | Uninstall license if present.
[**SetLicense**](ProductLicensingApi.md#setlicense) | **POST** /v1/system/license | Upload a new license file.


<a name="getlicensestatus"></a>
# **GetLicenseStatus**
> ApiLicenseDetailsXO GetLicenseStatus ()

Get the current license status.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetLicenseStatusExample
    {
        public void main()
        {
            var apiInstance = new ProductLicensingApi();

            try
            {
                // Get the current license status.
                ApiLicenseDetailsXO result = apiInstance.GetLicenseStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductLicensingApi.GetLicenseStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiLicenseDetailsXO**](ApiLicenseDetailsXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removelicense"></a>
# **RemoveLicense**
> void RemoveLicense ()

Uninstall license if present.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class RemoveLicenseExample
    {
        public void main()
        {
            var apiInstance = new ProductLicensingApi();

            try
            {
                // Uninstall license if present.
                apiInstance.RemoveLicense();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductLicensingApi.RemoveLicense: " + e.Message );
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

<a name="setlicense"></a>
# **SetLicense**
> ApiLicenseDetailsXO SetLicense (InputStream body = null)

Upload a new license file.

Server must be restarted to take effect

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SetLicenseExample
    {
        public void main()
        {
            var apiInstance = new ProductLicensingApi();
            var body = new InputStream(); // InputStream |  (optional) 

            try
            {
                // Upload a new license file.
                ApiLicenseDetailsXO result = apiInstance.SetLicense(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductLicensingApi.SetLicense: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InputStream**](InputStream.md)|  | [optional] 

### Return type

[**ApiLicenseDetailsXO**](ApiLicenseDetailsXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

