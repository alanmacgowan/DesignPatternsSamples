using ChainofResponsibility.Business.Exceptions;
using ChainofResponsibility.Business.Models;

namespace ChainofResponsibility.Business.Handlers.UserValidation
{
    public class CitizenshipRegionValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.CitizenshipRegion.TwoLetterISORegionName == "NO")
            {
                throw new UserValidationException("We currently do not support Norwegians");
            }

            base.Handle(user);
        }
    }
}
