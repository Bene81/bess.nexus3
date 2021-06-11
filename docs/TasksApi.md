# Bess.IO.Rest.Nexus3.Api.TasksApi

All URIs are relative to *https://localhost/service/rest/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTaskById**](TasksApi.md#gettaskbyid) | **GET** /v1/tasks/{id} | Get a single task by id
[**GetTasks**](TasksApi.md#gettasks) | **GET** /v1/tasks | List tasks
[**Run**](TasksApi.md#run) | **POST** /v1/tasks/{id}/run | Run task
[**Stop**](TasksApi.md#stop) | **POST** /v1/tasks/{id}/stop | Stop task


<a name="gettaskbyid"></a>
# **GetTaskById**
> TaskXO GetTaskById (string id)

Get a single task by id

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetTaskByIdExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var id = id_example;  // string | Id of the task to get

            try
            {
                // Get a single task by id
                TaskXO result = apiInstance.GetTaskById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the task to get | 

### Return type

[**TaskXO**](TaskXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> PageTaskXO GetTasks (string type = null)

List tasks

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var type = type_example;  // string | Type of the tasks to get (optional) 

            try
            {
                // List tasks
                PageTaskXO result = apiInstance.GetTasks(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of the tasks to get | [optional] 

### Return type

[**PageTaskXO**](PageTaskXO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="run"></a>
# **Run**
> void Run (string id)

Run task

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class RunExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var id = id_example;  // string | Id of the task to run

            try
            {
                // Run task
                apiInstance.Run(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.Run: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the task to run | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stop"></a>
# **Stop**
> void Stop (string id)

Stop task

### Example
```csharp
using System;
using System.Diagnostics;
using Bess.IO.Rest.Nexus3.Api;
using Bess.IO.Rest.Nexus3.Client;
using Bess.IO.Rest.Nexus3.Model;

namespace Example
{
    public class StopExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var id = id_example;  // string | Id of the task to stop

            try
            {
                // Stop task
                apiInstance.Stop(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.Stop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the task to stop | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

