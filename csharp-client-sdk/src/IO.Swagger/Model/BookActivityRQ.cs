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
    /// Parameters needed to confirm an activity booking
    /// </summary>
    [DataContract]
    public partial class BookActivityRQ :  IEquatable<BookActivityRQ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookActivityRQ" /> class.
        /// </summary>
        /// <param name="Key">The activity price key, as provided in the /activities/getavailable step.</param>
        /// <param name="LeadName">The lead name.</param>
        /// <param name="CommentsToProvider">Comments from the customer which should arrive to the activity provider.</param>
        /// <param name="PrivateComments">Your comments for us. They will not be visible to the customer neither to the activity provider.</param>
        public BookActivityRQ(string Key = null, string LeadName = null, string CommentsToProvider = null, string PrivateComments = null)
        {
            this.Key = Key;
            this.LeadName = LeadName;
            this.CommentsToProvider = CommentsToProvider;
            this.PrivateComments = PrivateComments;
        }
        
        /// <summary>
        /// The activity price key, as provided in the /activities/getavailable step
        /// </summary>
        /// <value>The activity price key, as provided in the /activities/getavailable step</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// The lead name
        /// </summary>
        /// <value>The lead name</value>
        [DataMember(Name="leadName", EmitDefaultValue=false)]
        public string LeadName { get; set; }
        /// <summary>
        /// Comments from the customer which should arrive to the activity provider
        /// </summary>
        /// <value>Comments from the customer which should arrive to the activity provider</value>
        [DataMember(Name="commentsToProvider", EmitDefaultValue=false)]
        public string CommentsToProvider { get; set; }
        /// <summary>
        /// Your comments for us. They will not be visible to the customer neither to the activity provider
        /// </summary>
        /// <value>Your comments for us. They will not be visible to the customer neither to the activity provider</value>
        [DataMember(Name="privateComments", EmitDefaultValue=false)]
        public string PrivateComments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookActivityRQ {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LeadName: ").Append(LeadName).Append("\n");
            sb.Append("  CommentsToProvider: ").Append(CommentsToProvider).Append("\n");
            sb.Append("  PrivateComments: ").Append(PrivateComments).Append("\n");
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
            return this.Equals(obj as BookActivityRQ);
        }

        /// <summary>
        /// Returns true if BookActivityRQ instances are equal
        /// </summary>
        /// <param name="other">Instance of BookActivityRQ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookActivityRQ other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.LeadName == other.LeadName ||
                    this.LeadName != null &&
                    this.LeadName.Equals(other.LeadName)
                ) && 
                (
                    this.CommentsToProvider == other.CommentsToProvider ||
                    this.CommentsToProvider != null &&
                    this.CommentsToProvider.Equals(other.CommentsToProvider)
                ) && 
                (
                    this.PrivateComments == other.PrivateComments ||
                    this.PrivateComments != null &&
                    this.PrivateComments.Equals(other.PrivateComments)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.LeadName != null)
                    hash = hash * 59 + this.LeadName.GetHashCode();
                if (this.CommentsToProvider != null)
                    hash = hash * 59 + this.CommentsToProvider.GetHashCode();
                if (this.PrivateComments != null)
                    hash = hash * 59 + this.PrivateComments.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}