﻿using System.Xml.Linq;
using Xunit;

public class CheckForEqualityUsingBaseEqualsConfigTests
{
    [Fact]
    public void False()
    {
        var xElement = XElement.Parse("<PropertyChanged CheckForEqualityUsingBaseEquals='false'/>");
        var moduleWeaver = new ModuleWeaver { Config = xElement };
        moduleWeaver.ResolveCheckForEqualityUsingBaseEqualsConfig();
        Assert.False(moduleWeaver.CheckForEqualityUsingBaseEquals);
    }

    [Fact]
    public void True()
    {
        var xElement = XElement.Parse("<PropertyChanged CheckForEqualityUsingBaseEquals='true'/>");
        var moduleWeaver = new ModuleWeaver { Config = xElement };
        moduleWeaver.ResolveCheckForEqualityUsingBaseEqualsConfig();
        Assert.True(moduleWeaver.CheckForEqualityUsingBaseEquals);
    }

    [Fact]
    public void Default()
    {
        var moduleWeaver = new ModuleWeaver();
        moduleWeaver.ResolveCheckForEqualityUsingBaseEqualsConfig();
        Assert.True(moduleWeaver.CheckForEqualityUsingBaseEquals);
    }
}