using FluentValidation.Attributes;
using Webapplication1.ViewModel.Validations;

namespace Webapplication1.ViewModel
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {


        public string UserName { get; set; }
        public string Password { get; set; }

    }
}