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
    /// NpmAttributes
    /// </summary>
    [DataContract]
    public partial class NpmAttributes :  IEquatable<NpmAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpmAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NpmAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NpmAttributes" /> class.
        /// </summary>
        /// <param name="removeNonCataloged">Remove Non-Cataloged Versions (required).</param>
        public NpmAttributes(bool? removeNonCataloged = default(bool?))
        {
            // to ensure "removeNonCataloged" is required (not null)
            if (removeNonCataloged == null)
            {
                throw new InvalidDataException("removeNonCataloged is a required property for NpmAttributes and cannot be null");
            }
            else
            {
                this.RemoveNonCataloged = removeNonCataloged;
            }
        }
        
        /// <summary>
        /// Remove Non-Cataloged Versions
        /// </summary>
        /// <value>Remove Non-Cataloged Versions</value>
        [DataMember(Name="removeNonCataloged", EmitDefaultValue=false)]
        public bool? RemoveNonCataloged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NpmAttributes {\n");
            sb.Append("  RemoveNonCataloged: ").Append(RemoveNonCataloged).Append("\n");
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
            return this.Equals(input as NpmAttributes);
        }

        /// <summary>
        /// Returns true if NpmAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of NpmAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NpmAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoveNonCataloged == input.RemoveNonCataloged ||
                    (this.RemoveNonCataloged != null &&
                    this.RemoveNonCataloged.Equals(input.RemoveNonCataloged))
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
                if (this.RemoveNonCataloged != null)
                    hashCode = hashCode * 59 + this.RemoveNonCataloged.GetHashCode();
                return hashCode;
            }
        }
    }

}
