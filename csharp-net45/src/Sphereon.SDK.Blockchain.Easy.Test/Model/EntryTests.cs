/* 
 * Easy Blockchain API
 *
 * <b>The Easy Blockchain API is an easy to use API to store entries within chains. Currently it stores entries using the bitcoin blockchain by means of Factom or Multichain. The latter also allows for a private blockchain. In the future other solutions will be made available</b>    The flow is generally as follows:  1. Make sure a context is available using the / POST endpoint. Normally you only need one context. This is the place where backend providers and blockchain implementations are being specified.  2. Make sure a chain has been created using the /chain POST endpoint. Normally you only need one or a handful of chains. This is a relative expensive operation.  3. Store entries on the chain from step 2. The entries will contain the content and metadata you want to store forever on the specified chain.  4. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.10
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Sphereon.SDK.Blockchain.Easy.Api;
using Sphereon.SDK.Blockchain.Easy.Model;
using Sphereon.SDK.Blockchain.Easy.Client;
using System.Reflection;

namespace Sphereon.SDK.Blockchain.Easy.Test
{
    /// <summary>
    ///  Class for testing Entry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EntryTests
    {
        // TODO uncomment below to declare an instance variable for Entry
        //private Entry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Entry
            //instance = new Entry();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Entry
        /// </summary>
        [Test]
        public void EntryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Entry
            //Assert.IsInstanceOfType<Entry> (instance, "variable 'instance' is a Entry");
        }

        /// <summary>
        /// Test the property 'EntryData'
        /// </summary>
        [Test]
        public void EntryDataTest()
        {
            // TODO unit test for the property 'EntryData'
        }

    }

}
