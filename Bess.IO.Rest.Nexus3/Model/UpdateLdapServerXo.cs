/* 
 * Nexus Repository Manager REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.30.1-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Bess.IO.Rest.Nexus3.Client.SwaggerDateConverter;

namespace Bess.IO.Rest.Nexus3.Model
{
    /// <summary>
    /// UpdateLdapServerXo
    /// </summary>
    [DataContract]
    public partial class UpdateLdapServerXo :  IEquatable<UpdateLdapServerXo>
    {
        /// <summary>
        /// LDAP server connection Protocol to use
        /// </summary>
        /// <value>LDAP server connection Protocol to use</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            
            /// <summary>
            /// Enum Ldap for value: ldap
            /// </summary>
            [EnumMember(Value = "ldap")]
            Ldap = 1,
            
            /// <summary>
            /// Enum Ldaps for value: ldaps
            /// </summary>
            [EnumMember(Value = "ldaps")]
            Ldaps = 2
        }

        /// <summary>
        /// LDAP server connection Protocol to use
        /// </summary>
        /// <value>LDAP server connection Protocol to use</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// Authentication scheme used for connecting to LDAP server
        /// </summary>
        /// <value>Authentication scheme used for connecting to LDAP server</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthSchemeEnum
        {
            
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,
            
            /// <summary>
            /// Enum SIMPLE for value: SIMPLE
            /// </summary>
            [EnumMember(Value = "SIMPLE")]
            SIMPLE = 2,
            
            /// <summary>
            /// Enum DIGESTMD5 for value: DIGEST_MD5
            /// </summary>
            [EnumMember(Value = "DIGEST_MD5")]
            DIGESTMD5 = 3,
            
            /// <summary>
            /// Enum CRAMMD5 for value: CRAM_MD5
            /// </summary>
            [EnumMember(Value = "CRAM_MD5")]
            CRAMMD5 = 4
        }

        /// <summary>
        /// Authentication scheme used for connecting to LDAP server
        /// </summary>
        /// <value>Authentication scheme used for connecting to LDAP server</value>
        [DataMember(Name="authScheme", EmitDefaultValue=false)]
        public AuthSchemeEnum AuthScheme { get; set; }
        /// <summary>
        /// Defines a type of groups used: static (a group contains a list of users) or dynamic (a user contains a list of groups). Required if ldapGroupsAsRoles is true.
        /// </summary>
        /// <value>Defines a type of groups used: static (a group contains a list of users) or dynamic (a user contains a list of groups). Required if ldapGroupsAsRoles is true.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GroupTypeEnum
        {
            
            /// <summary>
            /// Enum Static for value: static
            /// </summary>
            [EnumMember(Value = "static")]
            Static = 1,
            
            /// <summary>
            /// Enum Dynamic for value: dynamic
            /// </summary>
            [EnumMember(Value = "dynamic")]
            Dynamic = 2
        }

        /// <summary>
        /// Defines a type of groups used: static (a group contains a list of users) or dynamic (a user contains a list of groups). Required if ldapGroupsAsRoles is true.
        /// </summary>
        /// <value>Defines a type of groups used: static (a group contains a list of users) or dynamic (a user contains a list of groups). Required if ldapGroupsAsRoles is true.</value>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public GroupTypeEnum GroupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLdapServerXo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateLdapServerXo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLdapServerXo" /> class.
        /// </summary>
        /// <param name="name">LDAP server name (required).</param>
        /// <param name="protocol">LDAP server connection Protocol to use (required).</param>
        /// <param name="useTrustStore">Whether to use certificates stored in Nexus Repository Manager&#39;s truststore.</param>
        /// <param name="host">LDAP server connection hostname (required).</param>
        /// <param name="port">LDAP server connection port to use (required).</param>
        /// <param name="searchBase">LDAP location to be added to the connection URL (required).</param>
        /// <param name="authScheme">Authentication scheme used for connecting to LDAP server (required).</param>
        /// <param name="authRealm">The SASL realm to bind to. Required if authScheme is CRAM_MD5 or DIGEST_MD5.</param>
        /// <param name="authUsername">This must be a fully qualified username if simple authentication is used. Required if authScheme other than none..</param>
        /// <param name="connectionTimeoutSeconds">How long to wait before timeout (required).</param>
        /// <param name="connectionRetryDelaySeconds">How long to wait before retrying (required).</param>
        /// <param name="maxIncidentsCount">How many retry attempts (required).</param>
        /// <param name="userBaseDn">The relative DN where user objects are found (e.g. ou&#x3D;people). This value will have the Search base DN value appended to form the full User search base DN..</param>
        /// <param name="userSubtree">Are users located in structures below the user base DN?.</param>
        /// <param name="userObjectClass">LDAP class for user objects.</param>
        /// <param name="userLdapFilter">LDAP search filter to limit user search.</param>
        /// <param name="userIdAttribute">This is used to find a user given its user ID.</param>
        /// <param name="userRealNameAttribute">This is used to find a real name given the user ID.</param>
        /// <param name="userEmailAddressAttribute">This is used to find an email address given the user ID.</param>
        /// <param name="userPasswordAttribute">If this field is blank the user will be authenticated against a bind with the LDAP server.</param>
        /// <param name="ldapGroupsAsRoles">Denotes whether LDAP assigned roles are used as Nexus Repository Manager roles.</param>
        /// <param name="groupType">Defines a type of groups used: static (a group contains a list of users) or dynamic (a user contains a list of groups). Required if ldapGroupsAsRoles is true. (required).</param>
        /// <param name="groupBaseDn">The relative DN where group objects are found (e.g. ou&#x3D;Group). This value will have the Search base DN value appended to form the full Group search base DN..</param>
        /// <param name="groupSubtree">Are groups located in structures below the group base DN.</param>
        /// <param name="groupObjectClass">LDAP class for group objects. Required if groupType is static.</param>
        /// <param name="groupIdAttribute">This field specifies the attribute of the Object class that defines the Group ID. Required if groupType is static.</param>
        /// <param name="groupMemberAttribute">LDAP attribute containing the usernames for the group. Required if groupType is static.</param>
        /// <param name="groupMemberFormat">The format of user ID stored in the group member attribute. Required if groupType is static.</param>
        /// <param name="userMemberOfAttribute">Set this to the attribute used to store the attribute which holds groups DN in the user object. Required if groupType is dynamic.</param>
        /// <param name="authPassword">The password to bind with. Required if authScheme other than none. (required).</param>
        /// <param name="id">LDAP server ID.</param>
        public UpdateLdapServerXo(string name = default(string), ProtocolEnum protocol = default(ProtocolEnum), bool? useTrustStore = default(bool?), string host = default(string), int? port = default(int?), string searchBase = default(string), AuthSchemeEnum authScheme = default(AuthSchemeEnum), string authRealm = default(string), string authUsername = default(string), int? connectionTimeoutSeconds = default(int?), int? connectionRetryDelaySeconds = default(int?), int? maxIncidentsCount = default(int?), string userBaseDn = default(string), bool? userSubtree = default(bool?), string userObjectClass = default(string), string userLdapFilter = default(string), string userIdAttribute = default(string), string userRealNameAttribute = default(string), string userEmailAddressAttribute = default(string), string userPasswordAttribute = default(string), bool? ldapGroupsAsRoles = default(bool?), GroupTypeEnum groupType = default(GroupTypeEnum), string groupBaseDn = default(string), bool? groupSubtree = default(bool?), string groupObjectClass = default(string), string groupIdAttribute = default(string), string groupMemberAttribute = default(string), string groupMemberFormat = default(string), string userMemberOfAttribute = default(string), string authPassword = default(string), string id = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "protocol" is required (not null)
            if (protocol == null)
            {
                throw new InvalidDataException("protocol is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.Protocol = protocol;
            }
            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new InvalidDataException("host is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.Host = host;
            }
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new InvalidDataException("port is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.Port = port;
            }
            // to ensure "searchBase" is required (not null)
            if (searchBase == null)
            {
                throw new InvalidDataException("searchBase is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.SearchBase = searchBase;
            }
            // to ensure "authScheme" is required (not null)
            if (authScheme == null)
            {
                throw new InvalidDataException("authScheme is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.AuthScheme = authScheme;
            }
            // to ensure "connectionTimeoutSeconds" is required (not null)
            if (connectionTimeoutSeconds == null)
            {
                throw new InvalidDataException("connectionTimeoutSeconds is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.ConnectionTimeoutSeconds = connectionTimeoutSeconds;
            }
            // to ensure "connectionRetryDelaySeconds" is required (not null)
            if (connectionRetryDelaySeconds == null)
            {
                throw new InvalidDataException("connectionRetryDelaySeconds is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.ConnectionRetryDelaySeconds = connectionRetryDelaySeconds;
            }
            // to ensure "maxIncidentsCount" is required (not null)
            if (maxIncidentsCount == null)
            {
                throw new InvalidDataException("maxIncidentsCount is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.MaxIncidentsCount = maxIncidentsCount;
            }
            // to ensure "groupType" is required (not null)
            if (groupType == null)
            {
                throw new InvalidDataException("groupType is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.GroupType = groupType;
            }
            // to ensure "authPassword" is required (not null)
            if (authPassword == null)
            {
                throw new InvalidDataException("authPassword is a required property for UpdateLdapServerXo and cannot be null");
            }
            else
            {
                this.AuthPassword = authPassword;
            }
            this.UseTrustStore = useTrustStore;
            this.AuthRealm = authRealm;
            this.AuthUsername = authUsername;
            this.UserBaseDn = userBaseDn;
            this.UserSubtree = userSubtree;
            this.UserObjectClass = userObjectClass;
            this.UserLdapFilter = userLdapFilter;
            this.UserIdAttribute = userIdAttribute;
            this.UserRealNameAttribute = userRealNameAttribute;
            this.UserEmailAddressAttribute = userEmailAddressAttribute;
            this.UserPasswordAttribute = userPasswordAttribute;
            this.LdapGroupsAsRoles = ldapGroupsAsRoles;
            this.GroupBaseDn = groupBaseDn;
            this.GroupSubtree = groupSubtree;
            this.GroupObjectClass = groupObjectClass;
            this.GroupIdAttribute = groupIdAttribute;
            this.GroupMemberAttribute = groupMemberAttribute;
            this.GroupMemberFormat = groupMemberFormat;
            this.UserMemberOfAttribute = userMemberOfAttribute;
            this.Id = id;
        }
        
        /// <summary>
        /// LDAP server name
        /// </summary>
        /// <value>LDAP server name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Whether to use certificates stored in Nexus Repository Manager&#39;s truststore
        /// </summary>
        /// <value>Whether to use certificates stored in Nexus Repository Manager&#39;s truststore</value>
        [DataMember(Name="useTrustStore", EmitDefaultValue=false)]
        public bool? UseTrustStore { get; set; }

        /// <summary>
        /// LDAP server connection hostname
        /// </summary>
        /// <value>LDAP server connection hostname</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// LDAP server connection port to use
        /// </summary>
        /// <value>LDAP server connection port to use</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// LDAP location to be added to the connection URL
        /// </summary>
        /// <value>LDAP location to be added to the connection URL</value>
        [DataMember(Name="searchBase", EmitDefaultValue=false)]
        public string SearchBase { get; set; }


        /// <summary>
        /// The SASL realm to bind to. Required if authScheme is CRAM_MD5 or DIGEST_MD5
        /// </summary>
        /// <value>The SASL realm to bind to. Required if authScheme is CRAM_MD5 or DIGEST_MD5</value>
        [DataMember(Name="authRealm", EmitDefaultValue=false)]
        public string AuthRealm { get; set; }

        /// <summary>
        /// This must be a fully qualified username if simple authentication is used. Required if authScheme other than none.
        /// </summary>
        /// <value>This must be a fully qualified username if simple authentication is used. Required if authScheme other than none.</value>
        [DataMember(Name="authUsername", EmitDefaultValue=false)]
        public string AuthUsername { get; set; }

        /// <summary>
        /// How long to wait before timeout
        /// </summary>
        /// <value>How long to wait before timeout</value>
        [DataMember(Name="connectionTimeoutSeconds", EmitDefaultValue=false)]
        public int? ConnectionTimeoutSeconds { get; set; }

        /// <summary>
        /// How long to wait before retrying
        /// </summary>
        /// <value>How long to wait before retrying</value>
        [DataMember(Name="connectionRetryDelaySeconds", EmitDefaultValue=false)]
        public int? ConnectionRetryDelaySeconds { get; set; }

        /// <summary>
        /// How many retry attempts
        /// </summary>
        /// <value>How many retry attempts</value>
        [DataMember(Name="maxIncidentsCount", EmitDefaultValue=false)]
        public int? MaxIncidentsCount { get; set; }

        /// <summary>
        /// The relative DN where user objects are found (e.g. ou&#x3D;people). This value will have the Search base DN value appended to form the full User search base DN.
        /// </summary>
        /// <value>The relative DN where user objects are found (e.g. ou&#x3D;people). This value will have the Search base DN value appended to form the full User search base DN.</value>
        [DataMember(Name="userBaseDn", EmitDefaultValue=false)]
        public string UserBaseDn { get; set; }

        /// <summary>
        /// Are users located in structures below the user base DN?
        /// </summary>
        /// <value>Are users located in structures below the user base DN?</value>
        [DataMember(Name="userSubtree", EmitDefaultValue=false)]
        public bool? UserSubtree { get; set; }

        /// <summary>
        /// LDAP class for user objects
        /// </summary>
        /// <value>LDAP class for user objects</value>
        [DataMember(Name="userObjectClass", EmitDefaultValue=false)]
        public string UserObjectClass { get; set; }

        /// <summary>
        /// LDAP search filter to limit user search
        /// </summary>
        /// <value>LDAP search filter to limit user search</value>
        [DataMember(Name="userLdapFilter", EmitDefaultValue=false)]
        public string UserLdapFilter { get; set; }

        /// <summary>
        /// This is used to find a user given its user ID
        /// </summary>
        /// <value>This is used to find a user given its user ID</value>
        [DataMember(Name="userIdAttribute", EmitDefaultValue=false)]
        public string UserIdAttribute { get; set; }

        /// <summary>
        /// This is used to find a real name given the user ID
        /// </summary>
        /// <value>This is used to find a real name given the user ID</value>
        [DataMember(Name="userRealNameAttribute", EmitDefaultValue=false)]
        public string UserRealNameAttribute { get; set; }

        /// <summary>
        /// This is used to find an email address given the user ID
        /// </summary>
        /// <value>This is used to find an email address given the user ID</value>
        [DataMember(Name="userEmailAddressAttribute", EmitDefaultValue=false)]
        public string UserEmailAddressAttribute { get; set; }

        /// <summary>
        /// If this field is blank the user will be authenticated against a bind with the LDAP server
        /// </summary>
        /// <value>If this field is blank the user will be authenticated against a bind with the LDAP server</value>
        [DataMember(Name="userPasswordAttribute", EmitDefaultValue=false)]
        public string UserPasswordAttribute { get; set; }

        /// <summary>
        /// Denotes whether LDAP assigned roles are used as Nexus Repository Manager roles
        /// </summary>
        /// <value>Denotes whether LDAP assigned roles are used as Nexus Repository Manager roles</value>
        [DataMember(Name="ldapGroupsAsRoles", EmitDefaultValue=false)]
        public bool? LdapGroupsAsRoles { get; set; }


        /// <summary>
        /// The relative DN where group objects are found (e.g. ou&#x3D;Group). This value will have the Search base DN value appended to form the full Group search base DN.
        /// </summary>
        /// <value>The relative DN where group objects are found (e.g. ou&#x3D;Group). This value will have the Search base DN value appended to form the full Group search base DN.</value>
        [DataMember(Name="groupBaseDn", EmitDefaultValue=false)]
        public string GroupBaseDn { get; set; }

        /// <summary>
        /// Are groups located in structures below the group base DN
        /// </summary>
        /// <value>Are groups located in structures below the group base DN</value>
        [DataMember(Name="groupSubtree", EmitDefaultValue=false)]
        public bool? GroupSubtree { get; set; }

        /// <summary>
        /// LDAP class for group objects. Required if groupType is static
        /// </summary>
        /// <value>LDAP class for group objects. Required if groupType is static</value>
        [DataMember(Name="groupObjectClass", EmitDefaultValue=false)]
        public string GroupObjectClass { get; set; }

        /// <summary>
        /// This field specifies the attribute of the Object class that defines the Group ID. Required if groupType is static
        /// </summary>
        /// <value>This field specifies the attribute of the Object class that defines the Group ID. Required if groupType is static</value>
        [DataMember(Name="groupIdAttribute", EmitDefaultValue=false)]
        public string GroupIdAttribute { get; set; }

        /// <summary>
        /// LDAP attribute containing the usernames for the group. Required if groupType is static
        /// </summary>
        /// <value>LDAP attribute containing the usernames for the group. Required if groupType is static</value>
        [DataMember(Name="groupMemberAttribute", EmitDefaultValue=false)]
        public string GroupMemberAttribute { get; set; }

        /// <summary>
        /// The format of user ID stored in the group member attribute. Required if groupType is static
        /// </summary>
        /// <value>The format of user ID stored in the group member attribute. Required if groupType is static</value>
        [DataMember(Name="groupMemberFormat", EmitDefaultValue=false)]
        public string GroupMemberFormat { get; set; }

        /// <summary>
        /// Set this to the attribute used to store the attribute which holds groups DN in the user object. Required if groupType is dynamic
        /// </summary>
        /// <value>Set this to the attribute used to store the attribute which holds groups DN in the user object. Required if groupType is dynamic</value>
        [DataMember(Name="userMemberOfAttribute", EmitDefaultValue=false)]
        public string UserMemberOfAttribute { get; set; }

        /// <summary>
        /// The password to bind with. Required if authScheme other than none.
        /// </summary>
        /// <value>The password to bind with. Required if authScheme other than none.</value>
        [DataMember(Name="authPassword", EmitDefaultValue=false)]
        public string AuthPassword { get; set; }

        /// <summary>
        /// LDAP server ID
        /// </summary>
        /// <value>LDAP server ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLdapServerXo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  UseTrustStore: ").Append(UseTrustStore).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SearchBase: ").Append(SearchBase).Append("\n");
            sb.Append("  AuthScheme: ").Append(AuthScheme).Append("\n");
            sb.Append("  AuthRealm: ").Append(AuthRealm).Append("\n");
            sb.Append("  AuthUsername: ").Append(AuthUsername).Append("\n");
            sb.Append("  ConnectionTimeoutSeconds: ").Append(ConnectionTimeoutSeconds).Append("\n");
            sb.Append("  ConnectionRetryDelaySeconds: ").Append(ConnectionRetryDelaySeconds).Append("\n");
            sb.Append("  MaxIncidentsCount: ").Append(MaxIncidentsCount).Append("\n");
            sb.Append("  UserBaseDn: ").Append(UserBaseDn).Append("\n");
            sb.Append("  UserSubtree: ").Append(UserSubtree).Append("\n");
            sb.Append("  UserObjectClass: ").Append(UserObjectClass).Append("\n");
            sb.Append("  UserLdapFilter: ").Append(UserLdapFilter).Append("\n");
            sb.Append("  UserIdAttribute: ").Append(UserIdAttribute).Append("\n");
            sb.Append("  UserRealNameAttribute: ").Append(UserRealNameAttribute).Append("\n");
            sb.Append("  UserEmailAddressAttribute: ").Append(UserEmailAddressAttribute).Append("\n");
            sb.Append("  UserPasswordAttribute: ").Append(UserPasswordAttribute).Append("\n");
            sb.Append("  LdapGroupsAsRoles: ").Append(LdapGroupsAsRoles).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  GroupBaseDn: ").Append(GroupBaseDn).Append("\n");
            sb.Append("  GroupSubtree: ").Append(GroupSubtree).Append("\n");
            sb.Append("  GroupObjectClass: ").Append(GroupObjectClass).Append("\n");
            sb.Append("  GroupIdAttribute: ").Append(GroupIdAttribute).Append("\n");
            sb.Append("  GroupMemberAttribute: ").Append(GroupMemberAttribute).Append("\n");
            sb.Append("  GroupMemberFormat: ").Append(GroupMemberFormat).Append("\n");
            sb.Append("  UserMemberOfAttribute: ").Append(UserMemberOfAttribute).Append("\n");
            sb.Append("  AuthPassword: ").Append(AuthPassword).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLdapServerXo);
        }

        /// <summary>
        /// Returns true if UpdateLdapServerXo instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLdapServerXo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLdapServerXo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.UseTrustStore == input.UseTrustStore ||
                    (this.UseTrustStore != null &&
                    this.UseTrustStore.Equals(input.UseTrustStore))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.SearchBase == input.SearchBase ||
                    (this.SearchBase != null &&
                    this.SearchBase.Equals(input.SearchBase))
                ) && 
                (
                    this.AuthScheme == input.AuthScheme ||
                    (this.AuthScheme != null &&
                    this.AuthScheme.Equals(input.AuthScheme))
                ) && 
                (
                    this.AuthRealm == input.AuthRealm ||
                    (this.AuthRealm != null &&
                    this.AuthRealm.Equals(input.AuthRealm))
                ) && 
                (
                    this.AuthUsername == input.AuthUsername ||
                    (this.AuthUsername != null &&
                    this.AuthUsername.Equals(input.AuthUsername))
                ) && 
                (
                    this.ConnectionTimeoutSeconds == input.ConnectionTimeoutSeconds ||
                    (this.ConnectionTimeoutSeconds != null &&
                    this.ConnectionTimeoutSeconds.Equals(input.ConnectionTimeoutSeconds))
                ) && 
                (
                    this.ConnectionRetryDelaySeconds == input.ConnectionRetryDelaySeconds ||
                    (this.ConnectionRetryDelaySeconds != null &&
                    this.ConnectionRetryDelaySeconds.Equals(input.ConnectionRetryDelaySeconds))
                ) && 
                (
                    this.MaxIncidentsCount == input.MaxIncidentsCount ||
                    (this.MaxIncidentsCount != null &&
                    this.MaxIncidentsCount.Equals(input.MaxIncidentsCount))
                ) && 
                (
                    this.UserBaseDn == input.UserBaseDn ||
                    (this.UserBaseDn != null &&
                    this.UserBaseDn.Equals(input.UserBaseDn))
                ) && 
                (
                    this.UserSubtree == input.UserSubtree ||
                    (this.UserSubtree != null &&
                    this.UserSubtree.Equals(input.UserSubtree))
                ) && 
                (
                    this.UserObjectClass == input.UserObjectClass ||
                    (this.UserObjectClass != null &&
                    this.UserObjectClass.Equals(input.UserObjectClass))
                ) && 
                (
                    this.UserLdapFilter == input.UserLdapFilter ||
                    (this.UserLdapFilter != null &&
                    this.UserLdapFilter.Equals(input.UserLdapFilter))
                ) && 
                (
                    this.UserIdAttribute == input.UserIdAttribute ||
                    (this.UserIdAttribute != null &&
                    this.UserIdAttribute.Equals(input.UserIdAttribute))
                ) && 
                (
                    this.UserRealNameAttribute == input.UserRealNameAttribute ||
                    (this.UserRealNameAttribute != null &&
                    this.UserRealNameAttribute.Equals(input.UserRealNameAttribute))
                ) && 
                (
                    this.UserEmailAddressAttribute == input.UserEmailAddressAttribute ||
                    (this.UserEmailAddressAttribute != null &&
                    this.UserEmailAddressAttribute.Equals(input.UserEmailAddressAttribute))
                ) && 
                (
                    this.UserPasswordAttribute == input.UserPasswordAttribute ||
                    (this.UserPasswordAttribute != null &&
                    this.UserPasswordAttribute.Equals(input.UserPasswordAttribute))
                ) && 
                (
                    this.LdapGroupsAsRoles == input.LdapGroupsAsRoles ||
                    (this.LdapGroupsAsRoles != null &&
                    this.LdapGroupsAsRoles.Equals(input.LdapGroupsAsRoles))
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.GroupBaseDn == input.GroupBaseDn ||
                    (this.GroupBaseDn != null &&
                    this.GroupBaseDn.Equals(input.GroupBaseDn))
                ) && 
                (
                    this.GroupSubtree == input.GroupSubtree ||
                    (this.GroupSubtree != null &&
                    this.GroupSubtree.Equals(input.GroupSubtree))
                ) && 
                (
                    this.GroupObjectClass == input.GroupObjectClass ||
                    (this.GroupObjectClass != null &&
                    this.GroupObjectClass.Equals(input.GroupObjectClass))
                ) && 
                (
                    this.GroupIdAttribute == input.GroupIdAttribute ||
                    (this.GroupIdAttribute != null &&
                    this.GroupIdAttribute.Equals(input.GroupIdAttribute))
                ) && 
                (
                    this.GroupMemberAttribute == input.GroupMemberAttribute ||
                    (this.GroupMemberAttribute != null &&
                    this.GroupMemberAttribute.Equals(input.GroupMemberAttribute))
                ) && 
                (
                    this.GroupMemberFormat == input.GroupMemberFormat ||
                    (this.GroupMemberFormat != null &&
                    this.GroupMemberFormat.Equals(input.GroupMemberFormat))
                ) && 
                (
                    this.UserMemberOfAttribute == input.UserMemberOfAttribute ||
                    (this.UserMemberOfAttribute != null &&
                    this.UserMemberOfAttribute.Equals(input.UserMemberOfAttribute))
                ) && 
                (
                    this.AuthPassword == input.AuthPassword ||
                    (this.AuthPassword != null &&
                    this.AuthPassword.Equals(input.AuthPassword))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.UseTrustStore != null)
                    hashCode = hashCode * 59 + this.UseTrustStore.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.SearchBase != null)
                    hashCode = hashCode * 59 + this.SearchBase.GetHashCode();
                if (this.AuthScheme != null)
                    hashCode = hashCode * 59 + this.AuthScheme.GetHashCode();
                if (this.AuthRealm != null)
                    hashCode = hashCode * 59 + this.AuthRealm.GetHashCode();
                if (this.AuthUsername != null)
                    hashCode = hashCode * 59 + this.AuthUsername.GetHashCode();
                if (this.ConnectionTimeoutSeconds != null)
                    hashCode = hashCode * 59 + this.ConnectionTimeoutSeconds.GetHashCode();
                if (this.ConnectionRetryDelaySeconds != null)
                    hashCode = hashCode * 59 + this.ConnectionRetryDelaySeconds.GetHashCode();
                if (this.MaxIncidentsCount != null)
                    hashCode = hashCode * 59 + this.MaxIncidentsCount.GetHashCode();
                if (this.UserBaseDn != null)
                    hashCode = hashCode * 59 + this.UserBaseDn.GetHashCode();
                if (this.UserSubtree != null)
                    hashCode = hashCode * 59 + this.UserSubtree.GetHashCode();
                if (this.UserObjectClass != null)
                    hashCode = hashCode * 59 + this.UserObjectClass.GetHashCode();
                if (this.UserLdapFilter != null)
                    hashCode = hashCode * 59 + this.UserLdapFilter.GetHashCode();
                if (this.UserIdAttribute != null)
                    hashCode = hashCode * 59 + this.UserIdAttribute.GetHashCode();
                if (this.UserRealNameAttribute != null)
                    hashCode = hashCode * 59 + this.UserRealNameAttribute.GetHashCode();
                if (this.UserEmailAddressAttribute != null)
                    hashCode = hashCode * 59 + this.UserEmailAddressAttribute.GetHashCode();
                if (this.UserPasswordAttribute != null)
                    hashCode = hashCode * 59 + this.UserPasswordAttribute.GetHashCode();
                if (this.LdapGroupsAsRoles != null)
                    hashCode = hashCode * 59 + this.LdapGroupsAsRoles.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.GroupBaseDn != null)
                    hashCode = hashCode * 59 + this.GroupBaseDn.GetHashCode();
                if (this.GroupSubtree != null)
                    hashCode = hashCode * 59 + this.GroupSubtree.GetHashCode();
                if (this.GroupObjectClass != null)
                    hashCode = hashCode * 59 + this.GroupObjectClass.GetHashCode();
                if (this.GroupIdAttribute != null)
                    hashCode = hashCode * 59 + this.GroupIdAttribute.GetHashCode();
                if (this.GroupMemberAttribute != null)
                    hashCode = hashCode * 59 + this.GroupMemberAttribute.GetHashCode();
                if (this.GroupMemberFormat != null)
                    hashCode = hashCode * 59 + this.GroupMemberFormat.GetHashCode();
                if (this.UserMemberOfAttribute != null)
                    hashCode = hashCode * 59 + this.UserMemberOfAttribute.GetHashCode();
                if (this.AuthPassword != null)
                    hashCode = hashCode * 59 + this.AuthPassword.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }

}
