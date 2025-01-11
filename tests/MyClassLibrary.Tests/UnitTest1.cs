using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyClassLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = MyClassLibrary.Class1.HelloWorld();
        Assert.Equal("Hello World!", result);

    }
    
    [Fact]
    public void Test2()
    {
        var result = MyClassLibrary.Class1.GoodbyeWorld();
        Assert.Equal("Goodbye World!", result);

    }
    
    [Fact]
    
    public void Test3()
    {
        var result = MyClassLibrary.Class1.Hello("John");
        Assert.Equal("Hello John!", result);

    }
    
    [Fact]
    public void Test4()
    {
        var class1 = new MyClassLibrary.Class1();
        var result = class1.Add(1, 2);
        Assert.Equal(3, result);

    }
}