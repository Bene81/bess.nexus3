# Bess.IO.Rest.Nexus3.Model.ApiPrivilegeRepositoryViewRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the privilege.  This value cannot be changed. | [optional] 
**Description** | **string** |  | [optional] 
**Actions** | **List&lt;string&gt;** | A collection of actions to associate with the privilege, using BREAD syntax (browse,read,edit,add,delete,all) as well as &#39;run&#39; for script privileges. | [optional] 
**Format** | **string** | The repository format (i.e &#39;nuget&#39;, &#39;npm&#39;) this privilege will grant access to (or * for all). | [optional] 
**Repository** | **string** | The name of the repository this privilege will grant access to (or * for all). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

