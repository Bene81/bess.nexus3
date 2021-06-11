# Bess.IO.Rest.Nexus3.Model.ReadLdapServerXo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | LDAP server name | 
**Protocol** | **string** | LDAP server connection Protocol to use | 
**UseTrustStore** | **bool?** | Whether to use certificates stored in Nexus Repository Manager&#39;s truststore | [optional] 
**Host** | **string** | LDAP server connection hostname | 
**Port** | **int?** | LDAP server connection port to use | 
**SearchBase** | **string** | LDAP location to be added to the connection URL | 
**AuthScheme** | **string** | Authentication scheme used for connecting to LDAP server | 
**AuthRealm** | **string** | The SASL realm to bind to. Required if authScheme is CRAM_MD5 or DIGEST_MD5 | [optional] 
**AuthUsername** | **string** | This must be a fully qualified username if simple authentication is used. Required if authScheme other than none. | [optional] 
**ConnectionTimeoutSeconds** | **int?** | How long to wait before timeout | 
**ConnectionRetryDelaySeconds** | **int?** | How long to wait before retrying | 
**MaxIncidentsCount** | **int?** | How many retry attempts | 
**UserBaseDn** | **string** | The relative DN where user objects are found (e.g. ou&#x3D;people). This value will have the Search base DN value appended to form the full User search base DN. | [optional] 
**UserSubtree** | **bool?** | Are users located in structures below the user base DN? | [optional] 
**UserObjectClass** | **string** | LDAP class for user objects | [optional] 
**UserLdapFilter** | **string** | LDAP search filter to limit user search | [optional] 
**UserIdAttribute** | **string** | This is used to find a user given its user ID | [optional] 
**UserRealNameAttribute** | **string** | This is used to find a real name given the user ID | [optional] 
**UserEmailAddressAttribute** | **string** | This is used to find an email address given the user ID | [optional] 
**UserPasswordAttribute** | **string** | If this field is blank the user will be authenticated against a bind with the LDAP server | [optional] 
**LdapGroupsAsRoles** | **bool?** | Denotes whether LDAP assigned roles are used as Nexus Repository Manager roles | [optional] 
**GroupType** | **string** | Defines a type of groups used: static (a group contains a list of users) or dynamic (a user contains a list of groups). Required if ldapGroupsAsRoles is true. | 
**GroupBaseDn** | **string** | The relative DN where group objects are found (e.g. ou&#x3D;Group). This value will have the Search base DN value appended to form the full Group search base DN. | [optional] 
**GroupSubtree** | **bool?** | Are groups located in structures below the group base DN | [optional] 
**GroupObjectClass** | **string** | LDAP class for group objects. Required if groupType is static | [optional] 
**GroupIdAttribute** | **string** | This field specifies the attribute of the Object class that defines the Group ID. Required if groupType is static | [optional] 
**GroupMemberAttribute** | **string** | LDAP attribute containing the usernames for the group. Required if groupType is static | [optional] 
**GroupMemberFormat** | **string** | The format of user ID stored in the group member attribute. Required if groupType is static | [optional] 
**UserMemberOfAttribute** | **string** | Set this to the attribute used to store the attribute which holds groups DN in the user object. Required if groupType is dynamic | [optional] 
**Id** | **string** | LDAP server ID | [optional] 
**Order** | **int?** | Order number in which the server is being used when looking for a user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

