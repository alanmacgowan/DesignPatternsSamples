using ChainofResponsibility.Business.Exceptions;
using ChainofResponsibility.Business.Models;

namespace ChainofResponsibility.Business.Handlers.UserValidation
{
    public class NameValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.Name.Length <= 1)
            {
                throw new UserValidationException("Your name is unlikely this short.");
            }

            base.Handle(user);
        }
    }
}
