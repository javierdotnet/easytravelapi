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
    define(['ApiClient', 'model/Amount'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./Amount'));
  } else {
    // Browser globals (root is window)
    if (!root.EasyTravelApi) {
      root.EasyTravelApi = {};
    }
    root.EasyTravelApi.BoardPrice = factory(root.EasyTravelApi.ApiClient, root.EasyTravelApi.Amount);
  }
}(this, function(ApiClient, Amount) {
  'use strict';




  /**
   * The BoardPrice model module.
   * @module model/BoardPrice
   * @version 0.1.9
   */

  /**
   * Constructs a new <code>BoardPrice</code>.
   * An availabe board basis and its price
   * @alias module:model/BoardPrice
   * @class
   */
  var exports = function() {
    var _this = this;












  };

  /**
   * Constructs a <code>BoardPrice</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/BoardPrice} obj Optional instance to populate.
   * @return {module:model/BoardPrice} The populated <code>BoardPrice</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('key')) {
        obj['key'] = ApiClient.convertToType(data['key'], 'String');
      }
      if (data.hasOwnProperty('boardBasisId')) {
        obj['boardBasisId'] = ApiClient.convertToType(data['boardBasisId'], 'String');
      }
      if (data.hasOwnProperty('boardBasisName')) {
        obj['boardBasisName'] = ApiClient.convertToType(data['boardBasisName'], 'String');
      }
      if (data.hasOwnProperty('retailPrice')) {
        obj['retailPrice'] = Amount.constructFromObject(data['retailPrice']);
      }
      if (data.hasOwnProperty('netPrice')) {
        obj['netPrice'] = Amount.constructFromObject(data['netPrice']);
      }
      if (data.hasOwnProperty('commission')) {
        obj['commission'] = Amount.constructFromObject(data['commission']);
      }
      if (data.hasOwnProperty('offer')) {
        obj['offer'] = ApiClient.convertToType(data['offer'], 'Boolean');
      }
      if (data.hasOwnProperty('offerText')) {
        obj['offerText'] = ApiClient.convertToType(data['offerText'], 'String');
      }
      if (data.hasOwnProperty('onRequest')) {
        obj['onRequest'] = ApiClient.convertToType(data['onRequest'], 'Boolean');
      }
      if (data.hasOwnProperty('onRequestText')) {
        obj['onRequestText'] = ApiClient.convertToType(data['onRequestText'], 'String');
      }
      if (data.hasOwnProperty('nonRefundable')) {
        obj['nonRefundable'] = ApiClient.convertToType(data['nonRefundable'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * Identifier for this room combination and board basis. You will use it in next steps
   * @member {String} key
   */
  exports.prototype['key'] = undefined;
  /**
   * Board basis id
   * @member {String} boardBasisId
   */
  exports.prototype['boardBasisId'] = undefined;
  /**
   * Board basis name
   * @member {String} boardBasisName
   */
  exports.prototype['boardBasisName'] = undefined;
  /**
   * @member {module:model/Amount} retailPrice
   */
  exports.prototype['retailPrice'] = undefined;
  /**
   * @member {module:model/Amount} netPrice
   */
  exports.prototype['netPrice'] = undefined;
  /**
   * @member {module:model/Amount} commission
   */
  exports.prototype['commission'] = undefined;
  /**
   * A flag to state that this price is an offer
   * @member {Boolean} offer
   * @default false
   */
  exports.prototype['offer'] = false;
  /**
   * The offer description, if this is an offer price
   * @member {String} offerText
   */
  exports.prototype['offerText'] = undefined;
  /**
   * A flag to state that this price is only available on request
   * @member {Boolean} onRequest
   * @default false
   */
  exports.prototype['onRequest'] = false;
  /**
   * Describes why this price is on request
   * @member {String} onRequestText
   */
  exports.prototype['onRequestText'] = undefined;
  /**
   * A flag to state that this price is not refundable. No cancellation is allowed
   * @member {Boolean} nonRefundable
   * @default false
   */
  exports.prototype['nonRefundable'] = false;



  return exports;
}));


