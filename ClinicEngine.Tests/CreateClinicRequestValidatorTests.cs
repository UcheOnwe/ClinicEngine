using System.Net.Sockets;
using ClinicEngine.API.Modules.Clinics.DTOs;
using ClinicEngine.API.Modules.Clinics.Validators;

namespace ClinicEngine.Tests;

//This class references ClinicEngine.API to perform Test with the ClinicEngine.API Validator
//  for the purpose of Valid bug free code and CICD with github Actions
public class CreateClinicRequestValidatorTests
{
    [Fact]
    public void Validate_WhenClinicNameIsEmpty_ShouldFailValidation()
    {
        //Arrange
        //createClinicRequest comes from:
        //clinicengine.API/Modules/Validators/CreateClinicRequestValidator.cs
        var validator = new CreateClinicRequestValidator();

        
        var request = new CreateClinicRequest
        {
            Name = "",
            PhoneNumber = "346-555-1234",
            Address = "100 AWS Way",
            OpeningHours = "Monday - Friday 8AM-6PM",
            AnimalsSeen = "Dogs, Cats"

        };

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.False(result.IsValid);

        Assert.Contains(
            result.Errors,
            error => error.PropertyName == "Name"
        );

    }

    [Fact]
    public void Validate_WhenClinicRequestIsValid_ShouldPassValidation()
    {
        //ARRANGE
        // Creating the real validator that we want to test 
        var validator = new CreateClinicRequestValidator();

        //referencing CreateClinicRequest from ClinicEngine.API DTOs 
        //this time every required field contains valid data
        var request = new CreateClinicRequest
        {
            Name = "AWS Animal Clinic",
            PhoneNumber = "346-555-1234",
            Address = "100 AWS Way",
            OpeningHours = "Monday - Friday 8AM-6PM",
            AnimalsSeen = "Dogs, Cats"
        };

        // ACT
        // Validate() belongs to FluentValidation.
        // We give it OUR request object above.
        //It runs that request through ALL rules in CreateClinicRequestValidator.
        //CreateClinicRequestValidator.
        var result = validator.Validate(request);

        // ASSERT
        //IsValid comes fro fluentValidation's ValidationResult
        //it is a bool - true/false value
        // Because everything above is valid, we expect FluentValidation  to say IsValid == true.
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Validate_WhenClinicNameExceeds100characters_ShouldFailValidation()
    {
        // Arrange
        var validator = new CreateClinicRequestValidator();

        var request = new CreateClinicRequest
        {
            // string('A', 101) creates a string containing 101 A characters.
            // We use 101 because the validator allows up to 100
            Name = new string('A', 101),
            PhoneNumber = "346-555-8990",
            Address = "100 AWS Way",
            OpeningHours = "Monday - Friday 8AM - 6PM",
            AnimalsSeen = "Dogs, Cats"
        };

        //ACT
        //FluentValidation checks the request against your validator rules
        // and returns a validationResult object.
        var result = validator.Validate(request);

        //ASSERT
        //Assert.false() comes from xUnit.
        //result.IsValid comes from FluentValidation's ValidationResult.
        //isValid should be false because Name is 101 characters.
        Assert.False(result.IsValid);

        //Assert.Contains() also comes from xUnit.
        //result.Errors comes from FluentValidation's ValidationResult
        //"error" represents each validation error in that collection.
        Assert.Contains(
            result.Errors,
            error => error.PropertyName == "Name"
        );
    }
}
