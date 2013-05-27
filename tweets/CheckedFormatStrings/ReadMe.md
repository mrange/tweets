Hi there!

The purpose of this sample is to demonstrate how one could build checked 
format strings using T4.

Checked format strings are great as they provide:

1. Compile-time/Design-time checking of the format strings
2. Method stubs generated with the correct number of formatting arguments

This means less scary runtime errors.

In practice this mean that the formatting string:
```csharp
"Printing two values: {0}.{1}"
```

Should generate a method stub that takes two parameters. These parameters
are of object type as the formatting string contains no type hints.

The interesting bits of this sample is:

+ Model   - Generated_CheckedFormatStrings.tt   -   Contains *what* checked formatting string to generate
+ Template- Exceptions.ttinclude                -   Reusuable checked formatting string generator

For example consider the first entry in the Model:
```csharp
F ("OneValue"       , @"Printing a value: {0}"          ),
````

The Template will then:

1. Validate the formatting string during design-time
2. Generate method with one object parameter.

The developer formats the string using:
```csharp
var value = Format.OneValue (1);
```

This is what we want to achieve with Checked Formatting strings.

Have fun @marten_range (twitter)
