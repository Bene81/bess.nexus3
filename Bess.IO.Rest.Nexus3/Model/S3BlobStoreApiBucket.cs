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
    /// S3BlobStoreApiBucket
    /// </summary>
    [DataContract]
    public partial class S3BlobStoreApiBucket :  IEquatable<S3BlobStoreApiBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BlobStoreApiBucket" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected S3BlobStoreApiBucket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BlobStoreApiBucket" /> class.
        /// </summary>
        /// <param name="region">The AWS region to create a new S3 bucket in or an existing S3 bucket&#39;s region (required).</param>
        /// <param name="name">The name of the S3 bucket (required).</param>
        /// <param name="prefix">The S3 blob store (i.e S3 object) key prefix.</param>
        /// <param name="expiration">How many days until deleted blobs are finally removed from the S3 bucket (-1 to disable) (required).</param>
        public S3BlobStoreApiBucket(string region = default(string), string name = default(string), string prefix = default(string), int? expiration = default(int?))
        {
            // to ensure "region" is required (not null)
            if (region == null)
            {
                throw new InvalidDataException("region is a required property for S3BlobStoreApiBucket and cannot be null");
            }
            else
            {
                this.Region = region;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for S3BlobStoreApiBucket and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "expiration" is required (not null)
            if (expiration == null)
            {
                throw new InvalidDataException("expiration is a required property for S3BlobStoreApiBucket and cannot be null");
            }
            else
            {
                this.Expiration = expiration;
            }
            this.Prefix = prefix;
        }
        
        /// <summary>
        /// The AWS region to create a new S3 bucket in or an existing S3 bucket&#39;s region
        /// </summary>
        /// <value>The AWS region to create a new S3 bucket in or an existing S3 bucket&#39;s region</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// The name of the S3 bucket
        /// </summary>
        /// <value>The name of the S3 bucket</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The S3 blob store (i.e S3 object) key prefix
        /// </summary>
        /// <value>The S3 blob store (i.e S3 object) key prefix</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// How many days until deleted blobs are finally removed from the S3 bucket (-1 to disable)
        /// </summary>
        /// <value>How many days until deleted blobs are finally removed from the S3 bucket (-1 to disable)</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public int? Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class S3BlobStoreApiBucket {\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(input as S3BlobStoreApiBucket);
        }

        /// <summary>
        /// Returns true if S3BlobStoreApiBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BlobStoreApiBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BlobStoreApiBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                return hashCode;
            }
        }
    }

}
