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
    /// BlobStoreApiSoftQuota
    /// </summary>
    [DataContract]
    public partial class BlobStoreApiSoftQuota :  IEquatable<BlobStoreApiSoftQuota>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlobStoreApiSoftQuota" /> class.
        /// </summary>
        /// <param name="type">The type to use such as spaceRemainingQuota, or spaceUsedQuota.</param>
        /// <param name="limit">The limit in MB..</param>
        public BlobStoreApiSoftQuota(string type = default(string), long? limit = default(long?))
        {
            this.Type = type;
            this.Limit = limit;
        }
        
        /// <summary>
        /// The type to use such as spaceRemainingQuota, or spaceUsedQuota
        /// </summary>
        /// <value>The type to use such as spaceRemainingQuota, or spaceUsedQuota</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The limit in MB.
        /// </summary>
        /// <value>The limit in MB.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlobStoreApiSoftQuota {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as BlobStoreApiSoftQuota);
        }

        /// <summary>
        /// Returns true if BlobStoreApiSoftQuota instances are equal
        /// </summary>
        /// <param name="input">Instance of BlobStoreApiSoftQuota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlobStoreApiSoftQuota input)
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
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }

}
