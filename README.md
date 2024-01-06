# Guided Assignment - Introduction to Class Fields and Properties in C#

## Introduction
In this assignment, we'll dive into the concepts of class fields and properties in C#, crucial components in object-oriented programming. Fields are variables declared within a class, and properties are a combination of methods used to read, write, or compute their values. We'll explore why fields are often private, the roles of getters and setters, and how to implement read-only and write-only properties with validation.

---

## Detailed Requirements

#### Project Setup (20 Points)
- Create a new console application in your IDE (e.g., Visual Studio).
- Name the project `GA_FieldsProperties_YourName`, replacing "YourName" with your actual name.
- Ensure the project is properly set up with the necessary default files (e.g., `Program.cs`).

#### Understanding of Fields (15 Points)
- Declare at least one private field within your class (e.g., `Person` class).
- The field should be relevant to the class's purpose (e.g., `_name` for a Person class).
- Explain with comments why the field is private and its role within the class.

#### Implementation of Properties (15 Points)
- Implement public properties with `get` and `set` accessors for the private fields.
- The properties should provide controlled access to the private fields.
- Use proper syntax and naming conventions for the properties.

#### Private Fields and Public Properties Explanation (15 Points)
- Provide clear and concise comments in your code explaining:
  - The need for using private fields.
  - How public properties provide controlled access to these fields.
  - The benefits of this encapsulation approach.

#### Understanding Getters and Setters (15 Points)
- Implement both `get` and `set` accessors in your properties.
- Explain the purpose and functionality of `get` and `set` accessors through comments.
- Demonstrate how `get` retrieves the field value and `set` assigns a new value.

#### Read-Only and Write-Only Properties (10 Points)
- Implement at least one read-only property (with only a `get` accessor).
- Implement at least one write-only property (with only a `set` accessor).
- Explain their usage and scenarios where they might be useful.

#### Validation in Properties (10 Points)
- Include validation logic in the `set` accessor of one or more properties.
- The validation should check for conditions (e.g., non-null, within a range) before assigning the value.
- Add comments explaining the validation process and its importance.

#### Code Testing and Output Accuracy (5 Points)
- In the `Main` method, create an instance of your class and test the properties.
- The testing should include setting and getting property values, and observing the correct behavior.
- Ensure the output in the console is as expected and accurate.

#### Submission (5 Points)
- Successfully upload the complete project to GitHub.
- Ensure the repository is public and contains all necessary files.
- Provide the correct GitHub repository link in your Canvas submission.

#### Total (100 Points)
- Each section is mandatory.
- Points are awarded based on fulfilling each detailed requirement accurately.

Make sure to follow each of these requirements closely to ensure you meet all the criteria outlined in the rubric for your assignment.

---

### Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Understanding Class Fields and Properties");
    }
}
```

We'll focus on adding a new class to work with fields and properties.

---

## Create a new Person class file

- Add a new class to the solution explorer ( either with right clicking or hot keys ), and give it a name of `Program.cs`.

```csharp
public class Person
{
    // Fields and properties will go here
}
```

---

### **Step 1: Understanding Class Fields**

**Fields** are variables declared within a class. They represent the data or state of an object.

- Add a private field named `_name` of type `string` in the `Person` class. This field will hold the name of the person.

```csharp
class Person
{
    private string _name;
}
```

**Run your code**  
- You won't see any changes yet, as we're just setting up the structure.

---

### **Step 2: Implementing Properties**

**Properties** in C# are members that provide a flexible mechanism to read, write, or compute the values of private fields. Properties can include `get` and `set` accessors.

- Add a public property `Name` that will be used to access the `_name` field.

```csharp
class Person
{
    private string _name;

    // Property
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
```

**Run your code**  
- Still no output changes, but we've now encapsulated our field with a property.

---

### **Step 3: Private Fields and Public Properties**

It's a common practice to make fields private to encapsulate and protect them. This prevents external access directly to the field, instead requiring the use of properties.

**Explain this in a comment**  
- Add a comment above the `_name` field explaining why it's private.

```csharp
class Person
{
    // Private field: Encapsulates the data to prevent direct external access
    private string _name;
    ...
}
```

---

### **Step 4: Understanding Getters and Setters**

The `get` accessor is used to return the property value, and the `set` accessor is used to assign a new value.

**Explain getters and setters in comments**  
- Add comments in the `Name` property to explain `get` and `set`.

```csharp
    public string Name
    {
        get { return _name; } // Getter: Returns the value of _name
        set { _name = value; } // Setter: Assigns a value to _name
    }
```

---

### **Step 5: Read-Only and Write-Only Properties**

**Read-only** properties include a `get` accessor but no `set` accessor. **Write-only** properties include a `set` accessor but no `get` accessor.

- Add a read-only property `ReadOnlyName` and a write-only property `WriteOnlyName`.

```csharp
    public string ReadOnlyName
    {
        get { return _name; }
    }

    public string WriteOnlyName
    {
        set { _name = value; }
    }
```

---

### **Step 6: Adding Validation to Properties**

We can add logic in the `set` accessor of properties for validation.

- Modify the `Name` property to include a validation that ensures the name is not empty.

```csharp
    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _name = value;
            else
                throw new ArgumentException("Name cannot be null or empty");
        }
    }
```

---

### **Step 7: Testing in Main**

- In the `Main` method, create an instance of `Person` and test the properties.

```csharp
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "John Doe"; // Testing setter
        Console.WriteLine(person.Name); // Testing getter
        Console.WriteLine(person.ReadOnlyName); // Testing read-only property
    }
```

**Run the Code**

You should see the name "John Doe" printed, demonstrating the use of properties.

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Proper creation of a new console application named GA_FieldsProperties_YourName. | 20 |
| **Understanding of Fields** | Correct implementation and explanation of private fields. | 15 |
| **Implementation of Properties** | Accurate use of properties with `get` and `set` accessors. | 15 |
| **Private Fields and Public Properties Explanation** | Clear explanation of the need for private fields and public properties. | 15 |
| **Understanding Getters and Setters** | Correct explanation and implementation of getters and setters. | 15 |
| **Read-Only and Write-Only Properties** | Correct implementation of read-only and write-only properties. | 10 |
| **Validation in Properties** | Implementation of validation logic within property setters. | 10 |
| **Code Testing and Output Accuracy** | Successful testing in the `Main` method and accurate output. | 5 |
| **Submission** | Successful upload to GitHub and correct submission link provided on Canvas. | 5 |
| **Total** |  | 100 |

OpenAI. (2024). Introduction to Class Fields and Properties in C#. ChatGPT Conversation.

