# Bess.IO.Rest.Nexus3.Api.ScriptApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](ScriptApi.md#add) | **POST** /v1/script | Add a new script
[**Browse**](ScriptApi.md#browse) | **GET** /v1/script | List all stored scripts
[**Delete1**](ScriptApi.md#delete1) | **DELETE** /v1/script/{name} | Delete stored script by name
[**Edit**](ScriptApi.md#edit) | **PUT** /v1/script/{name} | Update stored script by name
[**Read1**](ScriptApi.md#read1) | **GET** /v1/script/{name} | Read stored script by name
[**Run1**](ScriptApi.md#run1) | **POST** /v1/script/{name}/run | Run stored script by name


<a name="add"></a>
# **Add**
> void Add (ScriptXO body = null)

Add a new script

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class AddExample
    {
        public void main()
        {
            var apiInstance = new ScriptApi();
            var body = new ScriptXO(); // ScriptXO |  (optional) 

            try
            {
                // Add a new script
                apiInstance.Add(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptApi.Add: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ScriptXO**](ScriptXO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="browse"></a>
# **Browse**
> List<ScriptXO> Browse ()

List all stored scripts

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class BrowseExample
    {
        public void main()
        {
            var apiInstance = new ScriptApi();

            try
            {
                // List all stored scripts
                List&lt;ScriptXO&gt; result = apiInstance.Browse();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptApi.Browse: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ScriptXO>**](ScriptXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete1"></a>
# **Delete1**
> void Delete1 (string name)

Delete stored script by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class Delete1Example
    {
        public void main()
        {
            var apiInstance = new ScriptApi();
            var name = name_example;  // string | 

            try
            {
                // Delete stored script by name
                apiInstance.Delete1(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptApi.Delete1: " + e.Message );
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

<a name="edit"></a>
# **Edit**
> void Edit (string name, ScriptXO body = null)

Update stored script by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class EditExample
    {
        public void main()
        {
            var apiInstance = new ScriptApi();
            var name = name_example;  // string | 
            var body = new ScriptXO(); // ScriptXO |  (optional) 

            try
            {
                // Update stored script by name
                apiInstance.Edit(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptApi.Edit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **body** | [**ScriptXO**](ScriptXO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="read1"></a>
# **Read1**
> ScriptXO Read1 (string name)

Read stored script by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class Read1Example
    {
        public void main()
        {
            var apiInstance = new ScriptApi();
            var name = name_example;  // string | 

            try
            {
                // Read stored script by name
                ScriptXO result = apiInstance.Read1(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptApi.Read1: " + e.Message );
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

[**ScriptXO**](ScriptXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="run1"></a>
# **Run1**
> ScriptResultXO Run1 (string name, string body = null)

Run stored script by name

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class Run1Example
    {
        public void main()
        {
            var apiInstance = new ScriptApi();
            var name = name_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                // Run stored script by name
                ScriptResultXO result = apiInstance.Run1(name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptApi.Run1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

[**ScriptResultXO**](ScriptResultXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

