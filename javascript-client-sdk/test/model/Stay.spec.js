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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.EasyTravelApi);
  }
}(this, function(expect, EasyTravelApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new EasyTravelApi.Stay();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('Stay', function() {
    it('should create an instance of Stay', function() {
      // uncomment below and update the code to test Stay
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be.a(EasyTravelApi.Stay);
    });

    it('should have the property start (base name: "start")', function() {
      // uncomment below and update the code to test the property start
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property end (base name: "end")', function() {
      // uncomment below and update the code to test the property end
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property roomId (base name: "roomId")', function() {
      // uncomment below and update the code to test the property roomId
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property roomName (base name: "roomName")', function() {
      // uncomment below and update the code to test the property roomName
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property boardBasisId (base name: "boardBasisId")', function() {
      // uncomment below and update the code to test the property boardBasisId
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property boardBasisName (base name: "boardBasisName")', function() {
      // uncomment below and update the code to test the property boardBasisName
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property numberOfRooms (base name: "numberOfRooms")', function() {
      // uncomment below and update the code to test the property numberOfRooms
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property paxPerRoom (base name: "paxPerRoom")', function() {
      // uncomment below and update the code to test the property paxPerRoom
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

    it('should have the property ages (base name: "ages")', function() {
      // uncomment below and update the code to test the property ages
      //var instane = new EasyTravelApi.Stay();
      //expect(instance).to.be();
    });

  });

}));
