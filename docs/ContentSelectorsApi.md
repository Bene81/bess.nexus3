# Bess.IO.Rest.Nexus3.Api.ContentSelectorsApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateContentSelector**](ContentSelectorsApi.md#createcontentselector) | **POST** /v1/security/content-selectors | Create a new content selector
[**DeleteContentSelector**](ContentSelectorsApi.md#deletecontentselector) | **DELETE** /v1/security/content-selectors/{name} | Delete a content selector
[**GetContentSelector**](ContentSelectorsApi.md#getcontentselector) | **GET** /v1/security/content-selectors/{name} | Get a content selector by name
[**GetContentSelectors**](ContentSelectorsApi.md#getcontentselectors) | **GET** /v1/security/content-selectors | List content selectors
[**UpdateContentSelector**](ContentSelectorsApi.md#updatecontentselector) | **PUT** /v1/security/content-selectors/{name} | Update a content selector


<a name="createcontentselector"></a>
# **CreateContentSelector**
> void CreateContentSelector (ContentSelectorApiCreateRequest body = null)

Create a new content selector

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateContentSelectorExample
    {
        public void main()
        {
            var apiInstance = new ContentSelectorsApi();
            var body = new ContentSelectorApiCreateRequest(); // ContentSelectorApiCreateRequest |  (optional) 

            try
            {
                // Create a new content selector
                apiInstance.CreateContentSelector(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentSelectorsApi.CreateContentSelector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContentSelectorApiCreateRequest**](ContentSelectorApiCreateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontentselector"></a>
# **DeleteContentSelector**
> void DeleteContentSelector (string name)

Delete a content selector

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteContentSelectorExample
    {
        public void main()
        {
            var apiInstance = new ContentSelectorsApi();
            var name = name_example;  // string | 

            try
            {
                // Delete a content selector
                apiInstance.DeleteContentSelector(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentSelectorsApi.DeleteContentSelector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentselector"></a>
# **GetContentSelector**
> ContentSelectorApiResponse GetContentSelector (string name)

Get a content selector by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetContentSelectorExample
    {
        public void main()
        {
            var apiInstance = new ContentSelectorsApi();
            var name = name_example;  // string | The content selector name

            try
            {
                // Get a content selector by name
                ContentSelectorApiResponse result = apiInstance.GetContentSelector(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentSelectorsApi.GetContentSelector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The content selector name | 

### Return type

[**ContentSelectorApiResponse**](ContentSelectorApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentselectors"></a>
# **GetContentSelectors**
> List<ContentSelectorApiResponse> GetContentSelectors ()

List content selectors

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetContentSelectorsExample
    {
        public void main()
        {
            var apiInstance = new ContentSelectorsApi();

            try
            {
                // List content selectors
                List&lt;ContentSelectorApiResponse&gt; result = apiInstance.GetContentSelectors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentSelectorsApi.GetContentSelectors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ContentSelectorApiResponse>**](ContentSelectorApiResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontentselector"></a>
# **UpdateContentSelector**
> void UpdateContentSelector (string name, ContentSelectorApiUpdateRequest body = null)

Update a content selector

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateContentSelectorExample
    {
        public void main()
        {
            var apiInstance = new ContentSelectorsApi();
            var name = name_example;  // string | The content selector name
            var body = new ContentSelectorApiUpdateRequest(); // ContentSelectorApiUpdateRequest |  (optional) 

            try
            {
                // Update a content selector
                apiInstance.UpdateContentSelector(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentSelectorsApi.UpdateContentSelector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The content selector name | 
 **body** | [**ContentSelectorApiUpdateRequest**](ContentSelectorApiUpdateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

