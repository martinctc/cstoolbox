# cstoolbox

This is a sample, minimal C# class library I've created for my own learning purposes. The intent is that some ultimately useful code may make it into here, making this repository more valuable than simply a reference for a minimal library. 

Currently, there are the following classes:
- `Algebra`: methods for simple algebraic computations
- `StringManipulation`: methods for simple string manipulation 

... more to come!

## Using the library

The `.dll` can be found here in this path:
`cstoolbox/bin/Debug/net6.0/cstoolbox.dll`. 

To use the methods in `cstoolbox`, you can: 

1. Create a new C# project in Visual Studio
2. In 'Solution Explorer', add the `cstoolbox.dll` as a Project Reference.
3. Reference the methods in `Main.cs`, as follows. 

```cs
using System;
using cstoolbox;

public class StringManipulationTest
{
   public void TestReplaceSpaceWithUnderscore(string text)
   {
       cstoolbox.StringManipulation salg = new StringManipulation();        
       string result = salg.ReplaceSpaceWithUnderscore(text);        
       Console.WriteLine("Testing 'ReplaceSpaceWithUnderscore' method: ");
       Console.Write("Input text:");
       Console.WriteLine(text);
       Console.Write("Output text:");
       Console.Write(result);
       Console.WriteLine("...");
   }
} 

public class Test
{   
    static void Main()
    {       
        StringManipulationTest test = new StringManipulationTest();
        test.TestReplaceSpaceWithUnderscore("Make Me A Camel Case");
    }  
}
```
