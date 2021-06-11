# Bess.IO.Rest.Nexus3.Model.MavenProxyRepositoryApiRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A unique identifier for this repository | 
**Online** | **bool?** | Whether this repository accepts incoming requests | 
**Storage** | [**StorageAttributes**](StorageAttributes.md) |  | 
**Cleanup** | [**CleanupPolicyAttributes**](CleanupPolicyAttributes.md) |  | [optional] 
**Proxy** | [**ProxyAttributes**](ProxyAttributes.md) |  | 
**NegativeCache** | [**NegativeCacheAttributes**](NegativeCacheAttributes.md) |  | 
**HttpClient** | [**HttpClientAttributesWithPreemptiveAuth**](HttpClientAttributesWithPreemptiveAuth.md) |  | 
**RoutingRule** | **string** |  | [optional] 
**Maven** | [**MavenAttributes**](MavenAttributes.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

