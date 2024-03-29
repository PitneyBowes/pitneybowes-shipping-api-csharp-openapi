# shippingapi.Api.RateParcelsApi

All URIs are relative to *https://shipping-api-sandbox.pitneybowes.com/shippingservices*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RateParcel**](RateParcelsApi.md#rateparcel) | **POST** /v1/rates | Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request.



## RateParcel

> Shipment RateParcel (Shipment shipment, bool? xPBUnifiedErrorStructure = null, string xPBShipperRatePlan = null, string xPBIntegratorCarrierId = null, string xPBShipperCarrierAccountId = null, bool? includeDeliveryCommitment = null, string carrier = null)

Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using shippingapi.Api;
using shippingapi.Client;
using shippingapi.Model;

namespace Example
{
    public class RateParcelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://shipping-api-sandbox.pitneybowes.com/shippingservices";
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RateParcelsApi(Configuration.Default);
            var shipment = new Shipment(); // Shipment | Shipment request for Rates
            var xPBUnifiedErrorStructure = true;  // bool? | Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional)  (default to true)
            var xPBShipperRatePlan = xPBShipperRatePlan_example;  // string | USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) (optional) 
            var xPBIntegratorCarrierId = xPBIntegratorCarrierId_example;  // string | USPS Only. Negotiated services rate, if applicable. (optional) 
            var xPBShipperCarrierAccountId = xPBShipperCarrierAccountId_example;  // string | UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. (optional) 
            var includeDeliveryCommitment = true;  // bool? | When set to true, returns estimated transit time in days. (optional) 
            var carrier = carrier_example;  // string | Cross-Border only. Required for PB Cross-Border. Set this to PBI. (optional) 

            try
            {
                // Use this operation to rate a parcel before you print and purchase a shipment label. You can rate a parcel for multiple services and multiple parcel types with a single API request.
                Shipment result = apiInstance.RateParcel(shipment, xPBUnifiedErrorStructure, xPBShipperRatePlan, xPBIntegratorCarrierId, xPBShipperCarrierAccountId, includeDeliveryCommitment, carrier);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RateParcelsApi.RateParcel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipment** | [**Shipment**](Shipment.md)| Shipment request for Rates | 
 **xPBUnifiedErrorStructure** | **bool?**| Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. | [optional] [default to true]
 **xPBShipperRatePlan** | **string**| USPS Only. Shipper rate plan, if applicable. For more information, see [this FAQ](https://shipping.pitneybowes.com/faqs/rates.html#rate-plans-faq) | [optional] 
 **xPBIntegratorCarrierId** | **string**| USPS Only. Negotiated services rate, if applicable. | [optional] 
 **xPBShipperCarrierAccountId** | **string**| UPS (United Parcel Service) Only. The unique identifier returned in the shipperCarrierAccountId field by the [Register an Existing Carrier Account](https://shipping.pitneybowes.com/api/post-carrier-accounts-register.html) API. | [optional] 
 **includeDeliveryCommitment** | **bool?**| When set to true, returns estimated transit time in days. | [optional] 
 **carrier** | **string**| Cross-Border only. Required for PB Cross-Border. Set this to PBI. | [optional] 

### Return type

[**Shipment**](Shipment.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

