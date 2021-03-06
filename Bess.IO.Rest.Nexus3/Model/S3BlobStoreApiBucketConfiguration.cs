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
    /// S3BlobStoreApiBucketConfiguration
    /// </summary>
    [DataContract]
    public partial class S3BlobStoreApiBucketConfiguration :  IEquatable<S3BlobStoreApiBucketConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BlobStoreApiBucketConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected S3BlobStoreApiBucketConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BlobStoreApiBucketConfiguration" /> class.
        /// </summary>
        /// <param name="bucketSecurity">Security details for granting access the S3 API.</param>
        /// <param name="advancedBucketConnection">A custom endpoint URL, signer type and whether path style access is enabled.</param>
        public S3BlobStoreApiBucketConfiguration(S3BlobStoreApiBucketSecurity bucketSecurity = default(S3BlobStoreApiBucketSecurity), S3BlobStoreApiAdvancedBucketConnection advancedBucketConnection = default(S3BlobStoreApiAdvancedBucketConnection))
        {
            this.BucketSecurity = bucketSecurity;
            this.AdvancedBucketConnection = advancedBucketConnection;
        }
        
        /// <summary>
        /// Details of the S3 bucket such as name and region
        /// </summary>
        /// <value>Details of the S3 bucket such as name and region</value>
        [DataMember(Name="bucket", EmitDefaultValue=false)]
        public S3BlobStoreApiBucket Bucket { get; private set; }

        /// <summary>
        /// The type of encryption to use if any
        /// </summary>
        /// <value>The type of encryption to use if any</value>
        [DataMember(Name="encryption", EmitDefaultValue=false)]
        public S3BlobStoreApiEncryption Encryption { get; private set; }

        /// <summary>
        /// Security details for granting access the S3 API
        /// </summary>
        /// <value>Security details for granting access the S3 API</value>
        [DataMember(Name="bucketSecurity", EmitDefaultValue=false)]
        public S3BlobStoreApiBucketSecurity BucketSecurity { get; set; }

        /// <summary>
        /// A custom endpoint URL, signer type and whether path style access is enabled
        /// </summary>
        /// <value>A custom endpoint URL, signer type and whether path style access is enabled</value>
        [DataMember(Name="advancedBucketConnection", EmitDefaultValue=false)]
        public S3BlobStoreApiAdvancedBucketConnection AdvancedBucketConnection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class S3BlobStoreApiBucketConfiguration {\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  BucketSecurity: ").Append(BucketSecurity).Append("\n");
            sb.Append("  AdvancedBucketConnection: ").Append(AdvancedBucketConnection).Append("\n");
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
            return this.Equals(input as S3BlobStoreApiBucketConfiguration);
        }

        /// <summary>
        /// Returns true if S3BlobStoreApiBucketConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BlobStoreApiBucketConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BlobStoreApiBucketConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.BucketSecurity == input.BucketSecurity ||
                    (this.BucketSecurity != null &&
                    this.BucketSecurity.Equals(input.BucketSecurity))
                ) && 
                (
                    this.AdvancedBucketConnection == input.AdvancedBucketConnection ||
                    (this.AdvancedBucketConnection != null &&
                    this.AdvancedBucketConnection.Equals(input.AdvancedBucketConnection))
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
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Encryption != null)
                    hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.BucketSecurity != null)
                    hashCode = hashCode * 59 + this.BucketSecurity.GetHashCode();
                if (this.AdvancedBucketConnection != null)
                    hashCode = hashCode * 59 + this.AdvancedBucketConnection.GetHashCode();
                return hashCode;
            }
        }
    }

}
