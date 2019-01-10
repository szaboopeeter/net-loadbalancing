## Overview

Agoda.Frameworks.LoadBalancing is a .NET Standard library that provides logic for handling retry and load balancing.

[TeamCity](https://teamcity.agodadev.io/project.html?projectId=AgodaFrontEnd_Libraries_AgodaFrameworksLoadBalancing&branch_AgodaFrontEnd_Libraries_AgodaFrameworksLoadBalancing=__all_branches__)

## Features

- Weight-adjusted random selection for data sources
- Retry mechanism for sync and async functions
- Thread-safe and multi-threading friendly retry manager
- Dynamic weight adjustment base on action results
- Built-in events for retry manager

## Documentations

[docs](./docs)

## Install

```
dotnet add Agoda.Frameworks.LoadBalancing
```

## Build

```
dotnet build
```

## Test

```
dotnet test
```
