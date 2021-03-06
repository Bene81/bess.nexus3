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
    /// NegativeCacheAttributes
    /// </summary>
    [DataContract]
    public partial class NegativeCacheAttributes :  IEquatable<NegativeCacheAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeCacheAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NegativeCacheAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeCacheAttributes" /> class.
        /// </summary>
        /// <param name="enabled">Whether to cache responses for content not present in the proxied repository (required).</param>
        /// <param name="timeToLive">How long to cache the fact that a file was not found in the repository (in minutes) (required).</param>
        public NegativeCacheAttributes(bool? enabled = default(bool?), int? timeToLive = default(int?))
        {
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for NegativeCacheAttributes and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "timeToLive" is required (not null)
            if (timeToLive == null)
            {
                throw new InvalidDataException("timeToLive is a required property for NegativeCacheAttributes and cannot be null");
            }
            else
            {
                this.TimeToLive = timeToLive;
            }
        }
        
        /// <summary>
        /// Whether to cache responses for content not present in the proxied repository
        /// </summary>
        /// <value>Whether to cache responses for content not present in the proxied repository</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// How long to cache the fact that a file was not found in the repository (in minutes)
        /// </summary>
        /// <value>How long to cache the fact that a file was not found in the repository (in minutes)</value>
        [DataMember(Name="timeToLive", EmitDefaultValue=false)]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NegativeCacheAttributes {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  TimeToLive: ").Append(TimeToLive).Append("\n");
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
            return this.Equals(input as NegativeCacheAttributes);
        }

        /// <summary>
        /// Returns true if NegativeCacheAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of NegativeCacheAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NegativeCacheAttributes input)
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
                    this.TimeToLive == input.TimeToLive ||
                    (this.TimeToLive != null &&
                    this.TimeToLive.Equals(input.TimeToLive))
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
                if (this.TimeToLive != null)
                    hashCode = hashCode * 59 + this.TimeToLive.GetHashCode();
                return hashCode;
            }
        }
    }

}
