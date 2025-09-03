using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01
{
    interface Machine
    {
        string Name { get; }
        int RAMMb { get; }
        IList<CPU> CPUs { get; }
        IList<HDD> HDDs { get; }
        PersonalComputerState State { get; }
        void Poweroff();
        void Reboot();
        void Start();
    }

    public static class MachineHelper {
        static string MachineToString(Machine machine)
        {

        }
    }
}
