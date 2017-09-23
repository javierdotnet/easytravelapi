/**
 * EasyTravelApi
 * API for travel agents
 *
 * OpenAPI spec version: 0.1.9
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.EasyTravelApi) {
      root.EasyTravelApi = {};
    }
    root.EasyTravelApi.Amount = factory(root.EasyTravelApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The Amount model module.
   * @module model/Amount
   * @version 0.1.9
   */

  /**
   * Constructs a new <code>Amount</code>.
   * A currency - value pair
   * @alias module:model/Amount
   * @class
   */
  var exports = function() {
    var _this = this;



  };

  /**
   * Constructs a <code>Amount</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Amount} obj Optional instance to populate.
   * @return {module:model/Amount} The populated <code>Amount</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('currencyIsoCode')) {
        obj['currencyIsoCode'] = ApiClient.convertToType(data['currencyIsoCode'], 'String');
      }
      if (data.hasOwnProperty('value')) {
        obj['value'] = ApiClient.convertToType(data['value'], 'Number');
      }
    }
    return obj;
  }

  /**
   * The currency ISO code
   * @member {String} currencyIsoCode
   */
  exports.prototype['currencyIsoCode'] = undefined;
  /**
   * The amount value, expressed in this currency
   * @member {Number} value
   */
  exports.prototype['value'] = undefined;



  return exports;
}));

