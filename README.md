# Module 4 API Workshop

## Overview

The repo shows how .NET 6 is used to create APIs.

Before running the sample code, download the [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) for testing the APIs.

### 1. Minimal API

This is a new feature in .NET 6 that allows developers to skip a lot of the boilerplate code used to create .NET Web APIs. Seeing an API without the extra plumbing should help in understanding the middleware and controllers used in traditional .NET Web APIs.

1. Switch to the `1-minimal-api` branch in VS Code.
1. Start the API by running `dotnet run`.
1. Test the API by using the _tests/test.http_ file.

### 2. Standard API

This shows the standard way to configure an API prior to .NET 6. It uses the Middleware pipelines, route configurations, and controllers.

1. Switch to the `2-standard-api` branch in VS Code.
1. Start the API by running `dotnet run`.
1. Test the API by using the _tests/students.http_ and _tests/home.http_ files.
1. Examing the _program.cs_ file and note two things
   - use of the `builder` to configure common and shared runtime services for all endpoints in the API
   - use of the `app` to configure the middleware stack the gets executed on each request.
