/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using shippingapi.Client;
using shippingapi.Api;
using shippingapi.Model;

namespace shippingapi.Test
{
    /// <summary>
    ///  Class for testing ContainerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContainerApiTests
    {
        private ContainerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContainerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContainerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ContainerApi
            //Assert.IsInstanceOf(typeof(ContainerApi), instance);
        }

        
        /// <summary>
        /// Test GetContainerizedParcelsLabels
        /// </summary>
        [Test]
        public void GetContainerizedParcelsLabelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xPBTransactionId = null;
            //Manifest manifest = null;
            //bool? xPBUnifiedErrorStructure = null;
            //var response = instance.GetContainerizedParcelsLabels(xPBTransactionId, manifest, xPBUnifiedErrorStructure);
            //Assert.IsInstanceOf(typeof(ContainerManifestResponse), response, "response is ContainerManifestResponse");
        }
        
    }

}
