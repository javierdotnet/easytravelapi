# easytravelapi

EasyTravelApi - JavaScript client for easy_travel_api
API for travel agents
This SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 0.1.9
- Package version: 0.1.10
- Build package: class io.swagger.codegen.languages.JavascriptClientCodegen

## Installation

### For [Node.js](https://nodejs.org/)

#### npm

To publish the library as a [npm](https://www.npmjs.com/),
please follow the procedure in ["Publishing npm packages"](https://docs.npmjs.com/getting-started/publishing-npm-packages).

Then install it via:

```shell
npm install easytravelapi --save
```

#### git
#
If the library is hosted at a git repository, e.g.
https://github.com/YOUR_USERNAME/easy_travel_api
then install it via:

```shell
    npm install YOUR_USERNAME/easytravelapi --save
```

### For browser

The library also works in the browser environment via npm and [browserify](http://browserify.org/). After following
the above steps with Node.js and installing browserify with `npm install -g browserify`,
perform the following (assuming *main.js* is your entry file):

```shell
browserify main.js > bundle.js
```

Then include *bundle.js* in the HTML pages.

## Getting Started

Please follow the [installation](#installation) instruction and execute the following JS code:

```javascript
var EasyTravelApi = require('easytravelapi');

var api = new EasyTravelApi.DefaultApi()

var authtoken = "authtoken_example"; // {String} Auth token provided by your partner, and possibly renewed by using the /commons/newtoken method

var opts = { 
  'body': new EasyTravelApi.BookActivityRQ() // {BookActivityRQ} 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.bookActivity(authtoken, opts, callback);

```

## Documentation for API Endpoints

All URIs are relative to *http://test.easytravelapi.com/rest*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*EasyTravelApi.DefaultApi* | [**bookActivity**](docs/DefaultApi.md#bookActivity) | **PUT** /{authtoken}/activity/booking | Book an activity
*EasyTravelApi.DefaultApi* | [**bookHotel**](docs/DefaultApi.md#bookHotel) | **PUT** /{authtoken}/hotel/booking | Use this method to confirm a hotel service
*EasyTravelApi.DefaultApi* | [**bookTransfer**](docs/DefaultApi.md#bookTransfer) | **PUT** /{authtoken}/transfer/booking | Use this method to confirm a transfer service booking
*EasyTravelApi.DefaultApi* | [**cancelBooking**](docs/DefaultApi.md#cancelBooking) | **DELETE** /{authtoken}/commons/booking/{bookingid} | Method to cancel a service booking
*EasyTravelApi.DefaultApi* | [**confirmServices**](docs/DefaultApi.md#confirmServices) | **POST** /{authtoken}/channel/confirm | Use this method to confirm or reject services
*EasyTravelApi.DefaultApi* | [**getActivityPriceDetails**](docs/DefaultApi.md#getActivityPriceDetails) | **GET** /{authtoken}/activity/pricedetails/{key} | Get extra info
*EasyTravelApi.DefaultApi* | [**getAvailabeTransfers**](docs/DefaultApi.md#getAvailabeTransfers) | **GET** /{authtoken}/transfer/available | Use this method to know which transfers are available and their prices
*EasyTravelApi.DefaultApi* | [**getAvailableActivities**](docs/DefaultApi.md#getAvailableActivities) | **GET** /{authtoken}/activity/available | Get available activities
*EasyTravelApi.DefaultApi* | [**getAvailableHotels**](docs/DefaultApi.md#getAvailableHotels) | **GET** /{authtoken}/hotel/available | Use this method to know which hotels are available and their prices
*EasyTravelApi.DefaultApi* | [**getBookings**](docs/DefaultApi.md#getBookings) | **GET** /{authtoken}/commons/bookings | Method to get a list of bookings
*EasyTravelApi.DefaultApi* | [**getDataSheet**](docs/DefaultApi.md#getDataSheet) | **GET** /{authtoken}/commons/datasheet/{resourceid} | Method to get a resource data sheet. E.g. descriptions, images, features
*EasyTravelApi.DefaultApi* | [**getGrantedHotels**](docs/DefaultApi.md#getGrantedHotels) | **GET** /{authtoken}/channel/granted | Use this method to know which hotels are you allowed to update. It provides the ids to be used by the channel manager
*EasyTravelApi.DefaultApi* | [**getHotelPriceDetails**](docs/DefaultApi.md#getHotelPriceDetails) | **GET** /{authtoken}/hotel/pricedetails/{key} | Use this methos to guess cancellation costs and important remarks regarding a price
*EasyTravelApi.DefaultApi* | [**getPortfolio**](docs/DefaultApi.md#getPortfolio) | **GET** /{authtoken}/commons/portfolio | Method to get the whole product tree
*EasyTravelApi.DefaultApi* | [**getRoomingList**](docs/DefaultApi.md#getRoomingList) | **GET** /{authtoken}/channel/roominglist | Use this method to download the list of hotel bookings
*EasyTravelApi.DefaultApi* | [**getToken**](docs/DefaultApi.md#getToken) | **GET** /{authtoken}/commons/newtoken | Use this method to get or renew your authentication token
*EasyTravelApi.DefaultApi* | [**getTransferPriceDetails**](docs/DefaultApi.md#getTransferPriceDetails) | **GET** /{authtoken}/transfer/pricedetails/{key} | Use this method to guess cancellation costs and important remarks
*EasyTravelApi.DefaultApi* | [**update**](docs/DefaultApi.md#update) | **PUT** /{authtoken}/channel/hotel/inventory | Use this method to update hotel inventory


## Documentation for Models

 - [EasyTravelApi.Allocation](docs/Allocation.md)
 - [EasyTravelApi.Amount](docs/Amount.md)
 - [EasyTravelApi.AvailableActivity](docs/AvailableActivity.md)
 - [EasyTravelApi.AvailableHotel](docs/AvailableHotel.md)
 - [EasyTravelApi.AvailableTransfer](docs/AvailableTransfer.md)
 - [EasyTravelApi.BoardPrice](docs/BoardPrice.md)
 - [EasyTravelApi.BookActivityRQ](docs/BookActivityRQ.md)
 - [EasyTravelApi.BookActivityRS](docs/BookActivityRS.md)
 - [EasyTravelApi.BookHotelRQ](docs/BookHotelRQ.md)
 - [EasyTravelApi.BookHotelRS](docs/BookHotelRS.md)
 - [EasyTravelApi.BookTransferRQ](docs/BookTransferRQ.md)
 - [EasyTravelApi.BookTransferRS](docs/BookTransferRS.md)
 - [EasyTravelApi.Booking](docs/Booking.md)
 - [EasyTravelApi.CancelBookingRS](docs/CancelBookingRS.md)
 - [EasyTravelApi.CancellationCost](docs/CancellationCost.md)
 - [EasyTravelApi.City](docs/City.md)
 - [EasyTravelApi.ConfirmServicesRQ](docs/ConfirmServicesRQ.md)
 - [EasyTravelApi.ConfirmServicesRS](docs/ConfirmServicesRS.md)
 - [EasyTravelApi.Country](docs/Country.md)
 - [EasyTravelApi.GetActivityPriceDetailsRS](docs/GetActivityPriceDetailsRS.md)
 - [EasyTravelApi.GetAvailableActivitiesRS](docs/GetAvailableActivitiesRS.md)
 - [EasyTravelApi.GetAvailableHotelsRS](docs/GetAvailableHotelsRS.md)
 - [EasyTravelApi.GetAvailableTransfersRS](docs/GetAvailableTransfersRS.md)
 - [EasyTravelApi.GetBookingsRS](docs/GetBookingsRS.md)
 - [EasyTravelApi.GetDataSheetRS](docs/GetDataSheetRS.md)
 - [EasyTravelApi.GetGrantedHotelsRS](docs/GetGrantedHotelsRS.md)
 - [EasyTravelApi.GetHotelPriceDetailsRS](docs/GetHotelPriceDetailsRS.md)
 - [EasyTravelApi.GetPortfolioRS](docs/GetPortfolioRS.md)
 - [EasyTravelApi.GetRoomingListRS](docs/GetRoomingListRS.md)
 - [EasyTravelApi.GetTransferPriceDetailsRS](docs/GetTransferPriceDetailsRS.md)
 - [EasyTravelApi.GrantedHotel](docs/GrantedHotel.md)
 - [EasyTravelApi.HolderForAnActivityDate](docs/HolderForAnActivityDate.md)
 - [EasyTravelApi.HotelBooking](docs/HotelBooking.md)
 - [EasyTravelApi.Option](docs/Option.md)
 - [EasyTravelApi.Pair](docs/Pair.md)
 - [EasyTravelApi.Remark](docs/Remark.md)
 - [EasyTravelApi.Resource](docs/Resource.md)
 - [EasyTravelApi.RoomId](docs/RoomId.md)
 - [EasyTravelApi.ServiceConfirmation](docs/ServiceConfirmation.md)
 - [EasyTravelApi.State](docs/State.md)
 - [EasyTravelApi.Stay](docs/Stay.md)
 - [EasyTravelApi.UpdateOperation](docs/UpdateOperation.md)
 - [EasyTravelApi.UpdateRQ](docs/UpdateRQ.md)
 - [EasyTravelApi.UpdateRS](docs/UpdateRS.md)


## Documentation for Authorization

 All endpoints do not require authorization.
