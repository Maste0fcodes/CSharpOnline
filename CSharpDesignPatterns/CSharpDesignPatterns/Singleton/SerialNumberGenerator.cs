using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        public static object synchornizationRoot = new object();
        private int _count = 12345;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(synchornizationRoot)
                    {
                        if(instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGenerator() { }

        public int NextSerial()
        {
            return ++_count;
        }

        public int NextOtherSerial
        {
            get { return ++_count; }
        }

    } // end class
} // end namespace
