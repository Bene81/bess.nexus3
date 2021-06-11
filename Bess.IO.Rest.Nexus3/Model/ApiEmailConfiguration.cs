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
    /// ApiEmailConfiguration
    /// </summary>
    [DataContract]
    public partial class ApiEmailConfiguration :  IEquatable<ApiEmailConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiEmailConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiEmailConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiEmailConfiguration" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="host">host.</param>
        /// <param name="port">port (required).</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="fromAddress">fromAddress.</param>
        /// <param name="subjectPrefix">A prefix to add to all email subjects to aid in identifying automated emails.</param>
        /// <param name="startTlsEnabled">Enable STARTTLS Support for Insecure Connections.</param>
        /// <param name="startTlsRequired">Require STARTTLS Support.</param>
        /// <param name="sslOnConnectEnabled">Enable SSL/TLS Encryption upon Connection.</param>
        /// <param name="sslServerIdentityCheckEnabled">Verify the server certificate when using TLS or SSL.</param>
        /// <param name="nexusTrustStoreEnabled">Use the Nexus Repository Manager&#39;s certificate truststore.</param>
        public ApiEmailConfiguration(bool? enabled = default(bool?), string host = default(string), int? port = default(int?), string username = default(string), string password = default(string), string fromAddress = default(string), string subjectPrefix = default(string), bool? startTlsEnabled = default(bool?), bool? startTlsRequired = default(bool?), bool? sslOnConnectEnabled = default(bool?), bool? sslServerIdentityCheckEnabled = default(bool?), bool? nexusTrustStoreEnabled = default(bool?))
        {
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new InvalidDataException("port is a required property for ApiEmailConfiguration and cannot be null");
            }
            else
            {
                this.Port = port;
            }
            this.Enabled = enabled;
            this.Host = host;
            this.Username = username;
            this.Password = password;
            this.FromAddress = fromAddress;
            this.SubjectPrefix = subjectPrefix;
            this.StartTlsEnabled = startTlsEnabled;
            this.StartTlsRequired = startTlsRequired;
            this.SslOnConnectEnabled = sslOnConnectEnabled;
            this.SslServerIdentityCheckEnabled = sslServerIdentityCheckEnabled;
            this.NexusTrustStoreEnabled = nexusTrustStoreEnabled;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }

        /// <summary>
        /// A prefix to add to all email subjects to aid in identifying automated emails
        /// </summary>
        /// <value>A prefix to add to all email subjects to aid in identifying automated emails</value>
        [DataMember(Name="subjectPrefix", EmitDefaultValue=false)]
        public string SubjectPrefix { get; set; }

        /// <summary>
        /// Enable STARTTLS Support for Insecure Connections
        /// </summary>
        /// <value>Enable STARTTLS Support for Insecure Connections</value>
        [DataMember(Name="startTlsEnabled", EmitDefaultValue=false)]
        public bool? StartTlsEnabled { get; set; }

        /// <summary>
        /// Require STARTTLS Support
        /// </summary>
        /// <value>Require STARTTLS Support</value>
        [DataMember(Name="startTlsRequired", EmitDefaultValue=false)]
        public bool? StartTlsRequired { get; set; }

        /// <summary>
        /// Enable SSL/TLS Encryption upon Connection
        /// </summary>
        /// <value>Enable SSL/TLS Encryption upon Connection</value>
        [DataMember(Name="sslOnConnectEnabled", EmitDefaultValue=false)]
        public bool? SslOnConnectEnabled { get; set; }

        /// <summary>
        /// Verify the server certificate when using TLS or SSL
        /// </summary>
        /// <value>Verify the server certificate when using TLS or SSL</value>
        [DataMember(Name="sslServerIdentityCheckEnabled", EmitDefaultValue=false)]
        public bool? SslServerIdentityCheckEnabled { get; set; }

        /// <summary>
        /// Use the Nexus Repository Manager&#39;s certificate truststore
        /// </summary>
        /// <value>Use the Nexus Repository Manager&#39;s certificate truststore</value>
        [DataMember(Name="nexusTrustStoreEnabled", EmitDefaultValue=false)]
        public bool? NexusTrustStoreEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiEmailConfiguration {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  SubjectPrefix: ").Append(SubjectPrefix).Append("\n");
            sb.Append("  StartTlsEnabled: ").Append(StartTlsEnabled).Append("\n");
            sb.Append("  StartTlsRequired: ").Append(StartTlsRequired).Append("\n");
            sb.Append("  SslOnConnectEnabled: ").Append(SslOnConnectEnabled).Append("\n");
            sb.Append("  SslServerIdentityCheckEnabled: ").Append(SslServerIdentityCheckEnabled).Append("\n");
            sb.Append("  NexusTrustStoreEnabled: ").Append(NexusTrustStoreEnabled).Append("\n");
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
            return this.Equals(input as ApiEmailConfiguration);
        }

        /// <summary>
        /// Returns true if ApiEmailConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiEmailConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiEmailConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.SubjectPrefix == input.SubjectPrefix ||
                    (this.SubjectPrefix != null &&
                    this.SubjectPrefix.Equals(input.SubjectPrefix))
                ) && 
                (
                    this.StartTlsEnabled == input.StartTlsEnabled ||
                    (this.StartTlsEnabled != null &&
                    this.StartTlsEnabled.Equals(input.StartTlsEnabled))
                ) && 
                (
                    this.StartTlsRequired == input.StartTlsRequired ||
                    (this.StartTlsRequired != null &&
                    this.StartTlsRequired.Equals(input.StartTlsRequired))
                ) && 
                (
                    this.SslOnConnectEnabled == input.SslOnConnectEnabled ||
                    (this.SslOnConnectEnabled != null &&
                    this.SslOnConnectEnabled.Equals(input.SslOnConnectEnabled))
                ) && 
                (
                    this.SslServerIdentityCheckEnabled == input.SslServerIdentityCheckEnabled ||
                    (this.SslServerIdentityCheckEnabled != null &&
                    this.SslServerIdentityCheckEnabled.Equals(input.SslServerIdentityCheckEnabled))
                ) && 
                (
                    this.NexusTrustStoreEnabled == input.NexusTrustStoreEnabled ||
                    (this.NexusTrustStoreEnabled != null &&
                    this.NexusTrustStoreEnabled.Equals(input.NexusTrustStoreEnabled))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.FromAddress != null)
                    hashCode = hashCode * 59 + this.FromAddress.GetHashCode();
                if (this.SubjectPrefix != null)
                    hashCode = hashCode * 59 + this.SubjectPrefix.GetHashCode();
                if (this.StartTlsEnabled != null)
                    hashCode = hashCode * 59 + this.StartTlsEnabled.GetHashCode();
                if (this.StartTlsRequired != null)
                    hashCode = hashCode * 59 + this.StartTlsRequired.GetHashCode();
                if (this.SslOnConnectEnabled != null)
                    hashCode = hashCode * 59 + this.SslOnConnectEnabled.GetHashCode();
                if (this.SslServerIdentityCheckEnabled != null)
                    hashCode = hashCode * 59 + this.SslServerIdentityCheckEnabled.GetHashCode();
                if (this.NexusTrustStoreEnabled != null)
                    hashCode = hashCode * 59 + this.NexusTrustStoreEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
