using ChainofResponsibility.Business.Exceptions;
using ChainofResponsibility.Business.Handlers.UserValidation;
using ChainofResponsibility.Business.Models;
using ChainofResponsibility.Business.Validators;

namespace ChainofResponsibility.Business
{
    public class UserProcessor
    {
        public bool Register(User user)
        {
            try
            {
                var handler = new SocialSecurityNumberValidatorHandler();

                handler.SetNext(new AgeValidationHandler())
                    .SetNext(new NameValidationHandler())
                    .SetNext(new CitizenshipRegionValidationHandler());

                handler.Handle(user);
            }
            catch (UserValidationException ex)
            {
                return false;
            }

            return true;
        }
    }
}
