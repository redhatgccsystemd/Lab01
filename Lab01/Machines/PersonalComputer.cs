using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01
{
    public class PersonalComputer
    {
        public int RAMMb { get; private set; }
        public IList<CPU> CPUs { get; private set; }
        public IList<HDD> HDDs { get; private set; }
        public PersonalComputerState State
        {
            get; private set;
        }
        public void Poweroff()
        {
            State = PersonalComputerState.OFF;
        }
        public void Reboot()
        {
            State = PersonalComputerState.ON;
        }

        public void Start()
        {
            State = PersonalComputerState.ON;
        }

        public PersonalComputer(int rAMMb, IList<CPU> cPUs, IList<HDD> hDDs, PersonalComputerState state)
        {
            RAMMb = rAMMb;
            CPUs = cPUs;
            HDDs = hDDs;
            State = state;
        }
    }
}
