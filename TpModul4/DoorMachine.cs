using System;
using System.Collections.Generic;
using System.Text;

namespace TpModul4
{
    internal class DoorMachine
    {
            public enum State { Terkunci, Terbuka }
            public State currentState;

            public DoorMachine()
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }

            public void BukaPintu()
            {
                if (currentState == State.Terkunci)
                {
                    currentState = State.Terbuka;
                    Console.WriteLine("Pintu tidak terkunci");
                }
            }

            public void KunciPintu()
            {
                if (currentState == State.Terbuka)
                {
                    currentState = State.Terkunci;
                    Console.WriteLine("Pintu terkunci");
                }
            }
        }
    }
