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
    /// AptHostedApiRepository
    /// </summary>
    [DataContract]
    public partial class AptHostedApiRepository :  IEquatable<AptHostedApiRepository>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AptHostedApiRepository" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AptHostedApiRepository() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AptHostedApiRepository" /> class.
        /// </summary>
        /// <param name="name">A unique identifier for this repository.</param>
        /// <param name="online">Whether this repository accepts incoming requests (required).</param>
        /// <param name="storage">storage (required).</param>
        /// <param name="cleanup">cleanup.</param>
        /// <param name="component">component.</param>
        /// <param name="apt">apt (required).</param>
        /// <param name="aptSigning">aptSigning (required).</param>
        public AptHostedApiRepository(string name = default(string), bool? online = default(bool?), HostedStorageAttributes storage = default(HostedStorageAttributes), CleanupPolicyAttributes cleanup = default(CleanupPolicyAttributes), ComponentAttributes component = default(ComponentAttributes), AptHostedRepositoriesAttributes apt = default(AptHostedRepositoriesAttributes), AptSigningRepositoriesAttributes aptSigning = default(AptSigningRepositoriesAttributes))
        {
            // to ensure "online" is required (not null)
            if (online == null)
            {
                throw new InvalidDataException("online is a required property for AptHostedApiRepository and cannot be null");
            }
            else
            {
                this.Online = online;
            }
            // to ensure "storage" is required (not null)
            if (storage == null)
            {
                throw new InvalidDataException("storage is a required property for AptHostedApiRepository and cannot be null");
            }
            else
            {
                this.Storage = storage;
            }
            // to ensure "apt" is required (not null)
            if (apt == null)
            {
                throw new InvalidDataException("apt is a required property for AptHostedApiRepository and cannot be null");
            }
            else
            {
                this.Apt = apt;
            }
            // to ensure "aptSigning" is required (not null)
            if (aptSigning == null)
            {
                throw new InvalidDataException("aptSigning is a required property for AptHostedApiRepository and cannot be null");
            }
            else
            {
                this.AptSigning = aptSigning;
            }
            this.Name = name;
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
        /// Gets or Sets Apt
        /// </summary>
        [DataMember(Name="apt", EmitDefaultValue=false)]
        public AptHostedRepositoriesAttributes Apt { get; set; }

        /// <summary>
        /// Gets or Sets AptSigning
        /// </summary>
        [DataMember(Name="aptSigning", EmitDefaultValue=false)]
        public AptSigningRepositoriesAttributes AptSigning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AptHostedApiRepository {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  Cleanup: ").Append(Cleanup).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  Apt: ").Append(Apt).Append("\n");
            sb.Append("  AptSigning: ").Append(AptSigning).Append("\n");
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
            return this.Equals(input as AptHostedApiRepository);
        }

        /// <summary>
        /// Returns true if AptHostedApiRepository instances are equal
        /// </summary>
        /// <param name="input">Instance of AptHostedApiRepository to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AptHostedApiRepository input)
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
                ) && 
                (
                    this.Apt == input.Apt ||
                    (this.Apt != null &&
                    this.Apt.Equals(input.Apt))
                ) && 
                (
                    this.AptSigning == input.AptSigning ||
                    (this.AptSigning != null &&
                    this.AptSigning.Equals(input.AptSigning))
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
                if (this.Apt != null)
                    hashCode = hashCode * 59 + this.Apt.GetHashCode();
                if (this.AptSigning != null)
                    hashCode = hashCode * 59 + this.AptSigning.GetHashCode();
                return hashCode;
            }
        }
    }

}
