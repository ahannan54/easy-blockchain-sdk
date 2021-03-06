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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.EasyBlockchainApi);
  }
}(this, function(expect, EasyBlockchainApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new EasyBlockchainApi.AllApi();
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

  describe('AllApi', function() {
    describe('chainIdExists', function() {
      it('should call chainIdExists successfully', function(done) {
        //uncomment below and update the code to test chainIdExists
        //instance.chainIdExists(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('createBackend', function() {
      it('should call createBackend successfully', function(done) {
        //uncomment below and update the code to test createBackend
        //instance.createBackend(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('createChain', function() {
      it('should call createChain successfully', function(done) {
        //uncomment below and update the code to test createChain
        //instance.createChain(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('createContext', function() {
      it('should call createContext successfully', function(done) {
        //uncomment below and update the code to test createContext
        //instance.createContext(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('createEntry', function() {
      it('should call createEntry successfully', function(done) {
        //uncomment below and update the code to test createEntry
        //instance.createEntry(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('deleteBackend', function() {
      it('should call deleteBackend successfully', function(done) {
        //uncomment below and update the code to test deleteBackend
        //instance.deleteBackend(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('determineChainId', function() {
      it('should call determineChainId successfully', function(done) {
        //uncomment below and update the code to test determineChainId
        //instance.determineChainId(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('determineEntryId', function() {
      it('should call determineEntryId successfully', function(done) {
        //uncomment below and update the code to test determineEntryId
        //instance.determineEntryId(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('entryById', function() {
      it('should call entryById successfully', function(done) {
        //uncomment below and update the code to test entryById
        //instance.entryById(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('entryByRequest', function() {
      it('should call entryByRequest successfully', function(done) {
        //uncomment below and update the code to test entryByRequest
        //instance.entryByRequest(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('entryIdExists', function() {
      it('should call entryIdExists successfully', function(done) {
        //uncomment below and update the code to test entryIdExists
        //instance.entryIdExists(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('findBackends', function() {
      it('should call findBackends successfully', function(done) {
        //uncomment below and update the code to test findBackends
        //instance.findBackends(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('firstEntry', function() {
      it('should call firstEntry successfully', function(done) {
        //uncomment below and update the code to test firstEntry
        //instance.firstEntry(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('getBackend', function() {
      it('should call getBackend successfully', function(done) {
        //uncomment below and update the code to test getBackend
        //instance.getBackend(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('getContext', function() {
      it('should call getContext successfully', function(done) {
        //uncomment below and update the code to test getContext
        //instance.getContext(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('lastEntry', function() {
      it('should call lastEntry successfully', function(done) {
        //uncomment below and update the code to test lastEntry
        //instance.lastEntry(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('listBackends', function() {
      it('should call listBackends successfully', function(done) {
        //uncomment below and update the code to test listBackends
        //instance.listBackends(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('nextEntryById', function() {
      it('should call nextEntryById successfully', function(done) {
        //uncomment below and update the code to test nextEntryById
        //instance.nextEntryById(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('nextEntryByRequest', function() {
      it('should call nextEntryByRequest successfully', function(done) {
        //uncomment below and update the code to test nextEntryByRequest
        //instance.nextEntryByRequest(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('previousEntryById', function() {
      it('should call previousEntryById successfully', function(done) {
        //uncomment below and update the code to test previousEntryById
        //instance.previousEntryById(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('previousEntryByRequest', function() {
      it('should call previousEntryByRequest successfully', function(done) {
        //uncomment below and update the code to test previousEntryByRequest
        //instance.previousEntryByRequest(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
  });

}));
