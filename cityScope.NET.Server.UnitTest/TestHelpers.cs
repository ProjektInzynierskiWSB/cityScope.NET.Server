﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;

namespace cityScope.NET.Server.UnitTest
{
    public static class TestHelpers
    {
        public static IConfigurationRoot GetConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile("appsettings.local.json", true, true)
                .AddEnvironmentVariables()
                .Build();
        }

        public static IHttpContextAccessor MockHttpContextAccessor()
        {
            var mockHttpContext = new Mock<IHttpContextAccessor>();
            var context = new DefaultHttpContext();
            mockHttpContext.Setup(c => c.HttpContext).Returns(context);

            return mockHttpContext.Object;
        }
    }
}
