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
    /// HttpClientConnectionAuthenticationAttributes
    /// </summary>
    [DataContract]
    public partial class HttpClientConnectionAuthenticationAttributes :  IEquatable<HttpClientConnectionAuthenticationAttributes>
    {
        /// <summary>
        /// Authentication type
        /// </summary>
        /// <value>Authentication type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Username for value: username
            /// </summary>
            [EnumMember(Value = "username")]
            Username = 1,
            
            /// <summary>
            /// Enum Ntlm for value: ntlm
            /// </summary>
            [EnumMember(Value = "ntlm")]
            Ntlm = 2
        }

        /// <summary>
        /// Authentication type
        /// </summary>
        /// <value>Authentication type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientConnectionAuthenticationAttributes" /> class.
        /// </summary>
        /// <param name="type">Authentication type.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="ntlmHost">ntlmHost.</param>
        /// <param name="ntlmDomain">ntlmDomain.</param>
        public HttpClientConnectionAuthenticationAttributes(TypeEnum? type = default(TypeEnum?), string username = default(string), string password = default(string), string ntlmHost = default(string), string ntlmDomain = default(string))
        {
            this.Type = type;
            this.Username = username;
            this.Password = password;
            this.NtlmHost = ntlmHost;
            this.NtlmDomain = ntlmDomain;
        }
        

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
        /// Gets or Sets NtlmHost
        /// </summary>
        [DataMember(Name="ntlmHost", EmitDefaultValue=false)]
        public string NtlmHost { get; set; }

        /// <summary>
        /// Gets or Sets NtlmDomain
        /// </summary>
        [DataMember(Name="ntlmDomain", EmitDefaultValue=false)]
        public string NtlmDomain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpClientConnectionAuthenticationAttributes {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  NtlmHost: ").Append(NtlmHost).Append("\n");
            sb.Append("  NtlmDomain: ").Append(NtlmDomain).Append("\n");
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
            return this.Equals(input as HttpClientConnectionAuthenticationAttributes);
        }

        /// <summary>
        /// Returns true if HttpClientConnectionAuthenticationAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpClientConnectionAuthenticationAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpClientConnectionAuthenticationAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.NtlmHost == input.NtlmHost ||
                    (this.NtlmHost != null &&
                    this.NtlmHost.Equals(input.NtlmHost))
                ) && 
                (
                    this.NtlmDomain == input.NtlmDomain ||
                    (this.NtlmDomain != null &&
                    this.NtlmDomain.Equals(input.NtlmDomain))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.NtlmHost != null)
                    hashCode = hashCode * 59 + this.NtlmHost.GetHashCode();
                if (this.NtlmDomain != null)
                    hashCode = hashCode * 59 + this.NtlmDomain.GetHashCode();
                return hashCode;
            }
        }
    }

}
