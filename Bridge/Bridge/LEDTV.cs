using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface LEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}
