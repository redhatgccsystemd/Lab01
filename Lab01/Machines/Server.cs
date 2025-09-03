using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01
{
    public class Server : Machine
    {
        public int RAMMb
        {
            get; private set;
        }

        public IList<CPU> CPUs
        {
            get; private set;
        }

        public IList<HDD> HDDs
        {
            get; private set;
        }

        public PersonalComputerState State
        {
            get; private set;
        }

        public void Poweroff()
        {
            System.Threading.Thread.Sleep(1000);
            State = PersonalComputerState.OFF;
        }

        public void Reboot()
        {
            Poweroff();
            Start();
        }

        public void Start()
        {
            System.Threading.Thread.Sleep(5000);
            State = PersonalComputerState.ON;
        }

        public Server(int rAMMb, IList<CPU> cPUs, IList<HDD> hDDs)
        {
            RAMMb = rAMMb;
            CPUs = cPUs;
            HDDs = hDDs;
            State = PersonalComputerState.OFF;
        }
    }
}
