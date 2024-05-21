﻿global using Asp.Versioning;
global using Asp.Versioning.Conventions;
global using eShop.Catalog.API;
global using eShop.Catalog.API.Infrastructure;
global using eShop.Catalog.API.Infrastructure.EntityConfigurations;
global using eShop.Catalog.API.Infrastructure.Exceptions;
global using eShop.Catalog.API.IntegrationEvents;
global using eShop.Catalog.API.IntegrationEvents.EventHandling;
global using eShop.Catalog.API.IntegrationEvents.Events;
global using eShop.Catalog.API.Model;
global using Infrastructure.EventBus.Abstractions;
global using Infrastructure.EventBus.Events;
global using Infrastructure.IntegrationEventLogEF;
global using Infrastructure.IntegrationEventLogEF.Services;
global using Infrastructure.IntegrationEventLogEF.Utilities;
global using eShop.ServiceDefaults;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Options;
global using Npgsql;
