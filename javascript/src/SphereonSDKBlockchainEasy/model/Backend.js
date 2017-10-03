/**
 * Easy Blockchain API
 * <b>The Easy Blockchain API is an easy to use API to store entries within chains. Currently it stores entries using the bitcoin blockchain by means of Factom or Multichain. The latter also allows for a private blockchain. In the future other solutions will be made available</b>    The flow is generally as follows:  1. Make sure a context is available using the / POST endpoint. Normally you only need one context. This is the place where backend providers and blockchain implementations are being specified.  2. Make sure a chain has been created using the /chain POST endpoint. Normally you only need one or a handful of chains. This is a relative expensive operation.  3. Store entries on the chain from step 2. The entries will contain the content and metadata you want to store forever on the specified chain.  4. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.2.3
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['SphereonSDKBlockchainEasy/ApiClient', 'SphereonSDKBlockchainEasy/model/Access', 'SphereonSDKBlockchainEasy/model/RpcProvider'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./Access'), require('./RpcProvider'));
  } else {
    // Browser globals (root is window)
    if (!root.EasyBlockchainApi) {
      root.EasyBlockchainApi = {};
    }
    root.EasyBlockchainApi.Backend = factory(root.EasyBlockchainApi.ApiClient, root.EasyBlockchainApi.Access, root.EasyBlockchainApi.RpcProvider);
  }
}(this, function(ApiClient, Access, RpcProvider) {
  'use strict';




  /**
   * The Backend model module.
   * @module SphereonSDKBlockchainEasy/model/Backend
   * @version 0.9
   */

  /**
   * Constructs a new <code>Backend</code>.
   * Backend
   * @alias module:SphereonSDKBlockchainEasy/model/Backend
   * @class
   */
  var exports = function() {
    var _this = this;










  };

  /**
   * Constructs a <code>Backend</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:SphereonSDKBlockchainEasy/model/Backend} obj Optional instance to populate.
   * @return {module:SphereonSDKBlockchainEasy/model/Backend} The populated <code>Backend</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('rpcProviders')) {
        obj['rpcProviders'] = ApiClient.convertToType(data['rpcProviders'], [RpcProvider]);
      }
      if (data.hasOwnProperty('apiVersion')) {
        obj['apiVersion'] = ApiClient.convertToType(data['apiVersion'], 'Number');
      }
      if (data.hasOwnProperty('ledgerName')) {
        obj['ledgerName'] = ApiClient.convertToType(data['ledgerName'], 'String');
      }
      if (data.hasOwnProperty('implementation')) {
        obj['implementation'] = ApiClient.convertToType(data['implementation'], 'String');
      }
      if (data.hasOwnProperty('start')) {
        obj['start'] = ApiClient.convertToType(data['start'], 'Date');
      }
      if (data.hasOwnProperty('end')) {
        obj['end'] = ApiClient.convertToType(data['end'], 'Date');
      }
      if (data.hasOwnProperty('dataStructure')) {
        obj['dataStructure'] = ApiClient.convertToType(data['dataStructure'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('externalAccess')) {
        obj['externalAccess'] = Access.constructFromObject(data['externalAccess']);
      }
    }
    return obj;
  }

  /**
   * @member {Array.<module:SphereonSDKBlockchainEasy/model/RpcProvider>} rpcProviders
   */
  exports.prototype['rpcProviders'] = undefined;
  /**
   * @member {Number} apiVersion
   */
  exports.prototype['apiVersion'] = undefined;
  /**
   * @member {String} ledgerName
   */
  exports.prototype['ledgerName'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainEasy/model/Backend.ImplementationEnum} implementation
   */
  exports.prototype['implementation'] = undefined;
  /**
   * @member {Date} start
   */
  exports.prototype['start'] = undefined;
  /**
   * @member {Date} end
   */
  exports.prototype['end'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainEasy/model/Backend.DataStructureEnum} dataStructure
   */
  exports.prototype['dataStructure'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainEasy/model/Access} externalAccess
   */
  exports.prototype['externalAccess'] = undefined;


  /**
   * Allowed values for the <code>implementation</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ImplementationEnum = {
    /**
     * value: "Bitcoin"
     * @const
     */
    "Bitcoin": "Bitcoin",
    /**
     * value: "None"
     * @const
     */
    "None": "None"  };

  /**
   * Allowed values for the <code>dataStructure</code> property.
   * @enum {String}
   * @readonly
   */
  exports.DataStructureEnum = {
    /**
     * value: "Factom"
     * @const
     */
    "Factom": "Factom",
    /**
     * value: "Multichain"
     * @const
     */
    "Multichain": "Multichain"  };


  return exports;
}));

