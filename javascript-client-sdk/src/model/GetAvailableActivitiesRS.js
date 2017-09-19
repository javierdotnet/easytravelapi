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
    define(['ApiClient', 'model/AvailableActivity'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./AvailableActivity'));
  } else {
    // Browser globals (root is window)
    if (!root.EasyTravelApi) {
      root.EasyTravelApi = {};
    }
    root.EasyTravelApi.GetAvailableActivitiesRS = factory(root.EasyTravelApi.ApiClient, root.EasyTravelApi.AvailableActivity);
  }
}(this, function(ApiClient, AvailableActivity) {
  'use strict';




  /**
   * The GetAvailableActivitiesRS model module.
   * @module model/GetAvailableActivitiesRS
   * @version 0.1.9
   */

  /**
   * Constructs a new <code>GetAvailableActivitiesRS</code>.
   * Response with the list of available activities
   * @alias module:model/GetAvailableActivitiesRS
   * @class
   */
  var exports = function() {
    var _this = this;





  };

  /**
   * Constructs a <code>GetAvailableActivitiesRS</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GetAvailableActivitiesRS} obj Optional instance to populate.
   * @return {module:model/GetAvailableActivitiesRS} The populated <code>GetAvailableActivitiesRS</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('statusCode')) {
        obj['statusCode'] = ApiClient.convertToType(data['statusCode'], 'Number');
      }
      if (data.hasOwnProperty('msg')) {
        obj['msg'] = ApiClient.convertToType(data['msg'], 'String');
      }
      if (data.hasOwnProperty('systemTime')) {
        obj['systemTime'] = ApiClient.convertToType(data['systemTime'], 'String');
      }
      if (data.hasOwnProperty('availableActivities')) {
        obj['availableActivities'] = ApiClient.convertToType(data['availableActivities'], [AvailableActivity]);
      }
    }
    return obj;
  }

  /**
   * status code for the operation. It will be 200 if it was OK and any other value if something went wrong. Provider dependant
   * @member {Number} statusCode
   */
  exports.prototype['statusCode'] = undefined;
  /**
   * error message, if needed
   * @member {String} msg
   */
  exports.prototype['msg'] = undefined;
  /**
   * System time in ISO8651 format. Useful for bug resolution
   * @member {String} systemTime
   */
  exports.prototype['systemTime'] = undefined;
  /**
   * List of the available activities for that resort and dates
   * @member {Array.<module:model/AvailableActivity>} availableActivities
   */
  exports.prototype['availableActivities'] = undefined;



  return exports;
}));


