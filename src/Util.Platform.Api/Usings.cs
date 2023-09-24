﻿global using System;
global using System.Threading.Tasks;
global using System.Linq;
global using System.Collections.Generic;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Configuration;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.HttpLogging;
global using Microsoft.AspNetCore.HttpOverrides;
global using Microsoft.Extensions.Hosting;
global using Microsoft.OpenApi.Models;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Authorization;
global using Util.Applications.Trees;
global using Util.Applications.Controllers;
global using Util.Applications.Properties;
global using Util.Applications.Models;
global using Util.Ui.NgZorro.Controllers;
global using Util.Sessions;
global using Util.Data.EntityFrameworkCore;
global using Util.Data;
global using Util.Tenants;
global using Util.Aop;
global using Util.Dates;
global using Util.Images;
global using Util.Security.Authorization;
global using Util.Infrastructure;
global using Util.Localization;
global using Util.Caching.EasyCaching;
global using Util.Logging.Serilog;
global using Util.Platform.Share;
global using Util.Microservices;
global using EasyCaching.Core.Configurations;
global using Util.Data.EntityFrameworkCore.Migrations;
global using Util.Platform.Share.Identity.Applications.Options;
global using Util.Platform.Share.Tools.Dtos;
global using Util.Platform.Share.Tools.Services.Abstractions;
global using Util.Platform.Applications.Dtos.Identity;
global using Util.Platform.Applications.Services.Abstractions.Identity;
global using Util.Platform.Data.Queries.Identity;
global using Util.Platform.Applications;
global using Util.Platform.Data;
global using Util.Platform.Api;
global using Util.Platform.Share.Authorization;