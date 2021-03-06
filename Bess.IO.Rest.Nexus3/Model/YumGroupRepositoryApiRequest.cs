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
    /// YumGroupRepositoryApiRequest
    /// </summary>
    [DataContract]
    public partial class YumGroupRepositoryApiRequest :  IEquatable<YumGroupRepositoryApiRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YumGroupRepositoryApiRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected YumGroupRepositoryApiRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="YumGroupRepositoryApiRequest" /> class.
        /// </summary>
        /// <param name="name">A unique identifier for this repository (required).</param>
        /// <param name="online">Whether this repository accepts incoming requests (required).</param>
        /// <param name="storage">storage (required).</param>
        /// <param name="group">group (required).</param>
        /// <param name="yumSigning">yumSigning.</param>
        public YumGroupRepositoryApiRequest(string name = default(string), bool? online = default(bool?), StorageAttributes storage = default(StorageAttributes), GroupAttributes group = default(GroupAttributes), YumSigningRepositoriesAttributes yumSigning = default(YumSigningRepositoriesAttributes))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for YumGroupRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "online" is required (not null)
            if (online == null)
            {
                throw new InvalidDataException("online is a required property for YumGroupRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Online = online;
            }
            // to ensure "storage" is required (not null)
            if (storage == null)
            {
                throw new InvalidDataException("storage is a required property for YumGroupRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Storage = storage;
            }
            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new InvalidDataException("group is a required property for YumGroupRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Group = group;
            }
            this.YumSigning = yumSigning;
        }
        
        /// <summary>
        /// A unique identifier for this repository
        /// </summary>
        /// <value>A unique identifier for this repository</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether this repository accepts incoming requests
        /// </summary>
        /// <value>Whether this repository accepts incoming requests</value>
        [DataMember(Name="online", EmitDefaultValue=false)]
        public bool? Online { get; set; }

        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public StorageAttributes Storage { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public GroupAttributes Group { get; set; }

        /// <summary>
        /// Gets or Sets YumSigning
        /// </summary>
        [DataMember(Name="yumSigning", EmitDefaultValue=false)]
        public YumSigningRepositoriesAttributes YumSigning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YumGroupRepositoryApiRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  YumSigning: ").Append(YumSigning).Append("\n");
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
            return this.Equals(input as YumGroupRepositoryApiRequest);
        }

        /// <summary>
        /// Returns true if YumGroupRepositoryApiRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of YumGroupRepositoryApiRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YumGroupRepositoryApiRequest input)
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
                    this.Online == input.Online ||
                    (this.Online != null &&
                    this.Online.Equals(input.Online))
                ) && 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.YumSigning == input.YumSigning ||
                    (this.YumSigning != null &&
                    this.YumSigning.Equals(input.YumSigning))
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
                if (this.Online != null)
                    hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.YumSigning != null)
                    hashCode = hashCode * 59 + this.YumSigning.GetHashCode();
                return hashCode;
            }
        }
    }

}
