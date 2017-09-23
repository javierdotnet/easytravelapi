/* 
 * EasyTravelApi
 *
 * API for travel agents
 *
 * OpenAPI spec version: 0.1.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Container for the update request parameters
    /// </summary>
    [DataContract]
    public partial class UpdateRQ :  IEquatable<UpdateRQ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRQ" /> class.
        /// </summary>
        /// <param name="Operations">List of operations you want to perform on hote inventories.</param>
        public UpdateRQ(List<UpdateOperation> Operations = null)
        {
            this.Operations = Operations;
        }
        
        /// <summary>
        /// List of operations you want to perform on hote inventories
        /// </summary>
        /// <value>List of operations you want to perform on hote inventories</value>
        [DataMember(Name="operations", EmitDefaultValue=false)]
        public List<UpdateOperation> Operations { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRQ {\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UpdateRQ);
        }

        /// <summary>
        /// Returns true if UpdateRQ instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateRQ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRQ other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Operations == other.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(other.Operations)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Operations != null)
                    hash = hash * 59 + this.Operations.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}