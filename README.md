# Primitive type obsession
Primitive type obsession is using and relying too much on primitive types. 

How do you store email addresses? 
How do you treat phone numbers?
How about a name of the user? 
As a string? I have got bad news for you:
```cs
public static class PersonalInformationMapper
{
    public static PersonalInformationDto ToDto(this PersonalInformation personalInformation)
    {
        return new PersonalInformationDto
        {
            Email = personalInformation.Email,
            FirstName = personalInformation.LastName,
            LastName = personalInformation.FirstName,
            PhoneNumber = personalInformation.PhoneNumber
        };
    }
}
```

The bad news is, this compiles. And for those who did not notice, FirstName is mapped to LastName and vice-versa.
Fortunately there is a solution for this - custom value object types instead of using `string`

## Basic setup
## AspNetCore setup - Swagger and OpenApi specifications (with generated client)

## Database setup
