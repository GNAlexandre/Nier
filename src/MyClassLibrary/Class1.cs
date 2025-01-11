using System;
using System.Collections.Generic;
using System.Text;


namespace MyClassLibrary;

public class Class1
{
    public static string HelloWorld()
    {
        return "Hello World!";
    }
    
    public static string GoodbyeWorld()
    {
        return "Goodbye World!";
    }
    
    public static string Hello(string name)
    {
        return $"Hello {name}!";
    }
    
    public int Add(int a, int b)
    {
        return a + b;
    }

}
