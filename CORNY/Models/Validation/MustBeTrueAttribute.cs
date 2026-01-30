using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CORNY.Models.Validation
{
    public class MustBeTrueAttribute : ValidationAttribute, IClientModelValidator
    {
        public MustBeTrueAttribute()
        {
            ErrorMessage = "You must accept the Terms and Privacy Policy.";
        }

        public override bool IsValid(object? value)
            => value is bool b && b;

        public void AddValidation(ClientModelValidationContext context)
        {
            Merge(context.Attributes, "data-val", "true");
            Merge(context.Attributes, "data-val-mustbetrue", ErrorMessage ?? "This field is required.");
        }

        private static void Merge(IDictionary<string, string> attributes, string key, string value)
        {
            if (!attributes.ContainsKey(key))
                attributes.Add(key, value);
        }
    }
}
