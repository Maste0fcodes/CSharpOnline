using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Speedometer
    {
        public event EventHandler ValueChanged;
        private int _currentSpeed;
        // this value always set to zero
        public Speedometer() { _currentSpeed = 0; }
        //property example
        public int CurrentSpeed
        {
            set
            {
                this._currentSpeed = value;
                OnValueChanged();
            }
            get { return _currentSpeed; }
        }
        protected void OnValueChanged()
        {
            if(ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }

    }
}
