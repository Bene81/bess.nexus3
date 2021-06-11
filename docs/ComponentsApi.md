# Bess.IO.Rest.Nexus3.Api.ComponentsApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteComponent**](ComponentsApi.md#deletecomponent) | **DELETE** /v1/components/{id} | Delete a single component
[**GetComponentById**](ComponentsApi.md#getcomponentbyid) | **GET** /v1/components/{id} | Get a single component
[**GetComponents**](ComponentsApi.md#getcomponents) | **GET** /v1/components | List components
[**UploadComponent**](ComponentsApi.md#uploadcomponent) | **POST** /v1/components | Upload a single component


<a name="deletecomponent"></a>
# **DeleteComponent**
> void DeleteComponent (string id)

Delete a single component

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteComponentExample
    {
        public void main()
        {
            var apiInstance = new ComponentsApi();
            var id = id_example;  // string | ID of the component to delete

            try
            {
                // Delete a single component
                apiInstance.DeleteComponent(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentsApi.DeleteComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the component to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomponentbyid"></a>
# **GetComponentById**
> ComponentXO GetComponentById (string id)

Get a single component

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetComponentByIdExample
    {
        public void main()
        {
            var apiInstance = new ComponentsApi();
            var id = id_example;  // string | ID of the component to retrieve

            try
            {
                // Get a single component
                ComponentXO result = apiInstance.GetComponentById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentsApi.GetComponentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the component to retrieve | 

### Return type

[**ComponentXO**](ComponentXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomponents"></a>
# **GetComponents**
> PageComponentXO GetComponents (string repository, string continuationToken = null)

List components

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetComponentsExample
    {
        public void main()
        {
            var apiInstance = new ComponentsApi();
            var repository = repository_example;  // string | Repository from which you would like to retrieve components
            var continuationToken = continuationToken_example;  // string | A token returned by a prior request. If present, the next page of results are returned (optional) 

            try
            {
                // List components
                PageComponentXO result = apiInstance.GetComponents(repository, continuationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentsApi.GetComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repository** | **string**| Repository from which you would like to retrieve components | 
 **continuationToken** | **string**| A token returned by a prior request. If present, the next page of results are returned | [optional] 

### Return type

[**PageComponentXO**](PageComponentXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadcomponent"></a>
# **UploadComponent**
> void UploadComponent (string repository, System.IO.Stream rAsset = null, string rAssetPathId = null, System.IO.Stream aptAsset = null, string yumDirectory = null, System.IO.Stream yumAsset = null, string yumAssetFilename = null, System.IO.Stream dockerAsset = null, System.IO.Stream rubygemsAsset = null, System.IO.Stream nugetAsset = null, System.IO.Stream pypiAsset = null, System.IO.Stream helmAsset = null, System.IO.Stream npmAsset = null, string rawDirectory = null, System.IO.Stream rawAsset1 = null, string rawAsset1Filename = null, System.IO.Stream rawAsset2 = null, string rawAsset2Filename = null, System.IO.Stream rawAsset3 = null, string rawAsset3Filename = null, string maven2GroupId = null, string maven2ArtifactId = null, string maven2Version = null, bool? maven2GeneratePom = null, string maven2Packaging = null, System.IO.Stream maven2Asset1 = null, string maven2Asset1Classifier = null, string maven2Asset1Extension = null, System.IO.Stream maven2Asset2 = null, string maven2Asset2Classifier = null, string maven2Asset2Extension = null, System.IO.Stream maven2Asset3 = null, string maven2Asset3Classifier = null, string maven2Asset3Extension = null)

Upload a single component

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UploadComponentExample
    {
        public void main()
        {
            var apiInstance = new ComponentsApi();
            var repository = repository_example;  // string | Name of the repository to which you would like to upload the component
            var rAsset = new System.IO.Stream(); // System.IO.Stream | r Asset  (optional) 
            var rAssetPathId = rAssetPathId_example;  // string | r Asset  Package Path (optional) 
            var aptAsset = new System.IO.Stream(); // System.IO.Stream | apt Asset  (optional) 
            var yumDirectory = yumDirectory_example;  // string | yum Directory (optional) 
            var yumAsset = new System.IO.Stream(); // System.IO.Stream | yum Asset  (optional) 
            var yumAssetFilename = yumAssetFilename_example;  // string | yum Asset  Filename (optional) 
            var dockerAsset = new System.IO.Stream(); // System.IO.Stream | docker Asset  (optional) 
            var rubygemsAsset = new System.IO.Stream(); // System.IO.Stream | rubygems Asset  (optional) 
            var nugetAsset = new System.IO.Stream(); // System.IO.Stream | nuget Asset  (optional) 
            var pypiAsset = new System.IO.Stream(); // System.IO.Stream | pypi Asset  (optional) 
            var helmAsset = new System.IO.Stream(); // System.IO.Stream | helm Asset  (optional) 
            var npmAsset = new System.IO.Stream(); // System.IO.Stream | npm Asset  (optional) 
            var rawDirectory = rawDirectory_example;  // string | raw Directory (optional) 
            var rawAsset1 = new System.IO.Stream(); // System.IO.Stream | raw Asset 1 (optional) 
            var rawAsset1Filename = rawAsset1Filename_example;  // string | raw Asset 1 Filename (optional) 
            var rawAsset2 = new System.IO.Stream(); // System.IO.Stream | raw Asset 2 (optional) 
            var rawAsset2Filename = rawAsset2Filename_example;  // string | raw Asset 2 Filename (optional) 
            var rawAsset3 = new System.IO.Stream(); // System.IO.Stream | raw Asset 3 (optional) 
            var rawAsset3Filename = rawAsset3Filename_example;  // string | raw Asset 3 Filename (optional) 
            var maven2GroupId = maven2GroupId_example;  // string | maven2 Group ID (optional) 
            var maven2ArtifactId = maven2ArtifactId_example;  // string | maven2 Artifact ID (optional) 
            var maven2Version = maven2Version_example;  // string | maven2 Version (optional) 
            var maven2GeneratePom = true;  // bool? | maven2 Generate a POM file with these coordinates (optional) 
            var maven2Packaging = maven2Packaging_example;  // string | maven2 Packaging (optional) 
            var maven2Asset1 = new System.IO.Stream(); // System.IO.Stream | maven2 Asset 1 (optional) 
            var maven2Asset1Classifier = maven2Asset1Classifier_example;  // string | maven2 Asset 1 Classifier (optional) 
            var maven2Asset1Extension = maven2Asset1Extension_example;  // string | maven2 Asset 1 Extension (optional) 
            var maven2Asset2 = new System.IO.Stream(); // System.IO.Stream | maven2 Asset 2 (optional) 
            var maven2Asset2Classifier = maven2Asset2Classifier_example;  // string | maven2 Asset 2 Classifier (optional) 
            var maven2Asset2Extension = maven2Asset2Extension_example;  // string | maven2 Asset 2 Extension (optional) 
            var maven2Asset3 = new System.IO.Stream(); // System.IO.Stream | maven2 Asset 3 (optional) 
            var maven2Asset3Classifier = maven2Asset3Classifier_example;  // string | maven2 Asset 3 Classifier (optional) 
            var maven2Asset3Extension = maven2Asset3Extension_example;  // string | maven2 Asset 3 Extension (optional) 

            try
            {
                // Upload a single component
                apiInstance.UploadComponent(repository, rAsset, rAssetPathId, aptAsset, yumDirectory, yumAsset, yumAssetFilename, dockerAsset, rubygemsAsset, nugetAsset, pypiAsset, helmAsset, npmAsset, rawDirectory, rawAsset1, rawAsset1Filename, rawAsset2, rawAsset2Filename, rawAsset3, rawAsset3Filename, maven2GroupId, maven2ArtifactId, maven2Version, maven2GeneratePom, maven2Packaging, maven2Asset1, maven2Asset1Classifier, maven2Asset1Extension, maven2Asset2, maven2Asset2Classifier, maven2Asset2Extension, maven2Asset3, maven2Asset3Classifier, maven2Asset3Extension);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentsApi.UploadComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repository** | **string**| Name of the repository to which you would like to upload the component | 
 **rAsset** | **System.IO.Stream**| r Asset  | [optional] 
 **rAssetPathId** | **string**| r Asset  Package Path | [optional] 
 **aptAsset** | **System.IO.Stream**| apt Asset  | [optional] 
 **yumDirectory** | **string**| yum Directory | [optional] 
 **yumAsset** | **System.IO.Stream**| yum Asset  | [optional] 
 **yumAssetFilename** | **string**| yum Asset  Filename | [optional] 
 **dockerAsset** | **System.IO.Stream**| docker Asset  | [optional] 
 **rubygemsAsset** | **System.IO.Stream**| rubygems Asset  | [optional] 
 **nugetAsset** | **System.IO.Stream**| nuget Asset  | [optional] 
 **pypiAsset** | **System.IO.Stream**| pypi Asset  | [optional] 
 **helmAsset** | **System.IO.Stream**| helm Asset  | [optional] 
 **npmAsset** | **System.IO.Stream**| npm Asset  | [optional] 
 **rawDirectory** | **string**| raw Directory | [optional] 
 **rawAsset1** | **System.IO.Stream**| raw Asset 1 | [optional] 
 **rawAsset1Filename** | **string**| raw Asset 1 Filename | [optional] 
 **rawAsset2** | **System.IO.Stream**| raw Asset 2 | [optional] 
 **rawAsset2Filename** | **string**| raw Asset 2 Filename | [optional] 
 **rawAsset3** | **System.IO.Stream**| raw Asset 3 | [optional] 
 **rawAsset3Filename** | **string**| raw Asset 3 Filename | [optional] 
 **maven2GroupId** | **string**| maven2 Group ID | [optional] 
 **maven2ArtifactId** | **string**| maven2 Artifact ID | [optional] 
 **maven2Version** | **string**| maven2 Version | [optional] 
 **maven2GeneratePom** | **bool?**| maven2 Generate a POM file with these coordinates | [optional] 
 **maven2Packaging** | **string**| maven2 Packaging | [optional] 
 **maven2Asset1** | **System.IO.Stream**| maven2 Asset 1 | [optional] 
 **maven2Asset1Classifier** | **string**| maven2 Asset 1 Classifier | [optional] 
 **maven2Asset1Extension** | **string**| maven2 Asset 1 Extension | [optional] 
 **maven2Asset2** | **System.IO.Stream**| maven2 Asset 2 | [optional] 
 **maven2Asset2Classifier** | **string**| maven2 Asset 2 Classifier | [optional] 
 **maven2Asset2Extension** | **string**| maven2 Asset 2 Extension | [optional] 
 **maven2Asset3** | **System.IO.Stream**| maven2 Asset 3 | [optional] 
 **maven2Asset3Classifier** | **string**| maven2 Asset 3 Classifier | [optional] 
 **maven2Asset3Extension** | **string**| maven2 Asset 3 Extension | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

