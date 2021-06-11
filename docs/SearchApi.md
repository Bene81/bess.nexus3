# Bess.IO.Rest.Nexus3.Api.SearchApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Search**](SearchApi.md#search) | **GET** /v1/search | Search components
[**SearchAndDownloadAssets**](SearchApi.md#searchanddownloadassets) | **GET** /v1/search/assets/download | Search and download asset
[**SearchAssets**](SearchApi.md#searchassets) | **GET** /v1/search/assets | Search assets


<a name="search"></a>
# **Search**
> PageComponentXO Search (string continuationToken = null, string sort = null, string direction = null, int? timeout = null, string q = null, string repository = null, string format = null, string group = null, string name = null, string version = null, string md5 = null, string sha1 = null, string sha256 = null, string sha512 = null, string prerelease = null, string conanBaseVersion = null, string conanChannel = null, string dockerImageName = null, string dockerImageTag = null, string dockerLayerId = null, string dockerContentDigest = null, string mavenGroupId = null, string mavenArtifactId = null, string mavenBaseVersion = null, string mavenExtension = null, string mavenClassifier = null, string npmScope = null, string nugetId = null, string nugetTags = null, string p2PluginName = null, string pypiClassifiers = null, string pypiDescription = null, string pypiKeywords = null, string pypiSummary = null, string rubygemsDescription = null, string rubygemsPlatform = null, string rubygemsSummary = null, string yumArchitecture = null)

Search components

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var continuationToken = continuationToken_example;  // string | A token returned by a prior request. If present, the next page of results are returned (optional) 
            var sort = sort_example;  // string | The field to sort the results against, if left empty, a sort based on match weight will be used. (optional) 
            var direction = direction_example;  // string | The direction to sort records in, defaults to ascending ('asc') for all sort fields, except version, which defaults to descending ('desc') (optional) 
            var timeout = 56;  // int? | How long to wait for search results in seconds. If this value is not provided, the system default timeout will be used. (optional) 
            var q = q_example;  // string | Query by keyword (optional) 
            var repository = repository_example;  // string | Repository name (optional) 
            var format = format_example;  // string | Query by format (optional) 
            var group = group_example;  // string | Component group (optional) 
            var name = name_example;  // string | Component name (optional) 
            var version = version_example;  // string | Component version (optional) 
            var md5 = md5_example;  // string | Specific MD5 hash of component's asset (optional) 
            var sha1 = sha1_example;  // string | Specific SHA-1 hash of component's asset (optional) 
            var sha256 = sha256_example;  // string | Specific SHA-256 hash of component's asset (optional) 
            var sha512 = sha512_example;  // string | Specific SHA-512 hash of component's asset (optional) 
            var prerelease = prerelease_example;  // string | Prerelease version flag (optional) 
            var conanBaseVersion = conanBaseVersion_example;  // string | baseVersion (optional) 
            var conanChannel = conanChannel_example;  // string | channel (optional) 
            var dockerImageName = dockerImageName_example;  // string | Docker image name (optional) 
            var dockerImageTag = dockerImageTag_example;  // string | Docker image tag (optional) 
            var dockerLayerId = dockerLayerId_example;  // string | Docker layer ID (optional) 
            var dockerContentDigest = dockerContentDigest_example;  // string | Docker content digest (optional) 
            var mavenGroupId = mavenGroupId_example;  // string | Maven groupId (optional) 
            var mavenArtifactId = mavenArtifactId_example;  // string | Maven artifactId (optional) 
            var mavenBaseVersion = mavenBaseVersion_example;  // string | Maven base version (optional) 
            var mavenExtension = mavenExtension_example;  // string | Maven extension of component's asset (optional) 
            var mavenClassifier = mavenClassifier_example;  // string | Maven classifier of component's asset (optional) 
            var npmScope = npmScope_example;  // string | npm scope (optional) 
            var nugetId = nugetId_example;  // string | NuGet id (optional) 
            var nugetTags = nugetTags_example;  // string | NuGet tags (optional) 
            var p2PluginName = p2PluginName_example;  // string | p2 plugin name (optional) 
            var pypiClassifiers = pypiClassifiers_example;  // string | PyPI classifiers (optional) 
            var pypiDescription = pypiDescription_example;  // string | PyPI description (optional) 
            var pypiKeywords = pypiKeywords_example;  // string | PyPI keywords (optional) 
            var pypiSummary = pypiSummary_example;  // string | PyPI summary (optional) 
            var rubygemsDescription = rubygemsDescription_example;  // string | RubyGems description (optional) 
            var rubygemsPlatform = rubygemsPlatform_example;  // string | RubyGems platform (optional) 
            var rubygemsSummary = rubygemsSummary_example;  // string | RubyGems summary (optional) 
            var yumArchitecture = yumArchitecture_example;  // string | Yum architecture (optional) 

            try
            {
                // Search components
                PageComponentXO result = apiInstance.Search(continuationToken, sort, direction, timeout, q, repository, format, group, name, version, md5, sha1, sha256, sha512, prerelease, conanBaseVersion, conanChannel, dockerImageName, dockerImageTag, dockerLayerId, dockerContentDigest, mavenGroupId, mavenArtifactId, mavenBaseVersion, mavenExtension, mavenClassifier, npmScope, nugetId, nugetTags, p2PluginName, pypiClassifiers, pypiDescription, pypiKeywords, pypiSummary, rubygemsDescription, rubygemsPlatform, rubygemsSummary, yumArchitecture);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **continuationToken** | **string**| A token returned by a prior request. If present, the next page of results are returned | [optional] 
 **sort** | **string**| The field to sort the results against, if left empty, a sort based on match weight will be used. | [optional] 
 **direction** | **string**| The direction to sort records in, defaults to ascending (&#39;asc&#39;) for all sort fields, except version, which defaults to descending (&#39;desc&#39;) | [optional] 
 **timeout** | **int?**| How long to wait for search results in seconds. If this value is not provided, the system default timeout will be used. | [optional] 
 **q** | **string**| Query by keyword | [optional] 
 **repository** | **string**| Repository name | [optional] 
 **format** | **string**| Query by format | [optional] 
 **group** | **string**| Component group | [optional] 
 **name** | **string**| Component name | [optional] 
 **version** | **string**| Component version | [optional] 
 **md5** | **string**| Specific MD5 hash of component&#39;s asset | [optional] 
 **sha1** | **string**| Specific SHA-1 hash of component&#39;s asset | [optional] 
 **sha256** | **string**| Specific SHA-256 hash of component&#39;s asset | [optional] 
 **sha512** | **string**| Specific SHA-512 hash of component&#39;s asset | [optional] 
 **prerelease** | **string**| Prerelease version flag | [optional] 
 **conanBaseVersion** | **string**| baseVersion | [optional] 
 **conanChannel** | **string**| channel | [optional] 
 **dockerImageName** | **string**| Docker image name | [optional] 
 **dockerImageTag** | **string**| Docker image tag | [optional] 
 **dockerLayerId** | **string**| Docker layer ID | [optional] 
 **dockerContentDigest** | **string**| Docker content digest | [optional] 
 **mavenGroupId** | **string**| Maven groupId | [optional] 
 **mavenArtifactId** | **string**| Maven artifactId | [optional] 
 **mavenBaseVersion** | **string**| Maven base version | [optional] 
 **mavenExtension** | **string**| Maven extension of component&#39;s asset | [optional] 
 **mavenClassifier** | **string**| Maven classifier of component&#39;s asset | [optional] 
 **npmScope** | **string**| npm scope | [optional] 
 **nugetId** | **string**| NuGet id | [optional] 
 **nugetTags** | **string**| NuGet tags | [optional] 
 **p2PluginName** | **string**| p2 plugin name | [optional] 
 **pypiClassifiers** | **string**| PyPI classifiers | [optional] 
 **pypiDescription** | **string**| PyPI description | [optional] 
 **pypiKeywords** | **string**| PyPI keywords | [optional] 
 **pypiSummary** | **string**| PyPI summary | [optional] 
 **rubygemsDescription** | **string**| RubyGems description | [optional] 
 **rubygemsPlatform** | **string**| RubyGems platform | [optional] 
 **rubygemsSummary** | **string**| RubyGems summary | [optional] 
 **yumArchitecture** | **string**| Yum architecture | [optional] 

### Return type

[**PageComponentXO**](PageComponentXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchanddownloadassets"></a>
# **SearchAndDownloadAssets**
> void SearchAndDownloadAssets (string sort = null, string direction = null, int? timeout = null, string q = null, string repository = null, string format = null, string group = null, string name = null, string version = null, string md5 = null, string sha1 = null, string sha256 = null, string sha512 = null, string prerelease = null, string conanBaseVersion = null, string conanChannel = null, string dockerImageName = null, string dockerImageTag = null, string dockerLayerId = null, string dockerContentDigest = null, string mavenGroupId = null, string mavenArtifactId = null, string mavenBaseVersion = null, string mavenExtension = null, string mavenClassifier = null, string npmScope = null, string nugetId = null, string nugetTags = null, string p2PluginName = null, string pypiClassifiers = null, string pypiDescription = null, string pypiKeywords = null, string pypiSummary = null, string rubygemsDescription = null, string rubygemsPlatform = null, string rubygemsSummary = null, string yumArchitecture = null)

Search and download asset

Returns a 302 Found with location header field set to download URL. Unless a sort parameter is supplied, the search must return a single asset to receive download URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SearchAndDownloadAssetsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var sort = sort_example;  // string | The field to sort the results against, if left empty and more than 1 result is returned, the request will fail. (optional) 
            var direction = direction_example;  // string | The direction to sort records in, defaults to ascending ('asc') for all sort fields, except version, which defaults to descending ('desc') (optional) 
            var timeout = 56;  // int? | How long to wait for search results in seconds. If this value is not provided, the system default timeout will be used. (optional) 
            var q = q_example;  // string | Query by keyword (optional) 
            var repository = repository_example;  // string | Repository name (optional) 
            var format = format_example;  // string | Query by format (optional) 
            var group = group_example;  // string | Component group (optional) 
            var name = name_example;  // string | Component name (optional) 
            var version = version_example;  // string | Component version (optional) 
            var md5 = md5_example;  // string | Specific MD5 hash of component's asset (optional) 
            var sha1 = sha1_example;  // string | Specific SHA-1 hash of component's asset (optional) 
            var sha256 = sha256_example;  // string | Specific SHA-256 hash of component's asset (optional) 
            var sha512 = sha512_example;  // string | Specific SHA-512 hash of component's asset (optional) 
            var prerelease = prerelease_example;  // string | Prerelease version flag (optional) 
            var conanBaseVersion = conanBaseVersion_example;  // string | baseVersion (optional) 
            var conanChannel = conanChannel_example;  // string | channel (optional) 
            var dockerImageName = dockerImageName_example;  // string | Docker image name (optional) 
            var dockerImageTag = dockerImageTag_example;  // string | Docker image tag (optional) 
            var dockerLayerId = dockerLayerId_example;  // string | Docker layer ID (optional) 
            var dockerContentDigest = dockerContentDigest_example;  // string | Docker content digest (optional) 
            var mavenGroupId = mavenGroupId_example;  // string | Maven groupId (optional) 
            var mavenArtifactId = mavenArtifactId_example;  // string | Maven artifactId (optional) 
            var mavenBaseVersion = mavenBaseVersion_example;  // string | Maven base version (optional) 
            var mavenExtension = mavenExtension_example;  // string | Maven extension of component's asset (optional) 
            var mavenClassifier = mavenClassifier_example;  // string | Maven classifier of component's asset (optional) 
            var npmScope = npmScope_example;  // string | npm scope (optional) 
            var nugetId = nugetId_example;  // string | NuGet id (optional) 
            var nugetTags = nugetTags_example;  // string | NuGet tags (optional) 
            var p2PluginName = p2PluginName_example;  // string | p2 plugin name (optional) 
            var pypiClassifiers = pypiClassifiers_example;  // string | PyPI classifiers (optional) 
            var pypiDescription = pypiDescription_example;  // string | PyPI description (optional) 
            var pypiKeywords = pypiKeywords_example;  // string | PyPI keywords (optional) 
            var pypiSummary = pypiSummary_example;  // string | PyPI summary (optional) 
            var rubygemsDescription = rubygemsDescription_example;  // string | RubyGems description (optional) 
            var rubygemsPlatform = rubygemsPlatform_example;  // string | RubyGems platform (optional) 
            var rubygemsSummary = rubygemsSummary_example;  // string | RubyGems summary (optional) 
            var yumArchitecture = yumArchitecture_example;  // string | Yum architecture (optional) 

            try
            {
                // Search and download asset
                apiInstance.SearchAndDownloadAssets(sort, direction, timeout, q, repository, format, group, name, version, md5, sha1, sha256, sha512, prerelease, conanBaseVersion, conanChannel, dockerImageName, dockerImageTag, dockerLayerId, dockerContentDigest, mavenGroupId, mavenArtifactId, mavenBaseVersion, mavenExtension, mavenClassifier, npmScope, nugetId, nugetTags, p2PluginName, pypiClassifiers, pypiDescription, pypiKeywords, pypiSummary, rubygemsDescription, rubygemsPlatform, rubygemsSummary, yumArchitecture);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchAndDownloadAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **string**| The field to sort the results against, if left empty and more than 1 result is returned, the request will fail. | [optional] 
 **direction** | **string**| The direction to sort records in, defaults to ascending (&#39;asc&#39;) for all sort fields, except version, which defaults to descending (&#39;desc&#39;) | [optional] 
 **timeout** | **int?**| How long to wait for search results in seconds. If this value is not provided, the system default timeout will be used. | [optional] 
 **q** | **string**| Query by keyword | [optional] 
 **repository** | **string**| Repository name | [optional] 
 **format** | **string**| Query by format | [optional] 
 **group** | **string**| Component group | [optional] 
 **name** | **string**| Component name | [optional] 
 **version** | **string**| Component version | [optional] 
 **md5** | **string**| Specific MD5 hash of component&#39;s asset | [optional] 
 **sha1** | **string**| Specific SHA-1 hash of component&#39;s asset | [optional] 
 **sha256** | **string**| Specific SHA-256 hash of component&#39;s asset | [optional] 
 **sha512** | **string**| Specific SHA-512 hash of component&#39;s asset | [optional] 
 **prerelease** | **string**| Prerelease version flag | [optional] 
 **conanBaseVersion** | **string**| baseVersion | [optional] 
 **conanChannel** | **string**| channel | [optional] 
 **dockerImageName** | **string**| Docker image name | [optional] 
 **dockerImageTag** | **string**| Docker image tag | [optional] 
 **dockerLayerId** | **string**| Docker layer ID | [optional] 
 **dockerContentDigest** | **string**| Docker content digest | [optional] 
 **mavenGroupId** | **string**| Maven groupId | [optional] 
 **mavenArtifactId** | **string**| Maven artifactId | [optional] 
 **mavenBaseVersion** | **string**| Maven base version | [optional] 
 **mavenExtension** | **string**| Maven extension of component&#39;s asset | [optional] 
 **mavenClassifier** | **string**| Maven classifier of component&#39;s asset | [optional] 
 **npmScope** | **string**| npm scope | [optional] 
 **nugetId** | **string**| NuGet id | [optional] 
 **nugetTags** | **string**| NuGet tags | [optional] 
 **p2PluginName** | **string**| p2 plugin name | [optional] 
 **pypiClassifiers** | **string**| PyPI classifiers | [optional] 
 **pypiDescription** | **string**| PyPI description | [optional] 
 **pypiKeywords** | **string**| PyPI keywords | [optional] 
 **pypiSummary** | **string**| PyPI summary | [optional] 
 **rubygemsDescription** | **string**| RubyGems description | [optional] 
 **rubygemsPlatform** | **string**| RubyGems platform | [optional] 
 **rubygemsSummary** | **string**| RubyGems summary | [optional] 
 **yumArchitecture** | **string**| Yum architecture | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchassets"></a>
# **SearchAssets**
> PageAssetXO SearchAssets (string continuationToken = null, string sort = null, string direction = null, int? timeout = null, string q = null, string repository = null, string format = null, string group = null, string name = null, string version = null, string md5 = null, string sha1 = null, string sha256 = null, string sha512 = null, string prerelease = null, string conanBaseVersion = null, string conanChannel = null, string dockerImageName = null, string dockerImageTag = null, string dockerLayerId = null, string dockerContentDigest = null, string mavenGroupId = null, string mavenArtifactId = null, string mavenBaseVersion = null, string mavenExtension = null, string mavenClassifier = null, string npmScope = null, string nugetId = null, string nugetTags = null, string p2PluginName = null, string pypiClassifiers = null, string pypiDescription = null, string pypiKeywords = null, string pypiSummary = null, string rubygemsDescription = null, string rubygemsPlatform = null, string rubygemsSummary = null, string yumArchitecture = null)

Search assets

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class SearchAssetsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var continuationToken = continuationToken_example;  // string | A token returned by a prior request. If present, the next page of results are returned (optional) 
            var sort = sort_example;  // string | The field to sort the results against, if left empty, a sort based on match weight will be used. (optional) 
            var direction = direction_example;  // string | The direction to sort records in, defaults to ascending ('asc') for all sort fields, except version, which defaults to descending ('desc') (optional) 
            var timeout = 56;  // int? | How long to wait for search results in seconds. If this value is not provided, the system default timeout will be used. (optional) 
            var q = q_example;  // string | Query by keyword (optional) 
            var repository = repository_example;  // string | Repository name (optional) 
            var format = format_example;  // string | Query by format (optional) 
            var group = group_example;  // string | Component group (optional) 
            var name = name_example;  // string | Component name (optional) 
            var version = version_example;  // string | Component version (optional) 
            var md5 = md5_example;  // string | Specific MD5 hash of component's asset (optional) 
            var sha1 = sha1_example;  // string | Specific SHA-1 hash of component's asset (optional) 
            var sha256 = sha256_example;  // string | Specific SHA-256 hash of component's asset (optional) 
            var sha512 = sha512_example;  // string | Specific SHA-512 hash of component's asset (optional) 
            var prerelease = prerelease_example;  // string | Prerelease version flag (optional) 
            var conanBaseVersion = conanBaseVersion_example;  // string | baseVersion (optional) 
            var conanChannel = conanChannel_example;  // string | channel (optional) 
            var dockerImageName = dockerImageName_example;  // string | Docker image name (optional) 
            var dockerImageTag = dockerImageTag_example;  // string | Docker image tag (optional) 
            var dockerLayerId = dockerLayerId_example;  // string | Docker layer ID (optional) 
            var dockerContentDigest = dockerContentDigest_example;  // string | Docker content digest (optional) 
            var mavenGroupId = mavenGroupId_example;  // string | Maven groupId (optional) 
            var mavenArtifactId = mavenArtifactId_example;  // string | Maven artifactId (optional) 
            var mavenBaseVersion = mavenBaseVersion_example;  // string | Maven base version (optional) 
            var mavenExtension = mavenExtension_example;  // string | Maven extension of component's asset (optional) 
            var mavenClassifier = mavenClassifier_example;  // string | Maven classifier of component's asset (optional) 
            var npmScope = npmScope_example;  // string | npm scope (optional) 
            var nugetId = nugetId_example;  // string | NuGet id (optional) 
            var nugetTags = nugetTags_example;  // string | NuGet tags (optional) 
            var p2PluginName = p2PluginName_example;  // string | p2 plugin name (optional) 
            var pypiClassifiers = pypiClassifiers_example;  // string | PyPI classifiers (optional) 
            var pypiDescription = pypiDescription_example;  // string | PyPI description (optional) 
            var pypiKeywords = pypiKeywords_example;  // string | PyPI keywords (optional) 
            var pypiSummary = pypiSummary_example;  // string | PyPI summary (optional) 
            var rubygemsDescription = rubygemsDescription_example;  // string | RubyGems description (optional) 
            var rubygemsPlatform = rubygemsPlatform_example;  // string | RubyGems platform (optional) 
            var rubygemsSummary = rubygemsSummary_example;  // string | RubyGems summary (optional) 
            var yumArchitecture = yumArchitecture_example;  // string | Yum architecture (optional) 

            try
            {
                // Search assets
                PageAssetXO result = apiInstance.SearchAssets(continuationToken, sort, direction, timeout, q, repository, format, group, name, version, md5, sha1, sha256, sha512, prerelease, conanBaseVersion, conanChannel, dockerImageName, dockerImageTag, dockerLayerId, dockerContentDigest, mavenGroupId, mavenArtifactId, mavenBaseVersion, mavenExtension, mavenClassifier, npmScope, nugetId, nugetTags, p2PluginName, pypiClassifiers, pypiDescription, pypiKeywords, pypiSummary, rubygemsDescription, rubygemsPlatform, rubygemsSummary, yumArchitecture);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **continuationToken** | **string**| A token returned by a prior request. If present, the next page of results are returned | [optional] 
 **sort** | **string**| The field to sort the results against, if left empty, a sort based on match weight will be used. | [optional] 
 **direction** | **string**| The direction to sort records in, defaults to ascending (&#39;asc&#39;) for all sort fields, except version, which defaults to descending (&#39;desc&#39;) | [optional] 
 **timeout** | **int?**| How long to wait for search results in seconds. If this value is not provided, the system default timeout will be used. | [optional] 
 **q** | **string**| Query by keyword | [optional] 
 **repository** | **string**| Repository name | [optional] 
 **format** | **string**| Query by format | [optional] 
 **group** | **string**| Component group | [optional] 
 **name** | **string**| Component name | [optional] 
 **version** | **string**| Component version | [optional] 
 **md5** | **string**| Specific MD5 hash of component&#39;s asset | [optional] 
 **sha1** | **string**| Specific SHA-1 hash of component&#39;s asset | [optional] 
 **sha256** | **string**| Specific SHA-256 hash of component&#39;s asset | [optional] 
 **sha512** | **string**| Specific SHA-512 hash of component&#39;s asset | [optional] 
 **prerelease** | **string**| Prerelease version flag | [optional] 
 **conanBaseVersion** | **string**| baseVersion | [optional] 
 **conanChannel** | **string**| channel | [optional] 
 **dockerImageName** | **string**| Docker image name | [optional] 
 **dockerImageTag** | **string**| Docker image tag | [optional] 
 **dockerLayerId** | **string**| Docker layer ID | [optional] 
 **dockerContentDigest** | **string**| Docker content digest | [optional] 
 **mavenGroupId** | **string**| Maven groupId | [optional] 
 **mavenArtifactId** | **string**| Maven artifactId | [optional] 
 **mavenBaseVersion** | **string**| Maven base version | [optional] 
 **mavenExtension** | **string**| Maven extension of component&#39;s asset | [optional] 
 **mavenClassifier** | **string**| Maven classifier of component&#39;s asset | [optional] 
 **npmScope** | **string**| npm scope | [optional] 
 **nugetId** | **string**| NuGet id | [optional] 
 **nugetTags** | **string**| NuGet tags | [optional] 
 **p2PluginName** | **string**| p2 plugin name | [optional] 
 **pypiClassifiers** | **string**| PyPI classifiers | [optional] 
 **pypiDescription** | **string**| PyPI description | [optional] 
 **pypiKeywords** | **string**| PyPI keywords | [optional] 
 **pypiSummary** | **string**| PyPI summary | [optional] 
 **rubygemsDescription** | **string**| RubyGems description | [optional] 
 **rubygemsPlatform** | **string**| RubyGems platform | [optional] 
 **rubygemsSummary** | **string**| RubyGems summary | [optional] 
 **yumArchitecture** | **string**| Yum architecture | [optional] 

### Return type

[**PageAssetXO**](PageAssetXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

