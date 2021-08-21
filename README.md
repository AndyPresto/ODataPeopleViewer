
# ODataPeopleViewer
A C# console application for viewing records of people returned by the OData example API.

## Features
1. **Listing**: Explore lists of people, and view supplemental information about a specific person.

## Building source code
### Prerequisites
This section describes the recommended orerequisites that should be installed prior to building the application.
1. Visual Studio 2019
1. The .NET 5 SDK

### Steps
This section describes the steps that can be taken to debug and run the solution.
**1) Download the reposity**

    git clone https://github.com/AndyPresto/ODataPeopleViewer.git
**2) Open src/ODataPeopleViewer.sln in Visual Studio.**
**3) Restore Nuget packages**
**4) Run the build from Visual Studio**

## The data
OData.org has a public endpoint that can be queried. This console application allows you to query that endpoint for the purposes of browsing example sets of data about fake people.

## Configuration
Settings, such as the base url and the data modification key are specified in the appsettings.json file.

## Licence
The code for this application is shared under the MIT licence.
