Hi there!

Dapper is great! For you that don't know Dapper it is a so called Micro ORM.

The purpose of Dapper is to map data from a IDataReader to a POCO class.

Example of a POCO class
```csharp
partial class Customer
{
    public Int64  Id        { get; set; }
    public String FirstName { get; set; }
    public String LastName  { get; set; }
}
```

What we don't want to do is to write error-prone code like this
```csharp
return new Customer
{
    Id        = dataReader.IsDBNull (0) ? default (Int64)          : dataReader.GetInt64                 (0),
    FirstName = dataReader.IsDBNull (1) ? ""                       : dataReader.GetString                (1),
    LastName  = dataReader.IsDBNull (2) ? ""                       : dataReader.GetString                (2),
};
```

It gets worse if we want to support arbritrary order of input columns.

Dapper helps us with this.

But is it really needed when we have T4?

With T4 you can specify a model of the POCO class
```csharp
Namespace = "StaticDapper"      ;
Model = new []
{
    new ClassDefinition ("Customer")
    {
        Int64   ("Id"           , columnName: "ID"  ),
        String  ("FirstName"    ),
        String  ("LastName"     ),
    },
    new ClassDefinition ("Order")
    {
        Int64   ("Id"           , columnName: "ID"  ),
        String  ("InvoiceNo"    ),
        Decimal ("TotalAmount"  ),
        DateTime("Paid"         , isNullable: true  ),
    },
};
```

From this all the tedious details are generated.

The benefits of this over Dapper is:
1. No external dependencies
2. Reduced runtime complexity (take a look at the Dapper code and you'll understand)
3. Improved debuggability

The interesting bits of this sample is:

+ Model   - Generated_POCO.tt       -   Contains *what* POCO classes to generate
+ Template- StaticDapper.ttinclude  -   Reusuable POCO generator template, 
                                        can be shared between projects

Have fun @marten_range (twitter)
