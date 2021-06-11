# Bess.IO.Rest.Nexus3.Api.SecurityCertificatesApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCertificate**](SecurityCertificatesApi.md#addcertificate) | **POST** /v1/security/ssl/truststore | Add a certificate to the trust store.
[**GetTrustStoreCertificates**](SecurityCertificatesApi.md#gettruststorecertificates) | **GET** /v1/security/ssl/truststore | Retrieve a list of certificates added to the trust store.
[**RemoveCertificate**](SecurityCertificatesApi.md#removecertificate) | **DELETE** /v1/security/ssl/truststore/{id} | Remove a certificate in the trust store.
[**RetrieveCertificate**](SecurityCertificatesApi.md#retrievecertificate) | **GET** /v1/security/ssl | Helper method to retrieve certificate details from a remote system.


<a name="addcertificate"></a>
# **AddCertificate**
> ApiCertificate AddCertificate (string body = null)

Add a certificate to the trust store.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class AddCertificateExample
    {
        public void main()
        {
            var apiInstance = new SecurityCertificatesApi();
            var body = body_example;  // string | The certificate to add encoded in PEM format (optional) 

            try
            {
                // Add a certificate to the trust store.
                ApiCertificate result = apiInstance.AddCertificate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityCertificatesApi.AddCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| The certificate to add encoded in PEM format | [optional] 

### Return type

[**ApiCertificate**](ApiCertificate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettruststorecertificates"></a>
# **GetTrustStoreCertificates**
> List<ApiCertificate> GetTrustStoreCertificates ()

Retrieve a list of certificates added to the trust store.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetTrustStoreCertificatesExample
    {
        public void main()
        {
            var apiInstance = new SecurityCertificatesApi();

            try
            {
                // Retrieve a list of certificates added to the trust store.
                List&lt;ApiCertificate&gt; result = apiInstance.GetTrustStoreCertificates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityCertificatesApi.GetTrustStoreCertificates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ApiCertificate>**](ApiCertificate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecertificate"></a>
# **RemoveCertificate**
> void RemoveCertificate (string id)

Remove a certificate in the trust store.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class RemoveCertificateExample
    {
        public void main()
        {
            var apiInstance = new SecurityCertificatesApi();
            var id = id_example;  // string | The id of the certificate that should be removed.

            try
            {
                // Remove a certificate in the trust store.
                apiInstance.RemoveCertificate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityCertificatesApi.RemoveCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the certificate that should be removed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievecertificate"></a>
# **RetrieveCertificate**
> ApiCertificate RetrieveCertificate (string host, int? port = null, string protocolHint = null)

Helper method to retrieve certificate details from a remote system.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class RetrieveCertificateExample
    {
        public void main()
        {
            var apiInstance = new SecurityCertificatesApi();
            var host = host_example;  // string | The remote system's host name
            var port = 56;  // int? | The port on the remote system to connect to (optional)  (default to 443)
            var protocolHint = protocolHint_example;  // string | An optional hint of the protocol to try for the connection (optional) 

            try
            {
                // Helper method to retrieve certificate details from a remote system.
                ApiCertificate result = apiInstance.RetrieveCertificate(host, port, protocolHint);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityCertificatesApi.RetrieveCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **host** | **string**| The remote system&#39;s host name | 
 **port** | **int?**| The port on the remote system to connect to | [optional] [default to 443]
 **protocolHint** | **string**| An optional hint of the protocol to try for the connection | [optional] 

### Return type

[**ApiCertificate**](ApiCertificate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

