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
    /// YumSigningRepositoriesAttributes
    /// </summary>
    [DataContract]
    public partial class YumSigningRepositoriesAttributes :  IEquatable<YumSigningRepositoriesAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YumSigningRepositoriesAttributes" /> class.
        /// </summary>
        /// <param name="keypair">PGP signing key pair (armored private key e.g. gpg - -export-secret-key - -armor).</param>
        /// <param name="passphrase">Passphrase to access PGP signing key.</param>
        public YumSigningRepositoriesAttributes(string keypair = default(string), string passphrase = default(string))
        {
            this.Keypair = keypair;
            this.Passphrase = passphrase;
        }
        
        /// <summary>
        /// PGP signing key pair (armored private key e.g. gpg - -export-secret-key - -armor)
        /// </summary>
        /// <value>PGP signing key pair (armored private key e.g. gpg - -export-secret-key - -armor)</value>
        [DataMember(Name="keypair", EmitDefaultValue=false)]
        public string Keypair { get; set; }

        /// <summary>
        /// Passphrase to access PGP signing key
        /// </summary>
        /// <value>Passphrase to access PGP signing key</value>
        [DataMember(Name="passphrase", EmitDefaultValue=false)]
        public string Passphrase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YumSigningRepositoriesAttributes {\n");
            sb.Append("  Keypair: ").Append(Keypair).Append("\n");
            sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
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
            return this.Equals(input as YumSigningRepositoriesAttributes);
        }

        /// <summary>
        /// Returns true if YumSigningRepositoriesAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of YumSigningRepositoriesAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YumSigningRepositoriesAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keypair == input.Keypair ||
                    (this.Keypair != null &&
                    this.Keypair.Equals(input.Keypair))
                ) && 
                (
                    this.Passphrase == input.Passphrase ||
                    (this.Passphrase != null &&
                    this.Passphrase.Equals(input.Passphrase))
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
                if (this.Keypair != null)
                    hashCode = hashCode * 59 + this.Keypair.GetHashCode();
                if (this.Passphrase != null)
                    hashCode = hashCode * 59 + this.Passphrase.GetHashCode();
                return hashCode;
            }
        }
    }

}
