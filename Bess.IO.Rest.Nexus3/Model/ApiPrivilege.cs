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
    /// ApiPrivilege
    /// </summary>
    [DataContract]
    public partial class ApiPrivilege :  IEquatable<ApiPrivilege>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPrivilege" /> class.
        /// </summary>
        /// <param name="type">The type of privilege, each type covers different portions of the system. External values supplied to this will be ignored by the system..</param>
        /// <param name="name">The name of the privilege.  This value cannot be changed..</param>
        /// <param name="description">description.</param>
        /// <param name="readOnly">Indicates whether the privilege can be changed. External values supplied to this will be ignored by the system..</param>
        public ApiPrivilege(string type = default(string), string name = default(string), string description = default(string), bool? readOnly = default(bool?))
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.ReadOnly = readOnly;
        }
        
        /// <summary>
        /// The type of privilege, each type covers different portions of the system. External values supplied to this will be ignored by the system.
        /// </summary>
        /// <value>The type of privilege, each type covers different portions of the system. External values supplied to this will be ignored by the system.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The name of the privilege.  This value cannot be changed.
        /// </summary>
        /// <value>The name of the privilege.  This value cannot be changed.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the privilege can be changed. External values supplied to this will be ignored by the system.
        /// </summary>
        /// <value>Indicates whether the privilege can be changed. External values supplied to this will be ignored by the system.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiPrivilege {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
            return this.Equals(input as ApiPrivilege);
        }

        /// <summary>
        /// Returns true if ApiPrivilege instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiPrivilege to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiPrivilege input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                return hashCode;
            }
        }
    }

}
