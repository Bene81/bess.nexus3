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
    /// HttpClientConnectionAttributes
    /// </summary>
    [DataContract]
    public partial class HttpClientConnectionAttributes :  IEquatable<HttpClientConnectionAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientConnectionAttributes" /> class.
        /// </summary>
        /// <param name="retries">Total retries if the initial connection attempt suffers a timeout.</param>
        /// <param name="userAgentSuffix">Custom fragment to append to User-Agent header in HTTP requests.</param>
        /// <param name="timeout">Seconds to wait for activity before stopping and retrying the connection.</param>
        /// <param name="enableCircularRedirects">Whether to enable redirects to the same location (may be required by some servers).</param>
        /// <param name="enableCookies">Whether to allow cookies to be stored and used.</param>
        /// <param name="useTrustStore">Use certificates stored in the Nexus Repository Manager truststore to connect to external systems.</param>
        public HttpClientConnectionAttributes(int? retries = default(int?), string userAgentSuffix = default(string), int? timeout = default(int?), bool? enableCircularRedirects = default(bool?), bool? enableCookies = default(bool?), bool? useTrustStore = default(bool?))
        {
            this.Retries = retries;
            this.UserAgentSuffix = userAgentSuffix;
            this.Timeout = timeout;
            this.EnableCircularRedirects = enableCircularRedirects;
            this.EnableCookies = enableCookies;
            this.UseTrustStore = useTrustStore;
        }
        
        /// <summary>
        /// Total retries if the initial connection attempt suffers a timeout
        /// </summary>
        /// <value>Total retries if the initial connection attempt suffers a timeout</value>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }

        /// <summary>
        /// Custom fragment to append to User-Agent header in HTTP requests
        /// </summary>
        /// <value>Custom fragment to append to User-Agent header in HTTP requests</value>
        [DataMember(Name="userAgentSuffix", EmitDefaultValue=false)]
        public string UserAgentSuffix { get; set; }

        /// <summary>
        /// Seconds to wait for activity before stopping and retrying the connection
        /// </summary>
        /// <value>Seconds to wait for activity before stopping and retrying the connection</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Whether to enable redirects to the same location (may be required by some servers)
        /// </summary>
        /// <value>Whether to enable redirects to the same location (may be required by some servers)</value>
        [DataMember(Name="enableCircularRedirects", EmitDefaultValue=false)]
        public bool? EnableCircularRedirects { get; set; }

        /// <summary>
        /// Whether to allow cookies to be stored and used
        /// </summary>
        /// <value>Whether to allow cookies to be stored and used</value>
        [DataMember(Name="enableCookies", EmitDefaultValue=false)]
        public bool? EnableCookies { get; set; }

        /// <summary>
        /// Use certificates stored in the Nexus Repository Manager truststore to connect to external systems
        /// </summary>
        /// <value>Use certificates stored in the Nexus Repository Manager truststore to connect to external systems</value>
        [DataMember(Name="useTrustStore", EmitDefaultValue=false)]
        public bool? UseTrustStore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpClientConnectionAttributes {\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  UserAgentSuffix: ").Append(UserAgentSuffix).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  EnableCircularRedirects: ").Append(EnableCircularRedirects).Append("\n");
            sb.Append("  EnableCookies: ").Append(EnableCookies).Append("\n");
            sb.Append("  UseTrustStore: ").Append(UseTrustStore).Append("\n");
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
            return this.Equals(input as HttpClientConnectionAttributes);
        }

        /// <summary>
        /// Returns true if HttpClientConnectionAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpClientConnectionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpClientConnectionAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.UserAgentSuffix == input.UserAgentSuffix ||
                    (this.UserAgentSuffix != null &&
                    this.UserAgentSuffix.Equals(input.UserAgentSuffix))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.EnableCircularRedirects == input.EnableCircularRedirects ||
                    (this.EnableCircularRedirects != null &&
                    this.EnableCircularRedirects.Equals(input.EnableCircularRedirects))
                ) && 
                (
                    this.EnableCookies == input.EnableCookies ||
                    (this.EnableCookies != null &&
                    this.EnableCookies.Equals(input.EnableCookies))
                ) && 
                (
                    this.UseTrustStore == input.UseTrustStore ||
                    (this.UseTrustStore != null &&
                    this.UseTrustStore.Equals(input.UseTrustStore))
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
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.UserAgentSuffix != null)
                    hashCode = hashCode * 59 + this.UserAgentSuffix.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.EnableCircularRedirects != null)
                    hashCode = hashCode * 59 + this.EnableCircularRedirects.GetHashCode();
                if (this.EnableCookies != null)
                    hashCode = hashCode * 59 + this.EnableCookies.GetHashCode();
                if (this.UseTrustStore != null)
                    hashCode = hashCode * 59 + this.UseTrustStore.GetHashCode();
                return hashCode;
            }
        }
    }

}