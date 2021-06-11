# Bess.IO.Rest.Nexus3.Api.RoutingRulesApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRoutingRule**](RoutingRulesApi.md#createroutingrule) | **POST** /v1/routing-rules | Create a single routing rule
[**DeleteRoutingRule**](RoutingRulesApi.md#deleteroutingrule) | **DELETE** /v1/routing-rules/{name} | Delete a single routing rule
[**GetRoutingRule**](RoutingRulesApi.md#getroutingrule) | **GET** /v1/routing-rules/{name} | Get a single routing rule
[**GetRoutingRules**](RoutingRulesApi.md#getroutingrules) | **GET** /v1/routing-rules | List routing rules
[**UpdateRoutingRule**](RoutingRulesApi.md#updateroutingrule) | **PUT** /v1/routing-rules/{name} | Update a single routing rule


<a name="createroutingrule"></a>
# **CreateRoutingRule**
> void CreateRoutingRule (RoutingRuleXO body)

Create a single routing rule

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class CreateRoutingRuleExample
    {
        public void main()
        {
            var apiInstance = new RoutingRulesApi();
            var body = new RoutingRuleXO(); // RoutingRuleXO | A routing rule configuration

            try
            {
                // Create a single routing rule
                apiInstance.CreateRoutingRule(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingRulesApi.CreateRoutingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RoutingRuleXO**](RoutingRuleXO.md)| A routing rule configuration | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroutingrule"></a>
# **DeleteRoutingRule**
> void DeleteRoutingRule (string name)

Delete a single routing rule

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class DeleteRoutingRuleExample
    {
        public void main()
        {
            var apiInstance = new RoutingRulesApi();
            var name = name_example;  // string | The name of the routing rule to delete

            try
            {
                // Delete a single routing rule
                apiInstance.DeleteRoutingRule(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingRulesApi.DeleteRoutingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the routing rule to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroutingrule"></a>
# **GetRoutingRule**
> RoutingRuleXO GetRoutingRule (string name)

Get a single routing rule

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRoutingRuleExample
    {
        public void main()
        {
            var apiInstance = new RoutingRulesApi();
            var name = name_example;  // string | The name of the routing rule to get

            try
            {
                // Get a single routing rule
                RoutingRuleXO result = apiInstance.GetRoutingRule(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingRulesApi.GetRoutingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the routing rule to get | 

### Return type

[**RoutingRuleXO**](RoutingRuleXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroutingrules"></a>
# **GetRoutingRules**
> List<RoutingRuleXO> GetRoutingRules ()

List routing rules

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetRoutingRulesExample
    {
        public void main()
        {
            var apiInstance = new RoutingRulesApi();

            try
            {
                // List routing rules
                List&lt;RoutingRuleXO&gt; result = apiInstance.GetRoutingRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingRulesApi.GetRoutingRules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RoutingRuleXO>**](RoutingRuleXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateroutingrule"></a>
# **UpdateRoutingRule**
> void UpdateRoutingRule (string name, RoutingRuleXO body)

Update a single routing rule

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class UpdateRoutingRuleExample
    {
        public void main()
        {
            var apiInstance = new RoutingRulesApi();
            var name = name_example;  // string | The name of the routing rule to update
            var body = new RoutingRuleXO(); // RoutingRuleXO | A routing rule configuration

            try
            {
                // Update a single routing rule
                apiInstance.UpdateRoutingRule(name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingRulesApi.UpdateRoutingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the routing rule to update | 
 **body** | [**RoutingRuleXO**](RoutingRuleXO.md)| A routing rule configuration | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

