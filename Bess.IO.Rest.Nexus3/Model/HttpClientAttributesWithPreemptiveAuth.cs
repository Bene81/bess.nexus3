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
    /// HttpClientAttributesWithPreemptiveAuth
    /// </summary>
    [DataContract]
    public partial class HttpClientAttributesWithPreemptiveAuth :  IEquatable<HttpClientAttributesWithPreemptiveAuth>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientAttributesWithPreemptiveAuth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HttpClientAttributesWithPreemptiveAuth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientAttributesWithPreemptiveAuth" /> class.
        /// </summary>
        /// <param name="blocked">Whether to block outbound connections on the repository (required).</param>
        /// <param name="autoBlock">Whether to auto-block outbound connections if remote peer is detected as unreachable/unresponsive (required).</param>
        /// <param name="connection">connection.</param>
        /// <param name="authentication">authentication.</param>
        public HttpClientAttributesWithPreemptiveAuth(bool? blocked = default(bool?), bool? autoBlock = default(bool?), HttpClientConnectionAttributes connection = default(HttpClientConnectionAttributes), HttpClientConnectionAuthenticationAttributesWithPreemptive authentication = default(HttpClientConnectionAuthenticationAttributesWithPreemptive))
        {
            // to ensure "blocked" is required (not null)
            if (blocked == null)
            {
                throw new InvalidDataException("blocked is a required property for HttpClientAttributesWithPreemptiveAuth and cannot be null");
            }
            else
            {
                this.Blocked = blocked;
            }
            // to ensure "autoBlock" is required (not null)
            if (autoBlock == null)
            {
                throw new InvalidDataException("autoBlock is a required property for HttpClientAttributesWithPreemptiveAuth and cannot be null");
            }
            else
            {
                this.AutoBlock = autoBlock;
            }
            this.Connection = connection;
            this.Authentication = authentication;
        }
        
        /// <summary>
        /// Whether to block outbound connections on the repository
        /// </summary>
        /// <value>Whether to block outbound connections on the repository</value>
        [DataMember(Name="blocked", EmitDefaultValue=false)]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Whether to auto-block outbound connections if remote peer is detected as unreachable/unresponsive
        /// </summary>
        /// <value>Whether to auto-block outbound connections if remote peer is detected as unreachable/unresponsive</value>
        [DataMember(Name="autoBlock", EmitDefaultValue=false)]
        public bool? AutoBlock { get; set; }

        /// <summary>
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name="connection", EmitDefaultValue=false)]
        public HttpClientConnectionAttributes Connection { get; set; }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name="authentication", EmitDefaultValue=false)]
        public HttpClientConnectionAuthenticationAttributesWithPreemptive Authentication { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpClientAttributesWithPreemptiveAuth {\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  AutoBlock: ").Append(AutoBlock).Append("\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
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
            return this.Equals(input as HttpClientAttributesWithPreemptiveAuth);
        }

        /// <summary>
        /// Returns true if HttpClientAttributesWithPreemptiveAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpClientAttributesWithPreemptiveAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpClientAttributesWithPreemptiveAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Blocked == input.Blocked ||
                    (this.Blocked != null &&
                    this.Blocked.Equals(input.Blocked))
                ) && 
                (
                    this.AutoBlock == input.AutoBlock ||
                    (this.AutoBlock != null &&
                    this.AutoBlock.Equals(input.AutoBlock))
                ) && 
                (
                    this.Connection == input.Connection ||
                    (this.Connection != null &&
                    this.Connection.Equals(input.Connection))
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
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
                if (this.Blocked != null)
                    hashCode = hashCode * 59 + this.Blocked.GetHashCode();
                if (this.AutoBlock != null)
                    hashCode = hashCode * 59 + this.AutoBlock.GetHashCode();
                if (this.Connection != null)
                    hashCode = hashCode * 59 + this.Connection.GetHashCode();
                if (this.Authentication != null)
                    hashCode = hashCode * 59 + this.Authentication.GetHashCode();
                return hashCode;
            }
        }
    }

}
