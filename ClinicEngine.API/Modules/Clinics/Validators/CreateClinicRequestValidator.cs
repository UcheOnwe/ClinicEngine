using ClinicEngine.API.Modules.Clinics.DTOs;
using FluentValidation;

namespace ClinicEngine.API.Modules.Clinics.Validators;

public class CreateClinicRequestValidator : AbstractValidator<CreateClinicRequest>
{
    public CreateClinicRequestValidator()
    {
        RuleFor(x => x.Name) //lamda expression same as: public string GetName(string x)
                            //                           {   
                            //                              return x.Name
                            //                           }
                            //take x (clinic) and return Name
            .NotEmpty().WithMessage("Clinic Name is Required")
            .MaximumLength(100).WithMessage("Name can not exceed 100 characters");
        
        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("Phone number required");

        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("Address is Required");

        RuleFor(x => x.OpeningHours)
            .NotEmpty().WithMessage("Opening hours is Required");

        RuleFor(x => x.AnimalsSeen)
            .NotEmpty().WithMessage("Animals seen is Required");
    }
}