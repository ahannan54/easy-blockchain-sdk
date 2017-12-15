/* 
 * Easy Blockchain API
 *
 * <b>The Easy Blockchain API is an easy to use API to store entries within chains. Currently it stores entries using the bitcoin blockchain by means of Factom or Multichain. The latter also allows for a private blockchain. In the future other solutions will be made available</b>    The flow is generally as follows:  1. Make sure a context is available using the / POST endpoint. Normally you only need one context. This is the place where backend providers and blockchain implementations are being specified.  2. Make sure a chain has been created using the /chain POST endpoint. Normally you only need one or a handful of chains. This is a relative expensive operation.  3. Store entries on the chain from step 2. The entries will contain the content and metadata you want to store forever on the specified chain.  4. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.10
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Sphereon.SDK.Blockchain.Easy.Client;
using Sphereon.SDK.Blockchain.Easy.Api;
using Sphereon.SDK.Blockchain.Easy.Model;

namespace Sphereon.SDK.Blockchain.Easy.Test
{
    /// <summary>
    ///  Class for testing AllApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AllApiTests
    {
        private AllApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AllApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AllApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AllApi
            //Assert.IsInstanceOfType(typeof(AllApi), instance, "instance is a AllApi");
        }

        
        /// <summary>
        /// Test ChainIdExists
        /// </summary>
        [Test]
        public void ChainIdExistsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //var response = instance.ChainIdExists(context, chainId);
            //Assert.IsInstanceOf<IdResponse> (response, "response is IdResponse");
        }
        
        /// <summary>
        /// Test CreateBackend
        /// </summary>
        [Test]
        public void CreateBackendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Backend backend = null;
            //var response = instance.CreateBackend(backend);
            //Assert.IsInstanceOf<Backend> (response, "response is Backend");
        }
        
        /// <summary>
        /// Test CreateChain
        /// </summary>
        [Test]
        public void CreateChainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //Chain chain = null;
            //var response = instance.CreateChain(context, chain);
            //Assert.IsInstanceOf<CommittedChainResponse> (response, "response is CommittedChainResponse");
        }
        
        /// <summary>
        /// Test CreateContext
        /// </summary>
        [Test]
        public void CreateContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Context context = null;
            //var response = instance.CreateContext(context);
            //Assert.IsInstanceOf<Context> (response, "response is Context");
        }
        
        /// <summary>
        /// Test CreateEntry
        /// </summary>
        [Test]
        public void CreateEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //Entry entry = null;
            //DateTime? currentAnchorTime = null;
            //var response = instance.CreateEntry(context, chainId, entry, currentAnchorTime);
            //Assert.IsInstanceOf<CommittedEntryResponse> (response, "response is CommittedEntryResponse");
        }
        
        /// <summary>
        /// Test DeleteBackend
        /// </summary>
        [Test]
        public void DeleteBackendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backendId = null;
            //instance.DeleteBackend(backendId);
            
        }
        
        /// <summary>
        /// Test DetermineChainId
        /// </summary>
        [Test]
        public void DetermineChainIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //Chain chain = null;
            //bool? checkExistence = null;
            //var response = instance.DetermineChainId(context, chain, checkExistence);
            //Assert.IsInstanceOf<IdResponse> (response, "response is IdResponse");
        }
        
        /// <summary>
        /// Test DetermineEntryId
        /// </summary>
        [Test]
        public void DetermineEntryIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //Entry entry = null;
            //bool? checkExistence = null;
            //var response = instance.DetermineEntryId(context, chainId, entry, checkExistence);
            //Assert.IsInstanceOf<IdResponse> (response, "response is IdResponse");
        }
        
        /// <summary>
        /// Test EntryById
        /// </summary>
        [Test]
        public void EntryByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //string entryId = null;
            //DateTime? currentAnchorTime = null;
            //var response = instance.EntryById(context, chainId, entryId, currentAnchorTime);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
        /// <summary>
        /// Test EntryByRequest
        /// </summary>
        [Test]
        public void EntryByRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //Entry entry = null;
            //DateTime? currentAnchorTime = null;
            //var response = instance.EntryByRequest(context, chainId, entry, currentAnchorTime);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
        /// <summary>
        /// Test EntryIdExists
        /// </summary>
        [Test]
        public void EntryIdExistsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //string entryId = null;
            //var response = instance.EntryIdExists(context, chainId, entryId);
            //Assert.IsInstanceOf<IdResponse> (response, "response is IdResponse");
        }
        
        /// <summary>
        /// Test FindBackends
        /// </summary>
        [Test]
        public void FindBackendsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backendId = null;
            //bool? includePublic = null;
            //var response = instance.FindBackends(backendId, includePublic);
            //Assert.IsInstanceOf<List<Backend>> (response, "response is List<Backend>");
        }
        
        /// <summary>
        /// Test FirstEntry
        /// </summary>
        [Test]
        public void FirstEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //var response = instance.FirstEntry(context, chainId);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
        /// <summary>
        /// Test GetBackend
        /// </summary>
        [Test]
        public void GetBackendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string backendId = null;
            //bool? includePublic = null;
            //var response = instance.GetBackend(backendId, includePublic);
            //Assert.IsInstanceOf<Backend> (response, "response is Backend");
        }
        
        /// <summary>
        /// Test GetContext
        /// </summary>
        [Test]
        public void GetContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //var response = instance.GetContext(context);
            //Assert.IsInstanceOf<Context> (response, "response is Context");
        }
        
        /// <summary>
        /// Test LastEntry
        /// </summary>
        [Test]
        public void LastEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //var response = instance.LastEntry(context, chainId);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
        /// <summary>
        /// Test ListBackends
        /// </summary>
        [Test]
        public void ListBackendsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListBackends();
            //Assert.IsInstanceOf<List<Backend>> (response, "response is List<Backend>");
        }
        
        /// <summary>
        /// Test NextEntryById
        /// </summary>
        [Test]
        public void NextEntryByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //string entryId = null;
            //DateTime? currentAnchorTime = null;
            //var response = instance.NextEntryById(context, chainId, entryId, currentAnchorTime);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
        /// <summary>
        /// Test NextEntryByRequest
        /// </summary>
        [Test]
        public void NextEntryByRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //Entry entry = null;
            //DateTime? currentAnchorTime = null;
            //var response = instance.NextEntryByRequest(context, chainId, entry, currentAnchorTime);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
        /// <summary>
        /// Test PreviousEntryById
        /// </summary>
        [Test]
        public void PreviousEntryByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //string entryId = null;
            //DateTime? currentAnchorTime = null;
            //var response = instance.PreviousEntryById(context, chainId, entryId, currentAnchorTime);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
        /// <summary>
        /// Test PreviousEntryByRequest
        /// </summary>
        [Test]
        public void PreviousEntryByRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string context = null;
            //string chainId = null;
            //Entry entry = null;
            //DateTime? currentAnchorTime = null;
            //var response = instance.PreviousEntryByRequest(context, chainId, entry, currentAnchorTime);
            //Assert.IsInstanceOf<AnchoredEntryResponse> (response, "response is AnchoredEntryResponse");
        }
        
    }

}
