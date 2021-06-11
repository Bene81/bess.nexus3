# Bess.IO.Rest.Nexus3.Model.HttpClientConnectionAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Retries** | **int?** | Total retries if the initial connection attempt suffers a timeout | [optional] 
**UserAgentSuffix** | **string** | Custom fragment to append to User-Agent header in HTTP requests | [optional] 
**Timeout** | **int?** | Seconds to wait for activity before stopping and retrying the connection | [optional] 
**EnableCircularRedirects** | **bool?** | Whether to enable redirects to the same location (may be required by some servers) | [optional] 
**EnableCookies** | **bool?** | Whether to allow cookies to be stored and used | [optional] 
**UseTrustStore** | **bool?** | Use certificates stored in the Nexus Repository Manager truststore to connect to external systems | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

