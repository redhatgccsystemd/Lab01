using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public abstract class Machine
    {
        public abstract string Name { get; }
        public abstract int RAMMb { get; }
        public abstract IList<CPU> CPUs { get; }
        public abstract IList<HDD> HDDs { get; }
        public abstract PersonalComputerState State { get; }
        public abstract void Poweroff();
        public abstract void Reboot();
        public abstract void Start();

        public override string ToString()
        {
            StringBuilder cpus = new StringBuilder();
            cpus.Append("<ol>");
            foreach (var cpu in CPUs) {
                cpus.Append($"<li>{cpu.ToString()}</li>");
            }
            cpus.Append("</ol>");

            StringBuilder hdds = new StringBuilder();
            hdds.Append("<ol>");
            foreach (var hdd in HDDs)
            {
                hdds.Append($"<li>{hdd.ToString()}</li>");
            }
            hdds.Append("</ol>");

            return $"<h2>{Name}</h2>" +
                $"<b>Current state:</b> {State}<br/>" +
                $"<b>RAM:</b> {RAMMb}<br/>" +
                "<h3>Hard Drives</h3>" +
                hdds.ToString() +
                "<h3>CPUs</h3>" +
                cpus;
        }
    }
}
