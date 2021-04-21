using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class AbstractRemoteControl
    {
        protected LEDTV ledTv;
        protected AbstractRemoteControl(LEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
