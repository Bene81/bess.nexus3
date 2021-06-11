# Bess.IO.Rest.Nexus3.Api.RepositoryManagementApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRepository**](RepositoryManagementApi.md#createrepository) | **POST** /v1/repositories/maven/group | Create Maven group repository
[**CreateRepository1**](RepositoryManagementApi.md#createrepository1) | **POST** /v1/repositories/maven/hosted | Create Maven hosted repository
[**CreateRepository10**](RepositoryManagementApi.md#createrepository10) | **POST** /v1/repositories/helm/proxy | Create Helm proxy repository
[**CreateRepository11**](RepositoryManagementApi.md#createrepository11) | **POST** /v1/repositories/pypi/group | Create PyPI group repository
[**CreateRepository12**](RepositoryManagementApi.md#createrepository12) | **POST** /v1/repositories/pypi/hosted | Create PyPI hosted repository
[**CreateRepository13**](RepositoryManagementApi.md#createrepository13) | **POST** /v1/repositories/pypi/proxy | Create PyPI proxy repository
[**CreateRepository14**](RepositoryManagementApi.md#createrepository14) | **POST** /v1/repositories/nuget/group | Create NuGet group repository
[**CreateRepository15**](RepositoryManagementApi.md#createrepository15) | **POST** /v1/repositories/nuget/hosted | Create NuGet hosted repository
[**CreateRepository16**](RepositoryManagementApi.md#createrepository16) | **POST** /v1/repositories/nuget/proxy | Create NuGet proxy repository
[**CreateRepository17**](RepositoryManagementApi.md#createrepository17) | **POST** /v1/repositories/rubygems/group | Create RubyGems group repository
[**CreateRepository18**](RepositoryManagementApi.md#createrepository18) | **POST** /v1/repositories/rubygems/hosted | Create RubyGems hosted repository
[**CreateRepository19**](RepositoryManagementApi.md#createrepository19) | **POST** /v1/repositories/rubygems/proxy | Create RubyGems proxy repository
[**CreateRepository2**](RepositoryManagementApi.md#createrepository2) | **POST** /v1/repositories/maven/proxy | Create Maven proxy repository
[**CreateRepository20**](RepositoryManagementApi.md#createrepository20) | **POST** /v1/repositories/docker/group | Create Docker group repository
[**CreateRepository21**](RepositoryManagementApi.md#createrepository21) | **POST** /v1/repositories/docker/hosted | Create Docker hosted repository
[**CreateRepository22**](RepositoryManagementApi.md#createrepository22) | **POST** /v1/repositories/docker/proxy | Create Docker proxy repository
[**CreateRepository23**](RepositoryManagementApi.md#createrepository23) | **POST** /v1/repositories/yum/group | Create Yum group repository
[**CreateRepository24**](RepositoryManagementApi.md#createrepository24) | **POST** /v1/repositories/yum/hosted | Create Yum hosted repository
[**CreateRepository25**](RepositoryManagementApi.md#createrepository25) | **POST** /v1/repositories/yum/proxy | Create Yum proxy repository
[**CreateRepository26**](RepositoryManagementApi.md#createrepository26) | **POST** /v1/repositories/apt/hosted | Create APT hosted repository
[**CreateRepository27**](RepositoryManagementApi.md#createrepository27) | **POST** /v1/repositories/apt/proxy | Create APT proxy repository
[**CreateRepository28**](RepositoryManagementApi.md#createrepository28) | **POST** /v1/repositories/cocoapods/proxy | Create Cocoapods proxy repository
[**CreateRepository29**](RepositoryManagementApi.md#createrepository29) | **POST** /v1/repositories/conan/proxy | Create Conan proxy repository
[**CreateRepository3**](RepositoryManagementApi.md#createrepository3) | **POST** /v1/repositories/raw/group | Create raw group repository
[**CreateRepository30**](RepositoryManagementApi.md#createrepository30) | **POST** /v1/repositories/conda/proxy | Create conda proxy repository
[**CreateRepository31**](RepositoryManagementApi.md#createrepository31) | **POST** /v1/repositories/go/group | Create a Go group repository
[**CreateRepository32**](RepositoryManagementApi.md#createrepository32) | **POST** /v1/repositories/go/proxy | Create a Go proxy repository
[**CreateRepository33**](RepositoryManagementApi.md#createrepository33) | **POST** /v1/repositories/p2/proxy | Create p2 proxy repository
[**CreateRepository34**](RepositoryManagementApi.md#createrepository34) | **POST** /v1/repositories/r/group | Create R group repository
[**CreateRepository35**](RepositoryManagementApi.md#createrepository35) | **POST** /v1/repositories/r/hosted | Create R hosted repository
[**CreateRepository36**](RepositoryManagementApi.md#createrepository36) | **POST** /v1/repositories/r/proxy | Create R proxy repository
[**CreateRepository37**](RepositoryManagementApi.md#createrepository37) | **POST** /v1/repositories/bower/group | Create Bower group repository
[**CreateRepository38**](RepositoryManagementApi.md#createrepository38) | **POST** /v1/repositories/bower/hosted | Create Bower hosted repository
[**CreateRepository39**](RepositoryManagementApi.md#createrepository39) | **POST** /v1/repositories/bower/proxy | Create Bower proxy repository
[**CreateRepository4**](RepositoryManagementApi.md#createrepository4) | **POST** /v1/repositories/raw/hosted | Create raw hosted repository
[**CreateRepository40**](RepositoryManagementApi.md#createrepository40) | **POST** /v1/repositories/gitlfs/hosted | Create Git LFS hosted repository
[**CreateRepository5**](RepositoryManagementApi.md#createrepository5) | **POST** /v1/repositories/raw/proxy | Create raw proxy repository
[**CreateRepository6**](RepositoryManagementApi.md#createrepository6) | **POST** /v1/repositories/npm/group | Create npm group repository
[**CreateRepository7**](RepositoryManagementApi.md#createrepository7) | **POST** /v1/repositories/npm/hosted | Create npm hosted repository
[**CreateRepository8**](RepositoryManagementApi.md#createrepository8) | **POST** /v1/repositories/npm/proxy | Create npm proxy repository
[**CreateRepository9**](RepositoryManagementApi.md#createrepository9) | **POST** /v1/repositories/helm/hosted | Create Helm hosted repository
[**DeleteRepository**](RepositoryManagementApi.md#deleterepository) | **DELETE** /v1/repositories/{repositoryName} | Delete repository of any format
[**DisableRepositoryHealthCheck**](RepositoryManagementApi.md#disablerepositoryhealthcheck) | **DELETE** /v1/repositories/{repositoryName}/health-check | Disable repository health check. Proxy repositories only.
[**EnableRepositoryHealthCheck**](RepositoryManagementApi.md#enablerepositoryhealthcheck) | **POST** /v1/repositories/{repositoryName}/health-check | Enable repository health check. Proxy repositories only.
[**GetRepositories**](RepositoryManagementApi.md#getrepositories) | **GET** /v1/repositorySettings | List repositories
[**GetRepositories1**](RepositoryManagementApi.md#getrepositories1) | **GET** /v1/repositories | List repositories
[**GetRepository**](RepositoryManagementApi.md#getrepository) | **GET** /v1/repositories/maven/group/{repositoryName} | Get repository
[**GetRepository1**](RepositoryManagementApi.md#getrepository1) | **GET** /v1/repositories/maven/hosted/{repositoryName} | Get repository
[**GetRepository10**](RepositoryManagementApi.md#getrepository10) | **GET** /v1/repositories/helm/proxy/{repositoryName} | Get repository
[**GetRepository11**](RepositoryManagementApi.md#getrepository11) | **GET** /v1/repositories/pypi/group/{repositoryName} | Get repository
[**GetRepository12**](RepositoryManagementApi.md#getrepository12) | **GET** /v1/repositories/pypi/hosted/{repositoryName} | Get repository
[**GetRepository13**](RepositoryManagementApi.md#getrepository13) | **GET** /v1/repositories/pypi/proxy/{repositoryName} | Get repository
[**GetRepository14**](RepositoryManagementApi.md#getrepository14) | **GET** /v1/repositories/nuget/group/{repositoryName} | Get repository
[**GetRepository15**](RepositoryManagementApi.md#getrepository15) | **GET** /v1/repositories/nuget/hosted/{repositoryName} | Get repository
[**GetRepository16**](RepositoryManagementApi.md#getrepository16) | **GET** /v1/repositories/nuget/proxy/{repositoryName} | Get repository
[**GetRepository17**](RepositoryManagementApi.md#getrepository17) | **GET** /v1/repositories/rubygems/group/{repositoryName} | Get repository
[**GetRepository18**](RepositoryManagementApi.md#getrepository18) | **GET** /v1/repositories/rubygems/hosted/{repositoryName} | Get repository
[**GetRepository19**](RepositoryManagementApi.md#getrepository19) | **GET** /v1/repositories/rubygems/proxy/{repositoryName} | Get repository
[**GetRepository2**](RepositoryManagementApi.md#getrepository2) | **GET** /v1/repositories/maven/proxy/{repositoryName} | Get repository
[**GetRepository20**](RepositoryManagementApi.md#getrepository20) | **GET** /v1/repositories/docker/group/{repositoryName} | Get repository
[**GetRepository21**](RepositoryManagementApi.md#getrepository21) | **GET** /v1/repositories/docker/hosted/{repositoryName} | Get repository
[**GetRepository22**](RepositoryManagementApi.md#getrepository22) | **GET** /v1/repositories/docker/proxy/{repositoryName} | Get repository
[**GetRepository23**](RepositoryManagementApi.md#getrepository23) | **GET** /v1/repositories/yum/group/{repositoryName} | Get repository
[**GetRepository24**](RepositoryManagementApi.md#getrepository24) | **GET** /v1/repositories/yum/hosted/{repositoryName} | Get repository
[**GetRepository25**](RepositoryManagementApi.md#getrepository25) | **GET** /v1/repositories/yum/proxy/{repositoryName} | Get repository
[**GetRepository26**](RepositoryManagementApi.md#getrepository26) | **GET** /v1/repositories/apt/hosted/{repositoryName} | Get repository
[**GetRepository27**](RepositoryManagementApi.md#getrepository27) | **GET** /v1/repositories/apt/proxy/{repositoryName} | Get repository
[**GetRepository28**](RepositoryManagementApi.md#getrepository28) | **GET** /v1/repositories/cocoapods/proxy/{repositoryName} | Get repository
[**GetRepository29**](RepositoryManagementApi.md#getrepository29) | **GET** /v1/repositories/conan/proxy/{repositoryName} | Get repository
[**GetRepository3**](RepositoryManagementApi.md#getrepository3) | **GET** /v1/repositories/raw/group/{repositoryName} | Get repository
[**GetRepository30**](RepositoryManagementApi.md#getrepository30) | **GET** /v1/repositories/conda/proxy/{repositoryName} | Get repository
[**GetRepository31**](RepositoryManagementApi.md#getrepository31) | **GET** /v1/repositories/go/group/{repositoryName} | Get repository
[**GetRepository32**](RepositoryManagementApi.md#getrepository32) | **GET** /v1/repositories/go/proxy/{repositoryName} | Get repository
[**GetRepository33**](RepositoryManagementApi.md#getrepository33) | **GET** /v1/repositories/p2/proxy/{repositoryName} | Get repository
[**GetRepository34**](RepositoryManagementApi.md#getrepository34) | **GET** /v1/repositories/r/group/{repositoryName} | Get repository
[**GetRepository35**](RepositoryManagementApi.md#getrepository35) | **GET** /v1/repositories/r/hosted/{repositoryName} | Get repository
[**GetRepository36**](RepositoryManagementApi.md#getrepository36) | **GET** /v1/repositories/r/proxy/{repositoryName} | Get repository
[**GetRepository37**](RepositoryManagementApi.md#getrepository37) | **GET** /v1/repositories/bower/group/{repositoryName} | Get repository
[**GetRepository38**](RepositoryManagementApi.md#getrepository38) | **GET** /v1/repositories/bower/hosted/{repositoryName} | Get repository
[**GetRepository39**](RepositoryManagementApi.md#getrepository39) | **GET** /v1/repositories/bower/proxy/{repositoryName} | Get repository
[**GetRepository4**](RepositoryManagementApi.md#getrepository4) | **GET** /v1/repositories/raw/hosted/{repositoryName} | Get repository
[**GetRepository40**](RepositoryManagementApi.md#getrepository40) | **GET** /v1/repositories/gitlfs/hosted/{repositoryName} | Get repository
[**GetRepository5**](RepositoryManagementApi.md#getrepository5) | **GET** /v1/repositories/raw/proxy/{repositoryName} | Get repository
[**GetRepository6**](RepositoryManagementApi.md#getrepository6) | **GET** /v1/repositories/npm/group/{repositoryName} | Get repository
[**GetRepository7**](RepositoryManagementApi.md#getrepository7) | **GET** /v1/repositories/npm/hosted/{repositoryName} | Get repository
[**GetRepository8**](RepositoryManagementApi.md#getrepository8) | **GET** /v1/repositories/npm/proxy/{repositoryName} | Get repository
[**GetRepository9**](RepositoryManagementApi.md#getrepository9) | **GET** /v1/repositories/helm/hosted/{repositoryName} | Get repository
[**InvalidateCache**](RepositoryManagementApi.md#invalidatecache) | **POST** /v1/repositories/{repositoryName}/invalidate-cache | Invalidate repository cache. Proxy or group repositories only.
[**RebuildIndex**](RepositoryManagementApi.md#rebuildindex) | **POST** /v1/repositories/{repositoryName}/rebuild-index | Schedule a &#39;Repair - Rebuild repository search&#39; Task. Hosted or proxy repositories only.
[**UpdateRepository**](RepositoryManagementApi.md#updaterepository) | **PUT** /v1/repositories/maven/group/{repositoryName} | Update Maven group repository
[**UpdateRepository1**](RepositoryManagementApi.md#updaterepository1) | **PUT** /v1/repositories/maven/hosted/{repositoryName} | Update Maven hosted repository
[**UpdateRepository10**](RepositoryManagementApi.md#updaterepository10) | **PUT** /v1/repositories/helm/proxy/{repositoryName} | Update Helm proxy repository
[**UpdateRepository11**](RepositoryManagementApi.md#updaterepository11) | **PUT** /v1/repositories/pypi/group/{repositoryName} | Update PyPI group repository
[**UpdateRepository12**](RepositoryManagementApi.md#updaterepository12) | **PUT** /v1/repositories/pypi/hosted/{repositoryName} | Update PyPI hosted repository
[**UpdateRepository13**](RepositoryManagementApi.md#updaterepository13) | **PUT** /v1/repositories/pypi/proxy/{repositoryName} | Update PyPI proxy repository
[**UpdateRepository14**](RepositoryManagementApi.md#updaterepository14) | **PUT** /v1/repositories/nuget/group/{repositoryName} | Update NuGet group repository
[**UpdateRepository15**](RepositoryManagementApi.md#updaterepository15) | **PUT** /v1/repositories/nuget/hosted/{repositoryName} | Update NuGet hosted repository
[**UpdateRepository16**](RepositoryManagementApi.md#updaterepository16) | **PUT** /v1/repositories/nuget/proxy/{repositoryName} | Update NuGet proxy repository
[**UpdateRepository17**](RepositoryManagementApi.md#updaterepository17) | **PUT** /v1/repositories/rubygems/group/{repositoryName} | Update RubyGems group repository
[**UpdateRepository18**](RepositoryManagementApi.md#updaterepository18) | **PUT** /v1/repositories/rubygems/hosted/{repositoryName} | Update RubyGems hosted repository
[**UpdateRepository19**](RepositoryManagementApi.md#updaterepository19) | **PUT** /v1/repositories/rubygems/proxy/{repositoryName} | Update RubyGems proxy repository
[**UpdateRepository2**](RepositoryManagementApi.md#updaterepository2) | **PUT** /v1/repositories/maven/proxy/{repositoryName} | Update Maven proxy repository
[**UpdateRepository20**](RepositoryManagementApi.md#updaterepository20) | **PUT** /v1/repositories/docker/group/{repositoryName} | Update Docker group repository
[**UpdateRepository21**](RepositoryManagementApi.md#updaterepository21) | **PUT** /v1/repositories/docker/hosted/{repositoryName} | Update Docker hosted repository
[**UpdateRepository22**](RepositoryManagementApi.md#updaterepository22) | **PUT** /v1/repositories/docker/proxy/{repositoryName} | Update Docker group repository
[**UpdateRepository23**](RepositoryManagementApi.md#updaterepository23) | **PUT** /v1/repositories/yum/group/{repositoryName} | Update Yum group repository
[**UpdateRepository24**](RepositoryManagementApi.md#updaterepository24) | **PUT** /v1/repositories/yum/hosted/{repositoryName} | Update Yum hosted repository
[**UpdateRepository25**](RepositoryManagementApi.md#updaterepository25) | **PUT** /v1/repositories/yum/proxy/{repositoryName} | Update Yum proxy repository
[**UpdateRepository26**](RepositoryManagementApi.md#updaterepository26) | **PUT** /v1/repositories/apt/hosted/{repositoryName} | Update APT hosted repository
[**UpdateRepository27**](RepositoryManagementApi.md#updaterepository27) | **PUT** /v1/repositories/apt/proxy/{repositoryName} | Update APT proxy repository
[**UpdateRepository28**](RepositoryManagementApi.md#updaterepository28) | **PUT** /v1/repositories/cocoapods/proxy/{repositoryName} | Update Cocoapods proxy repository
[**UpdateRepository29**](RepositoryManagementApi.md#updaterepository29) | **PUT** /v1/repositories/conan/proxy/{repositoryName} | Update Conan proxy repository
[**UpdateRepository3**](RepositoryManagementApi.md#updaterepository3) | **PUT** /v1/repositories/raw/group/{repositoryName} | Update raw group repository
[**UpdateRepository30**](RepositoryManagementApi.md#updaterepository30) | **PUT** /v1/repositories/conda/proxy/{repositoryName} | Update conda proxy repository
[**UpdateRepository31**](RepositoryManagementApi.md#updaterepository31) | **PUT** /v1/repositories/go/group/{repositoryName} | Update a Go group repository
[**UpdateRepository32**](RepositoryManagementApi.md#updaterepository32) | **PUT** /v1/repositories/go/proxy/{repositoryName} | Update a Go proxy repository
[**UpdateRepository33**](RepositoryManagementApi.md#updaterepository33) | **PUT** /v1/repositories/p2/proxy/{repositoryName} | Update p2 proxy repository
[**UpdateRepository34**](RepositoryManagementApi.md#updaterepository34) | **PUT** /v1/repositories/r/group/{repositoryName} | Update R group repository
[**UpdateRepository35**](RepositoryManagementApi.md#updaterepository35) | **PUT** /v1/repositories/r/hosted/{repositoryName} | Update R hosted repository
[**UpdateRepository36**](RepositoryManagementApi.md#updaterepository36) | **PUT** /v1/repositories/r/proxy/{repositoryName} | Update R proxy repository
[**UpdateRepository37**](RepositoryManagementApi.md#updaterepository37) | **PUT** /v1/repositories/bower/group/{repositoryName} | Update Bower group repository
[**UpdateRepository38**](RepositoryManagementApi.md#updaterepository38) | **PUT** /v1/repositories/bower/hosted/{repositoryName} | Update Bower hosted repository
[**UpdateRepository39**](RepositoryManagementApi.md#updaterepository39) | **PUT** /v1/repositories/bower/proxy/{repositoryName} | Update Bower proxy repository
[**UpdateRepository4**](RepositoryManagementApi.md#updaterepository4) | **PUT** /v1/repositories/raw/hosted/{repositoryName} | Update raw hosted repository
[**UpdateRepository40**](RepositoryManagementApi.md#updaterepository40) | **PUT** /v1/repositories/gitlfs/hosted/{repositoryName} | Update Git LFS hosted repository
[**UpdateRepository5**](RepositoryManagementApi.md#updaterepository5) | **PUT** /v1/repositories/raw/proxy/{repositoryName} | Update raw proxy repository
[**UpdateRepository6**](RepositoryManagementApi.md#updaterepository6) | **PUT** /v1/repositories/npm/group/{repositoryName} | Update npm group repository
[**UpdateRepository7**](RepositoryManagementApi.md#updaterepository7) | **PUT** /v1/repositories/npm/hosted/{repositoryName} | Update npm hosted repository
[**UpdateRepository8**](RepositoryManagementApi.md#updaterepository8) | **PUT** /v1/repositories/npm/proxy/{repositoryName} | Update npm proxy repository
[**UpdateRepository9**](RepositoryManagementApi.md#updaterepository9) | **PUT** /v1/repositories/helm/hosted/{repositoryName} | Update Helm hosted repository


<a name="createrepository"></a>
# **CreateRepository**
> void CreateRepository (MavenGroupRepositoryApiRequest body = null)

Create Maven group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepositoryExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new MavenGroupRepositoryApiRequest(); // MavenGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create Maven group repository
                apiInstance.CreateRepository(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MavenGroupRepositoryApiRequest**](MavenGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository1"></a>
# **CreateRepository1**
> void CreateRepository1 (MavenHostedRepositoryApiRequest body = null)

Create Maven hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository1Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new MavenHostedRepositoryApiRequest(); // MavenHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create Maven hosted repository
                apiInstance.CreateRepository1(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MavenHostedRepositoryApiRequest**](MavenHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository10"></a>
# **CreateRepository10**
> void CreateRepository10 (HelmProxyRepositoryApiRequest body = null)

Create Helm proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository10Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new HelmProxyRepositoryApiRequest(); // HelmProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create Helm proxy repository
                apiInstance.CreateRepository10(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository10: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HelmProxyRepositoryApiRequest**](HelmProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository11"></a>
# **CreateRepository11**
> void CreateRepository11 (PypiGroupRepositoryApiRequest body = null)

Create PyPI group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository11Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new PypiGroupRepositoryApiRequest(); // PypiGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create PyPI group repository
                apiInstance.CreateRepository11(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository11: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PypiGroupRepositoryApiRequest**](PypiGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository12"></a>
# **CreateRepository12**
> void CreateRepository12 (PypiHostedRepositoryApiRequest body = null)

Create PyPI hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository12Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new PypiHostedRepositoryApiRequest(); // PypiHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create PyPI hosted repository
                apiInstance.CreateRepository12(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository12: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PypiHostedRepositoryApiRequest**](PypiHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository13"></a>
# **CreateRepository13**
> void CreateRepository13 (PypiProxyRepositoryApiRequest body = null)

Create PyPI proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository13Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new PypiProxyRepositoryApiRequest(); // PypiProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create PyPI proxy repository
                apiInstance.CreateRepository13(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository13: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PypiProxyRepositoryApiRequest**](PypiProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository14"></a>
# **CreateRepository14**
> void CreateRepository14 (NugetGroupRepositoryApiRequest body = null)

Create NuGet group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository14Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new NugetGroupRepositoryApiRequest(); // NugetGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create NuGet group repository
                apiInstance.CreateRepository14(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository14: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NugetGroupRepositoryApiRequest**](NugetGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository15"></a>
# **CreateRepository15**
> void CreateRepository15 (NugetHostedRepositoryApiRequest body = null)

Create NuGet hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository15Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new NugetHostedRepositoryApiRequest(); // NugetHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create NuGet hosted repository
                apiInstance.CreateRepository15(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository15: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NugetHostedRepositoryApiRequest**](NugetHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository16"></a>
# **CreateRepository16**
> void CreateRepository16 (NugetProxyRepositoryApiRequest body = null)

Create NuGet proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository16Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new NugetProxyRepositoryApiRequest(); // NugetProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create NuGet proxy repository
                apiInstance.CreateRepository16(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository16: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NugetProxyRepositoryApiRequest**](NugetProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository17"></a>
# **CreateRepository17**
> void CreateRepository17 (RubyGemsGroupRepositoryApiRequest body = null)

Create RubyGems group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository17Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RubyGemsGroupRepositoryApiRequest(); // RubyGemsGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create RubyGems group repository
                apiInstance.CreateRepository17(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository17: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RubyGemsGroupRepositoryApiRequest**](RubyGemsGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository18"></a>
# **CreateRepository18**
> void CreateRepository18 (RubyGemsHostedRepositoryApiRequest body = null)

Create RubyGems hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository18Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RubyGemsHostedRepositoryApiRequest(); // RubyGemsHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create RubyGems hosted repository
                apiInstance.CreateRepository18(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository18: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RubyGemsHostedRepositoryApiRequest**](RubyGemsHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository19"></a>
# **CreateRepository19**
> void CreateRepository19 (RubyGemsProxyRepositoryApiRequest body = null)

Create RubyGems proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository19Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RubyGemsProxyRepositoryApiRequest(); // RubyGemsProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create RubyGems proxy repository
                apiInstance.CreateRepository19(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository19: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RubyGemsProxyRepositoryApiRequest**](RubyGemsProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository2"></a>
# **CreateRepository2**
> void CreateRepository2 (MavenProxyRepositoryApiRequest body = null)

Create Maven proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository2Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new MavenProxyRepositoryApiRequest(); // MavenProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create Maven proxy repository
                apiInstance.CreateRepository2(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MavenProxyRepositoryApiRequest**](MavenProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository20"></a>
# **CreateRepository20**
> void CreateRepository20 (DockerGroupRepositoryApiRequest body = null)

Create Docker group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository20Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new DockerGroupRepositoryApiRequest(); // DockerGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create Docker group repository
                apiInstance.CreateRepository20(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository20: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DockerGroupRepositoryApiRequest**](DockerGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository21"></a>
# **CreateRepository21**
> void CreateRepository21 (DockerHostedRepositoryApiRequest body = null)

Create Docker hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository21Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new DockerHostedRepositoryApiRequest(); // DockerHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create Docker hosted repository
                apiInstance.CreateRepository21(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository21: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DockerHostedRepositoryApiRequest**](DockerHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository22"></a>
# **CreateRepository22**
> void CreateRepository22 (DockerProxyRepositoryApiRequest body = null)

Create Docker proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository22Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new DockerProxyRepositoryApiRequest(); // DockerProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create Docker proxy repository
                apiInstance.CreateRepository22(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository22: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DockerProxyRepositoryApiRequest**](DockerProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository23"></a>
# **CreateRepository23**
> void CreateRepository23 (YumGroupRepositoryApiRequest body = null)

Create Yum group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository23Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new YumGroupRepositoryApiRequest(); // YumGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create Yum group repository
                apiInstance.CreateRepository23(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository23: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**YumGroupRepositoryApiRequest**](YumGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository24"></a>
# **CreateRepository24**
> void CreateRepository24 (YumHostedRepositoryApiRequest body = null)

Create Yum hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository24Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new YumHostedRepositoryApiRequest(); // YumHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create Yum hosted repository
                apiInstance.CreateRepository24(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository24: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**YumHostedRepositoryApiRequest**](YumHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository25"></a>
# **CreateRepository25**
> void CreateRepository25 (YumProxyRepositoryApiRequest body = null)

Create Yum proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository25Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new YumProxyRepositoryApiRequest(); // YumProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create Yum proxy repository
                apiInstance.CreateRepository25(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository25: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**YumProxyRepositoryApiRequest**](YumProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository26"></a>
# **CreateRepository26**
> void CreateRepository26 (AptHostedRepositoryApiRequest body = null)

Create APT hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository26Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new AptHostedRepositoryApiRequest(); // AptHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create APT hosted repository
                apiInstance.CreateRepository26(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository26: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AptHostedRepositoryApiRequest**](AptHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository27"></a>
# **CreateRepository27**
> void CreateRepository27 (AptProxyRepositoryApiRequest body = null)

Create APT proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository27Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new AptProxyRepositoryApiRequest(); // AptProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create APT proxy repository
                apiInstance.CreateRepository27(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository27: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AptProxyRepositoryApiRequest**](AptProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository28"></a>
# **CreateRepository28**
> void CreateRepository28 (CocoapodsProxyRepositoryApiRequest body = null)

Create Cocoapods proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository28Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new CocoapodsProxyRepositoryApiRequest(); // CocoapodsProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create Cocoapods proxy repository
                apiInstance.CreateRepository28(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository28: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CocoapodsProxyRepositoryApiRequest**](CocoapodsProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository29"></a>
# **CreateRepository29**
> void CreateRepository29 (ConanProxyRepositoryApiRequest body = null)

Create Conan proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository29Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new ConanProxyRepositoryApiRequest(); // ConanProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create Conan proxy repository
                apiInstance.CreateRepository29(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository29: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConanProxyRepositoryApiRequest**](ConanProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository3"></a>
# **CreateRepository3**
> void CreateRepository3 (RawGroupRepositoryApiRequest body = null)

Create raw group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository3Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RawGroupRepositoryApiRequest(); // RawGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create raw group repository
                apiInstance.CreateRepository3(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RawGroupRepositoryApiRequest**](RawGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository30"></a>
# **CreateRepository30**
> void CreateRepository30 (CondaProxyRepositoryApiRequest body = null)

Create conda proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository30Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new CondaProxyRepositoryApiRequest(); // CondaProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create conda proxy repository
                apiInstance.CreateRepository30(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository30: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CondaProxyRepositoryApiRequest**](CondaProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository31"></a>
# **CreateRepository31**
> void CreateRepository31 (GolangGroupRepositoryApiRequest body = null)

Create a Go group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository31Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new GolangGroupRepositoryApiRequest(); // GolangGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create a Go group repository
                apiInstance.CreateRepository31(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository31: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GolangGroupRepositoryApiRequest**](GolangGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository32"></a>
# **CreateRepository32**
> void CreateRepository32 (GolangProxyRepositoryApiRequest body = null)

Create a Go proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository32Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new GolangProxyRepositoryApiRequest(); // GolangProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create a Go proxy repository
                apiInstance.CreateRepository32(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository32: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GolangProxyRepositoryApiRequest**](GolangProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository33"></a>
# **CreateRepository33**
> void CreateRepository33 (P2ProxyRepositoryApiRequest body = null)

Create p2 proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository33Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new P2ProxyRepositoryApiRequest(); // P2ProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create p2 proxy repository
                apiInstance.CreateRepository33(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository33: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**P2ProxyRepositoryApiRequest**](P2ProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository34"></a>
# **CreateRepository34**
> void CreateRepository34 (RGroupRepositoryApiRequest body = null)

Create R group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository34Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RGroupRepositoryApiRequest(); // RGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create R group repository
                apiInstance.CreateRepository34(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository34: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RGroupRepositoryApiRequest**](RGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository35"></a>
# **CreateRepository35**
> void CreateRepository35 (RHostedRepositoryApiRequest body = null)

Create R hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository35Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RHostedRepositoryApiRequest(); // RHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create R hosted repository
                apiInstance.CreateRepository35(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository35: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RHostedRepositoryApiRequest**](RHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository36"></a>
# **CreateRepository36**
> void CreateRepository36 (RProxyRepositoryApiRequest body = null)

Create R proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository36Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RProxyRepositoryApiRequest(); // RProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create R proxy repository
                apiInstance.CreateRepository36(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository36: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RProxyRepositoryApiRequest**](RProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository37"></a>
# **CreateRepository37**
> void CreateRepository37 (BowerGroupRepositoryApiRequest body = null)

Create Bower group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository37Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new BowerGroupRepositoryApiRequest(); // BowerGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create Bower group repository
                apiInstance.CreateRepository37(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository37: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BowerGroupRepositoryApiRequest**](BowerGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository38"></a>
# **CreateRepository38**
> void CreateRepository38 (BowerHostedRepositoryApiRequest body = null)

Create Bower hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository38Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new BowerHostedRepositoryApiRequest(); // BowerHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create Bower hosted repository
                apiInstance.CreateRepository38(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository38: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BowerHostedRepositoryApiRequest**](BowerHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository39"></a>
# **CreateRepository39**
> void CreateRepository39 (BowerProxyRepositoryApiRequest body = null)

Create Bower proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository39Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new BowerProxyRepositoryApiRequest(); // BowerProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create Bower proxy repository
                apiInstance.CreateRepository39(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository39: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BowerProxyRepositoryApiRequest**](BowerProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository4"></a>
# **CreateRepository4**
> void CreateRepository4 (RawHostedRepositoryApiRequest body = null)

Create raw hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository4Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RawHostedRepositoryApiRequest(); // RawHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create raw hosted repository
                apiInstance.CreateRepository4(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RawHostedRepositoryApiRequest**](RawHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository40"></a>
# **CreateRepository40**
> void CreateRepository40 (GitLfsHostedRepositoryApiRequest body = null)

Create Git LFS hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository40Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new GitLfsHostedRepositoryApiRequest(); // GitLfsHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create Git LFS hosted repository
                apiInstance.CreateRepository40(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository40: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GitLfsHostedRepositoryApiRequest**](GitLfsHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository5"></a>
# **CreateRepository5**
> void CreateRepository5 (RawProxyRepositoryApiRequest body = null)

Create raw proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository5Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new RawProxyRepositoryApiRequest(); // RawProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create raw proxy repository
                apiInstance.CreateRepository5(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository5: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RawProxyRepositoryApiRequest**](RawProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository6"></a>
# **CreateRepository6**
> void CreateRepository6 (NpmGroupRepositoryApiRequest body = null)

Create npm group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository6Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new NpmGroupRepositoryApiRequest(); // NpmGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Create npm group repository
                apiInstance.CreateRepository6(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository6: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NpmGroupRepositoryApiRequest**](NpmGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository7"></a>
# **CreateRepository7**
> void CreateRepository7 (NpmHostedRepositoryApiRequest body = null)

Create npm hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository7Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new NpmHostedRepositoryApiRequest(); // NpmHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create npm hosted repository
                apiInstance.CreateRepository7(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository7: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NpmHostedRepositoryApiRequest**](NpmHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository8"></a>
# **CreateRepository8**
> void CreateRepository8 (NpmProxyRepositoryApiRequest body = null)

Create npm proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository8Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new NpmProxyRepositoryApiRequest(); // NpmProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Create npm proxy repository
                apiInstance.CreateRepository8(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository8: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NpmProxyRepositoryApiRequest**](NpmProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrepository9"></a>
# **CreateRepository9**
> void CreateRepository9 (HelmHostedRepositoryApiRequest body = null)

Create Helm hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRepository9Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var body = new HelmHostedRepositoryApiRequest(); // HelmHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Create Helm hosted repository
                apiInstance.CreateRepository9(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.CreateRepository9: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HelmHostedRepositoryApiRequest**](HelmHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterepository"></a>
# **DeleteRepository**
> void DeleteRepository (string repositoryName)

Delete repository of any format

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteRepositoryExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to delete

            try
            {
                // Delete repository of any format
                apiInstance.DeleteRepository(repositoryName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.DeleteRepository: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablerepositoryhealthcheck"></a>
# **DisableRepositoryHealthCheck**
> void DisableRepositoryHealthCheck (string repositoryName)

Disable repository health check. Proxy repositories only.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DisableRepositoryHealthCheckExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to disable Repository Health Check for

            try
            {
                // Disable repository health check. Proxy repositories only.
                apiInstance.DisableRepositoryHealthCheck(repositoryName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.DisableRepositoryHealthCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to disable Repository Health Check for | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enablerepositoryhealthcheck"></a>
# **EnableRepositoryHealthCheck**
> void EnableRepositoryHealthCheck (string repositoryName)

Enable repository health check. Proxy repositories only.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class EnableRepositoryHealthCheckExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to enable Repository Health Check for

            try
            {
                // Enable repository health check. Proxy repositories only.
                apiInstance.EnableRepositoryHealthCheck(repositoryName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.EnableRepositoryHealthCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to enable Repository Health Check for | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepositories"></a>
# **GetRepositories**
> List<AbstractApiRepository> GetRepositories ()

List repositories

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepositoriesExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();

            try
            {
                // List repositories
                List&lt;AbstractApiRepository&gt; result = apiInstance.GetRepositories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepositories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AbstractApiRepository>**](AbstractApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepositories1"></a>
# **GetRepositories1**
> List<RepositoryXO> GetRepositories1 ()

List repositories

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepositories1Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();

            try
            {
                // List repositories
                List&lt;RepositoryXO&gt; result = apiInstance.GetRepositories1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepositories1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RepositoryXO>**](RepositoryXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository"></a>
# **GetRepository**
> SimpleApiGroupRepository GetRepository (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepositoryExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository1"></a>
# **GetRepository1**
> MavenHostedApiRepository GetRepository1 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository1Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                MavenHostedApiRepository result = apiInstance.GetRepository1(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**MavenHostedApiRepository**](MavenHostedApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository10"></a>
# **GetRepository10**
> SimpleApiProxyRepository GetRepository10 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository10Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository10(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository10: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository11"></a>
# **GetRepository11**
> SimpleApiGroupRepository GetRepository11 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository11Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository11(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository11: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository12"></a>
# **GetRepository12**
> SimpleApiHostedRepository GetRepository12 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository12Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository12(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository12: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository13"></a>
# **GetRepository13**
> SimpleApiProxyRepository GetRepository13 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository13Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository13(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository13: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository14"></a>
# **GetRepository14**
> SimpleApiGroupRepository GetRepository14 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository14Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository14(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository14: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository15"></a>
# **GetRepository15**
> SimpleApiHostedRepository GetRepository15 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository15Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository15(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository15: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository16"></a>
# **GetRepository16**
> NugetProxyApiRepository GetRepository16 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository16Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                NugetProxyApiRepository result = apiInstance.GetRepository16(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository16: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**NugetProxyApiRepository**](NugetProxyApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository17"></a>
# **GetRepository17**
> SimpleApiGroupRepository GetRepository17 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository17Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository17(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository17: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository18"></a>
# **GetRepository18**
> SimpleApiHostedRepository GetRepository18 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository18Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository18(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository18: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository19"></a>
# **GetRepository19**
> SimpleApiProxyRepository GetRepository19 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository19Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository19(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository19: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository2"></a>
# **GetRepository2**
> MavenProxyApiRepository GetRepository2 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository2Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                MavenProxyApiRepository result = apiInstance.GetRepository2(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**MavenProxyApiRepository**](MavenProxyApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository20"></a>
# **GetRepository20**
> DockerGroupApiRepository GetRepository20 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository20Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                DockerGroupApiRepository result = apiInstance.GetRepository20(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository20: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**DockerGroupApiRepository**](DockerGroupApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository21"></a>
# **GetRepository21**
> DockerHostedApiRepository GetRepository21 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository21Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                DockerHostedApiRepository result = apiInstance.GetRepository21(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository21: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**DockerHostedApiRepository**](DockerHostedApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository22"></a>
# **GetRepository22**
> DockerProxyApiRepository GetRepository22 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository22Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                DockerProxyApiRepository result = apiInstance.GetRepository22(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository22: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**DockerProxyApiRepository**](DockerProxyApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository23"></a>
# **GetRepository23**
> SimpleApiGroupRepository GetRepository23 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository23Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository23(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository23: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository24"></a>
# **GetRepository24**
> YumHostedApiRepository GetRepository24 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository24Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                YumHostedApiRepository result = apiInstance.GetRepository24(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository24: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**YumHostedApiRepository**](YumHostedApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository25"></a>
# **GetRepository25**
> SimpleApiProxyRepository GetRepository25 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository25Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository25(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository25: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository26"></a>
# **GetRepository26**
> AptHostedApiRepository GetRepository26 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository26Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                AptHostedApiRepository result = apiInstance.GetRepository26(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository26: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**AptHostedApiRepository**](AptHostedApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository27"></a>
# **GetRepository27**
> AptProxyApiRepository GetRepository27 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository27Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                AptProxyApiRepository result = apiInstance.GetRepository27(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository27: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**AptProxyApiRepository**](AptProxyApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository28"></a>
# **GetRepository28**
> SimpleApiProxyRepository GetRepository28 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository28Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository28(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository28: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository29"></a>
# **GetRepository29**
> SimpleApiProxyRepository GetRepository29 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository29Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository29(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository29: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository3"></a>
# **GetRepository3**
> SimpleApiGroupRepository GetRepository3 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository3Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository3(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository30"></a>
# **GetRepository30**
> SimpleApiProxyRepository GetRepository30 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository30Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository30(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository30: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository31"></a>
# **GetRepository31**
> SimpleApiGroupRepository GetRepository31 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository31Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository31(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository31: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository32"></a>
# **GetRepository32**
> SimpleApiProxyRepository GetRepository32 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository32Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository32(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository32: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository33"></a>
# **GetRepository33**
> SimpleApiProxyRepository GetRepository33 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository33Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository33(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository33: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository34"></a>
# **GetRepository34**
> SimpleApiGroupRepository GetRepository34 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository34Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository34(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository34: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository35"></a>
# **GetRepository35**
> SimpleApiHostedRepository GetRepository35 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository35Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository35(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository35: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository36"></a>
# **GetRepository36**
> SimpleApiProxyRepository GetRepository36 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository36Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository36(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository36: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository37"></a>
# **GetRepository37**
> SimpleApiGroupRepository GetRepository37 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository37Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupRepository result = apiInstance.GetRepository37(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository37: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupRepository**](SimpleApiGroupRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository38"></a>
# **GetRepository38**
> SimpleApiHostedRepository GetRepository38 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository38Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository38(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository38: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository39"></a>
# **GetRepository39**
> BowerProxyApiRepository GetRepository39 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository39Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                BowerProxyApiRepository result = apiInstance.GetRepository39(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository39: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**BowerProxyApiRepository**](BowerProxyApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository4"></a>
# **GetRepository4**
> SimpleApiHostedRepository GetRepository4 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository4Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository4(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository40"></a>
# **GetRepository40**
> SimpleApiHostedRepository GetRepository40 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository40Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository40(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository40: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository5"></a>
# **GetRepository5**
> SimpleApiProxyRepository GetRepository5 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository5Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiProxyRepository result = apiInstance.GetRepository5(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository5: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiProxyRepository**](SimpleApiProxyRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository6"></a>
# **GetRepository6**
> SimpleApiGroupDeployRepository GetRepository6 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository6Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiGroupDeployRepository result = apiInstance.GetRepository6(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository6: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiGroupDeployRepository**](SimpleApiGroupDeployRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository7"></a>
# **GetRepository7**
> SimpleApiHostedRepository GetRepository7 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository7Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository7(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository7: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository8"></a>
# **GetRepository8**
> NpmProxyApiRepository GetRepository8 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository8Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                NpmProxyApiRepository result = apiInstance.GetRepository8(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository8: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**NpmProxyApiRepository**](NpmProxyApiRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepository9"></a>
# **GetRepository9**
> SimpleApiHostedRepository GetRepository9 (string repositoryName)

Get repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRepository9Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | 

            try
            {
                // Get repository
                SimpleApiHostedRepository result = apiInstance.GetRepository9(repositoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.GetRepository9: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**|  | 

### Return type

[**SimpleApiHostedRepository**](SimpleApiHostedRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invalidatecache"></a>
# **InvalidateCache**
> void InvalidateCache (string repositoryName)

Invalidate repository cache. Proxy or group repositories only.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class InvalidateCacheExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to invalidate cache

            try
            {
                // Invalidate repository cache. Proxy or group repositories only.
                apiInstance.InvalidateCache(repositoryName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.InvalidateCache: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to invalidate cache | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rebuildindex"></a>
# **RebuildIndex**
> void RebuildIndex (string repositoryName)

Schedule a 'Repair - Rebuild repository search' Task. Hosted or proxy repositories only.

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class RebuildIndexExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to rebuild index

            try
            {
                // Schedule a 'Repair - Rebuild repository search' Task. Hosted or proxy repositories only.
                apiInstance.RebuildIndex(repositoryName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.RebuildIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to rebuild index | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository"></a>
# **UpdateRepository**
> void UpdateRepository (string repositoryName, MavenGroupRepositoryApiRequest body = null)

Update Maven group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepositoryExample
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new MavenGroupRepositoryApiRequest(); // MavenGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update Maven group repository
                apiInstance.UpdateRepository(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**MavenGroupRepositoryApiRequest**](MavenGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository1"></a>
# **UpdateRepository1**
> void UpdateRepository1 (string repositoryName, MavenHostedRepositoryApiRequest body = null)

Update Maven hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository1Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new MavenHostedRepositoryApiRequest(); // MavenHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update Maven hosted repository
                apiInstance.UpdateRepository1(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**MavenHostedRepositoryApiRequest**](MavenHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository10"></a>
# **UpdateRepository10**
> void UpdateRepository10 (string repositoryName, HelmProxyRepositoryApiRequest body = null)

Update Helm proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository10Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new HelmProxyRepositoryApiRequest(); // HelmProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update Helm proxy repository
                apiInstance.UpdateRepository10(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository10: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**HelmProxyRepositoryApiRequest**](HelmProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository11"></a>
# **UpdateRepository11**
> void UpdateRepository11 (string repositoryName, PypiGroupRepositoryApiRequest body = null)

Update PyPI group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository11Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new PypiGroupRepositoryApiRequest(); // PypiGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update PyPI group repository
                apiInstance.UpdateRepository11(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository11: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**PypiGroupRepositoryApiRequest**](PypiGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository12"></a>
# **UpdateRepository12**
> void UpdateRepository12 (string repositoryName, PypiHostedRepositoryApiRequest body = null)

Update PyPI hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository12Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new PypiHostedRepositoryApiRequest(); // PypiHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update PyPI hosted repository
                apiInstance.UpdateRepository12(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository12: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**PypiHostedRepositoryApiRequest**](PypiHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository13"></a>
# **UpdateRepository13**
> void UpdateRepository13 (string repositoryName, PypiProxyRepositoryApiRequest body = null)

Update PyPI proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository13Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new PypiProxyRepositoryApiRequest(); // PypiProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update PyPI proxy repository
                apiInstance.UpdateRepository13(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository13: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**PypiProxyRepositoryApiRequest**](PypiProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository14"></a>
# **UpdateRepository14**
> void UpdateRepository14 (string repositoryName, NugetGroupRepositoryApiRequest body = null)

Update NuGet group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository14Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new NugetGroupRepositoryApiRequest(); // NugetGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update NuGet group repository
                apiInstance.UpdateRepository14(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository14: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**NugetGroupRepositoryApiRequest**](NugetGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository15"></a>
# **UpdateRepository15**
> void UpdateRepository15 (string repositoryName, NugetHostedRepositoryApiRequest body = null)

Update NuGet hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository15Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new NugetHostedRepositoryApiRequest(); // NugetHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update NuGet hosted repository
                apiInstance.UpdateRepository15(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository15: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**NugetHostedRepositoryApiRequest**](NugetHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository16"></a>
# **UpdateRepository16**
> void UpdateRepository16 (string repositoryName, NugetProxyRepositoryApiRequest body = null)

Update NuGet proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository16Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new NugetProxyRepositoryApiRequest(); // NugetProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update NuGet proxy repository
                apiInstance.UpdateRepository16(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository16: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**NugetProxyRepositoryApiRequest**](NugetProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository17"></a>
# **UpdateRepository17**
> void UpdateRepository17 (string repositoryName, RubyGemsGroupRepositoryApiRequest body = null)

Update RubyGems group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository17Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RubyGemsGroupRepositoryApiRequest(); // RubyGemsGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update RubyGems group repository
                apiInstance.UpdateRepository17(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository17: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RubyGemsGroupRepositoryApiRequest**](RubyGemsGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository18"></a>
# **UpdateRepository18**
> void UpdateRepository18 (string repositoryName, RubyGemsHostedRepositoryApiRequest body = null)

Update RubyGems hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository18Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RubyGemsHostedRepositoryApiRequest(); // RubyGemsHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update RubyGems hosted repository
                apiInstance.UpdateRepository18(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository18: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RubyGemsHostedRepositoryApiRequest**](RubyGemsHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository19"></a>
# **UpdateRepository19**
> void UpdateRepository19 (string repositoryName, RubyGemsProxyRepositoryApiRequest body = null)

Update RubyGems proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository19Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RubyGemsProxyRepositoryApiRequest(); // RubyGemsProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update RubyGems proxy repository
                apiInstance.UpdateRepository19(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository19: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RubyGemsProxyRepositoryApiRequest**](RubyGemsProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository2"></a>
# **UpdateRepository2**
> void UpdateRepository2 (string repositoryName, MavenProxyRepositoryApiRequest body = null)

Update Maven proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository2Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new MavenProxyRepositoryApiRequest(); // MavenProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update Maven proxy repository
                apiInstance.UpdateRepository2(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**MavenProxyRepositoryApiRequest**](MavenProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository20"></a>
# **UpdateRepository20**
> void UpdateRepository20 (string repositoryName, DockerGroupRepositoryApiRequest body = null)

Update Docker group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository20Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new DockerGroupRepositoryApiRequest(); // DockerGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update Docker group repository
                apiInstance.UpdateRepository20(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository20: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**DockerGroupRepositoryApiRequest**](DockerGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository21"></a>
# **UpdateRepository21**
> void UpdateRepository21 (string repositoryName, DockerHostedRepositoryApiRequest body = null)

Update Docker hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository21Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new DockerHostedRepositoryApiRequest(); // DockerHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update Docker hosted repository
                apiInstance.UpdateRepository21(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository21: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**DockerHostedRepositoryApiRequest**](DockerHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository22"></a>
# **UpdateRepository22**
> void UpdateRepository22 (string repositoryName, DockerProxyRepositoryApiRequest body = null)

Update Docker group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository22Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new DockerProxyRepositoryApiRequest(); // DockerProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update Docker group repository
                apiInstance.UpdateRepository22(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository22: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**DockerProxyRepositoryApiRequest**](DockerProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository23"></a>
# **UpdateRepository23**
> void UpdateRepository23 (string repositoryName, YumGroupRepositoryApiRequest body = null)

Update Yum group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository23Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new YumGroupRepositoryApiRequest(); // YumGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update Yum group repository
                apiInstance.UpdateRepository23(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository23: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**YumGroupRepositoryApiRequest**](YumGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository24"></a>
# **UpdateRepository24**
> void UpdateRepository24 (string repositoryName, YumHostedRepositoryApiRequest body = null)

Update Yum hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository24Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new YumHostedRepositoryApiRequest(); // YumHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update Yum hosted repository
                apiInstance.UpdateRepository24(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository24: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**YumHostedRepositoryApiRequest**](YumHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository25"></a>
# **UpdateRepository25**
> void UpdateRepository25 (string repositoryName, YumProxyRepositoryApiRequest body = null)

Update Yum proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository25Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new YumProxyRepositoryApiRequest(); // YumProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update Yum proxy repository
                apiInstance.UpdateRepository25(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository25: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**YumProxyRepositoryApiRequest**](YumProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository26"></a>
# **UpdateRepository26**
> void UpdateRepository26 (string repositoryName, AptHostedRepositoryApiRequest body = null)

Update APT hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository26Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new AptHostedRepositoryApiRequest(); // AptHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update APT hosted repository
                apiInstance.UpdateRepository26(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository26: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**AptHostedRepositoryApiRequest**](AptHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository27"></a>
# **UpdateRepository27**
> void UpdateRepository27 (string repositoryName, AptProxyRepositoryApiRequest body = null)

Update APT proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository27Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new AptProxyRepositoryApiRequest(); // AptProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update APT proxy repository
                apiInstance.UpdateRepository27(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository27: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**AptProxyRepositoryApiRequest**](AptProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository28"></a>
# **UpdateRepository28**
> void UpdateRepository28 (string repositoryName, CocoapodsProxyRepositoryApiRequest body = null)

Update Cocoapods proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository28Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new CocoapodsProxyRepositoryApiRequest(); // CocoapodsProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update Cocoapods proxy repository
                apiInstance.UpdateRepository28(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository28: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**CocoapodsProxyRepositoryApiRequest**](CocoapodsProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository29"></a>
# **UpdateRepository29**
> void UpdateRepository29 (string repositoryName, ConanProxyRepositoryApiRequest body = null)

Update Conan proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository29Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new ConanProxyRepositoryApiRequest(); // ConanProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update Conan proxy repository
                apiInstance.UpdateRepository29(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository29: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**ConanProxyRepositoryApiRequest**](ConanProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository3"></a>
# **UpdateRepository3**
> void UpdateRepository3 (string repositoryName, RawGroupRepositoryApiRequest body = null)

Update raw group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository3Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RawGroupRepositoryApiRequest(); // RawGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update raw group repository
                apiInstance.UpdateRepository3(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RawGroupRepositoryApiRequest**](RawGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository30"></a>
# **UpdateRepository30**
> void UpdateRepository30 (string repositoryName, CondaProxyRepositoryApiRequest body = null)

Update conda proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository30Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new CondaProxyRepositoryApiRequest(); // CondaProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update conda proxy repository
                apiInstance.UpdateRepository30(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository30: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**CondaProxyRepositoryApiRequest**](CondaProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository31"></a>
# **UpdateRepository31**
> void UpdateRepository31 (string repositoryName, GolangGroupRepositoryApiRequest body = null)

Update a Go group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository31Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new GolangGroupRepositoryApiRequest(); // GolangGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update a Go group repository
                apiInstance.UpdateRepository31(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository31: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**GolangGroupRepositoryApiRequest**](GolangGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository32"></a>
# **UpdateRepository32**
> void UpdateRepository32 (string repositoryName, GolangProxyRepositoryApiRequest body = null)

Update a Go proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository32Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new GolangProxyRepositoryApiRequest(); // GolangProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update a Go proxy repository
                apiInstance.UpdateRepository32(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository32: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**GolangProxyRepositoryApiRequest**](GolangProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository33"></a>
# **UpdateRepository33**
> void UpdateRepository33 (string repositoryName, P2ProxyRepositoryApiRequest body = null)

Update p2 proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository33Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new P2ProxyRepositoryApiRequest(); // P2ProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update p2 proxy repository
                apiInstance.UpdateRepository33(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository33: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**P2ProxyRepositoryApiRequest**](P2ProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository34"></a>
# **UpdateRepository34**
> void UpdateRepository34 (string repositoryName, RGroupRepositoryApiRequest body = null)

Update R group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository34Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RGroupRepositoryApiRequest(); // RGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update R group repository
                apiInstance.UpdateRepository34(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository34: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RGroupRepositoryApiRequest**](RGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository35"></a>
# **UpdateRepository35**
> void UpdateRepository35 (string repositoryName, RHostedRepositoryApiRequest body = null)

Update R hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository35Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RHostedRepositoryApiRequest(); // RHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update R hosted repository
                apiInstance.UpdateRepository35(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository35: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RHostedRepositoryApiRequest**](RHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository36"></a>
# **UpdateRepository36**
> void UpdateRepository36 (string repositoryName, RProxyRepositoryApiRequest body = null)

Update R proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository36Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RProxyRepositoryApiRequest(); // RProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update R proxy repository
                apiInstance.UpdateRepository36(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository36: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RProxyRepositoryApiRequest**](RProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository37"></a>
# **UpdateRepository37**
> void UpdateRepository37 (string repositoryName, BowerGroupRepositoryApiRequest body = null)

Update Bower group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository37Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new BowerGroupRepositoryApiRequest(); // BowerGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update Bower group repository
                apiInstance.UpdateRepository37(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository37: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**BowerGroupRepositoryApiRequest**](BowerGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository38"></a>
# **UpdateRepository38**
> void UpdateRepository38 (string repositoryName, BowerHostedRepositoryApiRequest body = null)

Update Bower hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository38Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new BowerHostedRepositoryApiRequest(); // BowerHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update Bower hosted repository
                apiInstance.UpdateRepository38(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository38: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**BowerHostedRepositoryApiRequest**](BowerHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository39"></a>
# **UpdateRepository39**
> void UpdateRepository39 (string repositoryName, BowerProxyRepositoryApiRequest body = null)

Update Bower proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository39Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new BowerProxyRepositoryApiRequest(); // BowerProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update Bower proxy repository
                apiInstance.UpdateRepository39(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository39: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**BowerProxyRepositoryApiRequest**](BowerProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository4"></a>
# **UpdateRepository4**
> void UpdateRepository4 (string repositoryName, RawHostedRepositoryApiRequest body = null)

Update raw hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository4Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RawHostedRepositoryApiRequest(); // RawHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update raw hosted repository
                apiInstance.UpdateRepository4(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RawHostedRepositoryApiRequest**](RawHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository40"></a>
# **UpdateRepository40**
> void UpdateRepository40 (string repositoryName, GitLfsHostedRepositoryApiRequest body = null)

Update Git LFS hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository40Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new GitLfsHostedRepositoryApiRequest(); // GitLfsHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update Git LFS hosted repository
                apiInstance.UpdateRepository40(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository40: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**GitLfsHostedRepositoryApiRequest**](GitLfsHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository5"></a>
# **UpdateRepository5**
> void UpdateRepository5 (string repositoryName, RawProxyRepositoryApiRequest body = null)

Update raw proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository5Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new RawProxyRepositoryApiRequest(); // RawProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update raw proxy repository
                apiInstance.UpdateRepository5(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository5: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**RawProxyRepositoryApiRequest**](RawProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository6"></a>
# **UpdateRepository6**
> void UpdateRepository6 (string repositoryName, NpmGroupRepositoryApiRequest body = null)

Update npm group repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository6Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new NpmGroupRepositoryApiRequest(); // NpmGroupRepositoryApiRequest |  (optional) 

            try
            {
                // Update npm group repository
                apiInstance.UpdateRepository6(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository6: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**NpmGroupRepositoryApiRequest**](NpmGroupRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository7"></a>
# **UpdateRepository7**
> void UpdateRepository7 (string repositoryName, NpmHostedRepositoryApiRequest body = null)

Update npm hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository7Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new NpmHostedRepositoryApiRequest(); // NpmHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update npm hosted repository
                apiInstance.UpdateRepository7(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository7: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**NpmHostedRepositoryApiRequest**](NpmHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository8"></a>
# **UpdateRepository8**
> void UpdateRepository8 (string repositoryName, NpmProxyRepositoryApiRequest body = null)

Update npm proxy repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository8Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new NpmProxyRepositoryApiRequest(); // NpmProxyRepositoryApiRequest |  (optional) 

            try
            {
                // Update npm proxy repository
                apiInstance.UpdateRepository8(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository8: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**NpmProxyRepositoryApiRequest**](NpmProxyRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterepository9"></a>
# **UpdateRepository9**
> void UpdateRepository9 (string repositoryName, HelmHostedRepositoryApiRequest body = null)

Update Helm hosted repository

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRepository9Example
    {
        public void main()
        {
            var apiInstance = new RepositoryManagementApi();
            var repositoryName = repositoryName_example;  // string | Name of the repository to update
            var body = new HelmHostedRepositoryApiRequest(); // HelmHostedRepositoryApiRequest |  (optional) 

            try
            {
                // Update Helm hosted repository
                apiInstance.UpdateRepository9(repositoryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepositoryManagementApi.UpdateRepository9: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryName** | **string**| Name of the repository to update | 
 **body** | [**HelmHostedRepositoryApiRequest**](HelmHostedRepositoryApiRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

