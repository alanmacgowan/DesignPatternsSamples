using System;

namespace Mediator_1
{
    public abstract class User
    {
        protected IFacebookGroupMediator mediator;
        protected string name;
        public User(IFacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
