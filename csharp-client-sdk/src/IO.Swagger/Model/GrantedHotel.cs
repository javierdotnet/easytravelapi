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
    /// Contains hotel information like rooms ids, etc
    /// </summary>
    [DataContract]
    public partial class GrantedHotel :  IEquatable<GrantedHotel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantedHotel" /> class.
        /// </summary>
        /// <param name="HotelId">Thid hotel id.</param>
        /// <param name="HotelName">This hotel name.</param>
        /// <param name="RoomIds">List of room ids valid for this hotel.</param>
        public GrantedHotel(string HotelId = null, string HotelName = null, List<RoomId> RoomIds = null)
        {
            this.HotelId = HotelId;
            this.HotelName = HotelName;
            this.RoomIds = RoomIds;
        }
        
        /// <summary>
        /// Thid hotel id
        /// </summary>
        /// <value>Thid hotel id</value>
        [DataMember(Name="hotelId", EmitDefaultValue=false)]
        public string HotelId { get; set; }
        /// <summary>
        /// This hotel name
        /// </summary>
        /// <value>This hotel name</value>
        [DataMember(Name="hotelName", EmitDefaultValue=false)]
        public string HotelName { get; set; }
        /// <summary>
        /// List of room ids valid for this hotel
        /// </summary>
        /// <value>List of room ids valid for this hotel</value>
        [DataMember(Name="roomIds", EmitDefaultValue=false)]
        public List<RoomId> RoomIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantedHotel {\n");
            sb.Append("  HotelId: ").Append(HotelId).Append("\n");
            sb.Append("  HotelName: ").Append(HotelName).Append("\n");
            sb.Append("  RoomIds: ").Append(RoomIds).Append("\n");
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
            return this.Equals(obj as GrantedHotel);
        }

        /// <summary>
        /// Returns true if GrantedHotel instances are equal
        /// </summary>
        /// <param name="other">Instance of GrantedHotel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantedHotel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HotelId == other.HotelId ||
                    this.HotelId != null &&
                    this.HotelId.Equals(other.HotelId)
                ) && 
                (
                    this.HotelName == other.HotelName ||
                    this.HotelName != null &&
                    this.HotelName.Equals(other.HotelName)
                ) && 
                (
                    this.RoomIds == other.RoomIds ||
                    this.RoomIds != null &&
                    this.RoomIds.SequenceEqual(other.RoomIds)
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
                if (this.HotelId != null)
                    hash = hash * 59 + this.HotelId.GetHashCode();
                if (this.HotelName != null)
                    hash = hash * 59 + this.HotelName.GetHashCode();
                if (this.RoomIds != null)
                    hash = hash * 59 + this.RoomIds.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
