﻿using System;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    public LogFactory LogFactory { get; set; }
    public LogFactoryTests()
    {
        LogFactory = new LogFactory();
    }

    [TestMethod]
    public void CreateBaseLogger_NoFileGiven_IsNull()
    {
        BaseLogger? logger = LogFactory.CreateLogger(nameof(FileLogger));
        Assert.IsNull(logger);
    }

    [TestMethod]
    public void CreateBaseLogger_FileGiven_FileLoggerCreated()
    {
        LogFactory.ConfigureFileLogger("test");
        BaseLogger? logger = LogFactory.CreateLogger(nameof(FileLogger));
        Assert.IsInstanceOfType(logger, typeof(FileLogger));
    }
}
