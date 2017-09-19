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
    /// An available transfer
    /// </summary>
    [DataContract]
    public partial class AvailableTransfer :  IEquatable<AvailableTransfer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableTransfer" /> class.
        /// </summary>
        /// <param name="Key">Identifier for this transfer price. You will use it in next steps.</param>
        /// <param name="Type">Type of transfer. E.G. SHUTTLE, PRIVATE.</param>
        /// <param name="Vehicle">Vehicle.</param>
        /// <param name="Description">Description of the service.</param>
        /// <param name="RetailPrice">RetailPrice.</param>
        /// <param name="NetPrice">NetPrice.</param>
        /// <param name="Commission">Commission.</param>
        /// <param name="Offer">A flag to state that this price is an offer (default to false).</param>
        /// <param name="OfferText">The offer description, if this is an offer price.</param>
        /// <param name="OnRequest">A flag to state that this price is only available on request (default to false).</param>
        /// <param name="OnRequestText">Describes why this price is on request.</param>
        /// <param name="NonRefundable">A flag to state that this price is not refundable. No cancellation is allowed (default to false).</param>
        public AvailableTransfer(string Key = null, string Type = null, string Vehicle = null, string Description = null, Amount RetailPrice = null, Amount NetPrice = null, Amount Commission = null, bool? Offer = null, string OfferText = null, bool? OnRequest = null, string OnRequestText = null, bool? NonRefundable = null)
        {
            this.Key = Key;
            this.Type = Type;
            this.Vehicle = Vehicle;
            this.Description = Description;
            this.RetailPrice = RetailPrice;
            this.NetPrice = NetPrice;
            this.Commission = Commission;
            // use default value if no "Offer" provided
            if (Offer == null)
            {
                this.Offer = false;
            }
            else
            {
                this.Offer = Offer;
            }
            this.OfferText = OfferText;
            // use default value if no "OnRequest" provided
            if (OnRequest == null)
            {
                this.OnRequest = false;
            }
            else
            {
                this.OnRequest = OnRequest;
            }
            this.OnRequestText = OnRequestText;
            // use default value if no "NonRefundable" provided
            if (NonRefundable == null)
            {
                this.NonRefundable = false;
            }
            else
            {
                this.NonRefundable = NonRefundable;
            }
        }
        
        /// <summary>
        /// Identifier for this transfer price. You will use it in next steps
        /// </summary>
        /// <value>Identifier for this transfer price. You will use it in next steps</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Type of transfer. E.G. SHUTTLE, PRIVATE
        /// </summary>
        /// <value>Type of transfer. E.G. SHUTTLE, PRIVATE</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Vehicle
        /// </summary>
        /// <value>Vehicle</value>
        [DataMember(Name="vehicle", EmitDefaultValue=false)]
        public string Vehicle { get; set; }
        /// <summary>
        /// Description of the service
        /// </summary>
        /// <value>Description of the service</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets RetailPrice
        /// </summary>
        [DataMember(Name="retailPrice", EmitDefaultValue=false)]
        public Amount RetailPrice { get; set; }
        /// <summary>
        /// Gets or Sets NetPrice
        /// </summary>
        [DataMember(Name="netPrice", EmitDefaultValue=false)]
        public Amount NetPrice { get; set; }
        /// <summary>
        /// Gets or Sets Commission
        /// </summary>
        [DataMember(Name="commission", EmitDefaultValue=false)]
        public Amount Commission { get; set; }
        /// <summary>
        /// A flag to state that this price is an offer
        /// </summary>
        /// <value>A flag to state that this price is an offer</value>
        [DataMember(Name="offer", EmitDefaultValue=false)]
        public bool? Offer { get; set; }
        /// <summary>
        /// The offer description, if this is an offer price
        /// </summary>
        /// <value>The offer description, if this is an offer price</value>
        [DataMember(Name="offerText", EmitDefaultValue=false)]
        public string OfferText { get; set; }
        /// <summary>
        /// A flag to state that this price is only available on request
        /// </summary>
        /// <value>A flag to state that this price is only available on request</value>
        [DataMember(Name="onRequest", EmitDefaultValue=false)]
        public bool? OnRequest { get; set; }
        /// <summary>
        /// Describes why this price is on request
        /// </summary>
        /// <value>Describes why this price is on request</value>
        [DataMember(Name="onRequestText", EmitDefaultValue=false)]
        public string OnRequestText { get; set; }
        /// <summary>
        /// A flag to state that this price is not refundable. No cancellation is allowed
        /// </summary>
        /// <value>A flag to state that this price is not refundable. No cancellation is allowed</value>
        [DataMember(Name="nonRefundable", EmitDefaultValue=false)]
        public bool? NonRefundable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableTransfer {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vehicle: ").Append(Vehicle).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  NetPrice: ").Append(NetPrice).Append("\n");
            sb.Append("  Commission: ").Append(Commission).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  OfferText: ").Append(OfferText).Append("\n");
            sb.Append("  OnRequest: ").Append(OnRequest).Append("\n");
            sb.Append("  OnRequestText: ").Append(OnRequestText).Append("\n");
            sb.Append("  NonRefundable: ").Append(NonRefundable).Append("\n");
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
            return this.Equals(obj as AvailableTransfer);
        }

        /// <summary>
        /// Returns true if AvailableTransfer instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableTransfer other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Vehicle == other.Vehicle ||
                    this.Vehicle != null &&
                    this.Vehicle.Equals(other.Vehicle)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.RetailPrice == other.RetailPrice ||
                    this.RetailPrice != null &&
                    this.RetailPrice.Equals(other.RetailPrice)
                ) && 
                (
                    this.NetPrice == other.NetPrice ||
                    this.NetPrice != null &&
                    this.NetPrice.Equals(other.NetPrice)
                ) && 
                (
                    this.Commission == other.Commission ||
                    this.Commission != null &&
                    this.Commission.Equals(other.Commission)
                ) && 
                (
                    this.Offer == other.Offer ||
                    this.Offer != null &&
                    this.Offer.Equals(other.Offer)
                ) && 
                (
                    this.OfferText == other.OfferText ||
                    this.OfferText != null &&
                    this.OfferText.Equals(other.OfferText)
                ) && 
                (
                    this.OnRequest == other.OnRequest ||
                    this.OnRequest != null &&
                    this.OnRequest.Equals(other.OnRequest)
                ) && 
                (
                    this.OnRequestText == other.OnRequestText ||
                    this.OnRequestText != null &&
                    this.OnRequestText.Equals(other.OnRequestText)
                ) && 
                (
                    this.NonRefundable == other.NonRefundable ||
                    this.NonRefundable != null &&
                    this.NonRefundable.Equals(other.NonRefundable)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Vehicle != null)
                    hash = hash * 59 + this.Vehicle.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.RetailPrice != null)
                    hash = hash * 59 + this.RetailPrice.GetHashCode();
                if (this.NetPrice != null)
                    hash = hash * 59 + this.NetPrice.GetHashCode();
                if (this.Commission != null)
                    hash = hash * 59 + this.Commission.GetHashCode();
                if (this.Offer != null)
                    hash = hash * 59 + this.Offer.GetHashCode();
                if (this.OfferText != null)
                    hash = hash * 59 + this.OfferText.GetHashCode();
                if (this.OnRequest != null)
                    hash = hash * 59 + this.OnRequest.GetHashCode();
                if (this.OnRequestText != null)
                    hash = hash * 59 + this.OnRequestText.GetHashCode();
                if (this.NonRefundable != null)
                    hash = hash * 59 + this.NonRefundable.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
