using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01
{
    public class OfficePersonalComputer : Machine
    {
        public override string Name => "Office PC";
        public override int RAMMb
        {
            get;
        }

        public override IList<CPU> CPUs
        {
            get;
        }

        public override IList<HDD> HDDs
        {
            get;
        }

        private PersonalComputerState state;
        public override PersonalComputerState State => state;


        public override void Poweroff()
        {
            System.Threading.Thread.Sleep(200);
            state = PersonalComputerState.OFF;
        }

        public override void Reboot()
        {
            Poweroff();
            Start();
        }

        public override void Start()
        {
            System.Threading.Thread.Sleep(1000);
            state = PersonalComputerState.ON;
        }

        public OfficePersonalComputer(int rAMMb, IList<CPU> cPUs, IList<HDD> hDDs)
        {
            RAMMb = rAMMb;
            CPUs = cPUs;
            HDDs = hDDs;
            state = PersonalComputerState.OFF;
        }
    }
}
