using LoginCustomValidation.Services;

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LoginCustomValidation.Model
{
    public class CustomValidationAttributes : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var username = value as string;
            if (string.IsNullOrEmpty(username))
                return ValidationResult.Success;

            var userService = (IUserService)validationContext.GetService(typeof(IUserService));
            if (userService.IsUsernameAvailable(username))
                return ValidationResult.Success;

            return new ValidationResult("Username is already taken.");
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-usernameavailable", ErrorMessage);
        }
    
    }
}
