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
    /// GroupDeployAttributes
    /// </summary>
    [DataContract]
    public partial class GroupDeployAttributes :  IEquatable<GroupDeployAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDeployAttributes" /> class.
        /// </summary>
        /// <param name="memberNames">Member repositories&#39; names.</param>
        /// <param name="writableMember">Pro-only: This field is for the Group Deployment feature available in NXRM Pro..</param>
        public GroupDeployAttributes(List<string> memberNames = default(List<string>), string writableMember = default(string))
        {
            this.MemberNames = memberNames;
            this.WritableMember = writableMember;
        }
        
        /// <summary>
        /// Member repositories&#39; names
        /// </summary>
        /// <value>Member repositories&#39; names</value>
        [DataMember(Name="memberNames", EmitDefaultValue=false)]
        public List<string> MemberNames { get; set; }

        /// <summary>
        /// Pro-only: This field is for the Group Deployment feature available in NXRM Pro.
        /// </summary>
        /// <value>Pro-only: This field is for the Group Deployment feature available in NXRM Pro.</value>
        [DataMember(Name="writableMember", EmitDefaultValue=false)]
        public string WritableMember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupDeployAttributes {\n");
            sb.Append("  MemberNames: ").Append(MemberNames).Append("\n");
            sb.Append("  WritableMember: ").Append(WritableMember).Append("\n");
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
            return this.Equals(input as GroupDeployAttributes);
        }

        /// <summary>
        /// Returns true if GroupDeployAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupDeployAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupDeployAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MemberNames == input.MemberNames ||
                    this.MemberNames != null &&
                    this.MemberNames.SequenceEqual(input.MemberNames)
                ) && 
                (
                    this.WritableMember == input.WritableMember ||
                    (this.WritableMember != null &&
                    this.WritableMember.Equals(input.WritableMember))
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
                if (this.MemberNames != null)
                    hashCode = hashCode * 59 + this.MemberNames.GetHashCode();
                if (this.WritableMember != null)
                    hashCode = hashCode * 59 + this.WritableMember.GetHashCode();
                return hashCode;
            }
        }
    }

}
