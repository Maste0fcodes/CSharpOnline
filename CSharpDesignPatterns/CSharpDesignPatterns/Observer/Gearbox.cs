using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Gearbox : ISpeedChanged
    {
        public Gearbox(Speedometer speed)
        {
            speed.ValueChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {

        }
    } // end class
} // end namespace
