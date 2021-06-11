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
    /// GitLfsHostedRepositoryApiRequest
    /// </summary>
    [DataContract]
    public partial class GitLfsHostedRepositoryApiRequest :  IEquatable<GitLfsHostedRepositoryApiRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitLfsHostedRepositoryApiRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GitLfsHostedRepositoryApiRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GitLfsHostedRepositoryApiRequest" /> class.
        /// </summary>
        /// <param name="name">A unique identifier for this repository (required).</param>
        /// <param name="online">Whether this repository accepts incoming requests (required).</param>
        /// <param name="storage">storage (required).</param>
        /// <param name="cleanup">cleanup.</param>
        /// <param name="component">component.</param>
        public GitLfsHostedRepositoryApiRequest(string name = default(string), bool? online = default(bool?), HostedStorageAttributes storage = default(HostedStorageAttributes), CleanupPolicyAttributes cleanup = default(CleanupPolicyAttributes), ComponentAttributes component = default(ComponentAttributes))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GitLfsHostedRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "online" is required (not null)
            if (online == null)
            {
                throw new InvalidDataException("online is a required property for GitLfsHostedRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Online = online;
            }
            // to ensure "storage" is required (not null)
            if (storage == null)
            {
                throw new InvalidDataException("storage is a required property for GitLfsHostedRepositoryApiRequest and cannot be null");
            }
            else
            {
                this.Storage = storage;
            }
            this.Cleanup = cleanup;
            this.Component = component;
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
        public HostedStorageAttributes Storage { get; set; }

        /// <summary>
        /// Gets or Sets Cleanup
        /// </summary>
        [DataMember(Name="cleanup", EmitDefaultValue=false)]
        public CleanupPolicyAttributes Cleanup { get; set; }

        /// <summary>
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public ComponentAttributes Component { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitLfsHostedRepositoryApiRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  Cleanup: ").Append(Cleanup).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
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
            return this.Equals(input as GitLfsHostedRepositoryApiRequest);
        }

        /// <summary>
        /// Returns true if GitLfsHostedRepositoryApiRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GitLfsHostedRepositoryApiRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GitLfsHostedRepositoryApiRequest input)
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
                    this.Cleanup == input.Cleanup ||
                    (this.Cleanup != null &&
                    this.Cleanup.Equals(input.Cleanup))
                ) && 
                (
                    this.Component == input.Component ||
                    (this.Component != null &&
                    this.Component.Equals(input.Component))
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
                if (this.Cleanup != null)
                    hashCode = hashCode * 59 + this.Cleanup.GetHashCode();
                if (this.Component != null)
                    hashCode = hashCode * 59 + this.Component.GetHashCode();
                return hashCode;
            }
        }
    }

}
