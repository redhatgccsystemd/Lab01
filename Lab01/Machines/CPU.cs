using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01
{
    public class CPU
    {
        public string VendorID { get; set; }
        public int Family { get; set; }

        public int Model { get; set; }
        public string ModelName { get; set; }
        public double MHz { get; set; }
        public int CacheSizeKb { get; set; }
        public string[] Flags { get; set; }

        public CPU(string vendorID, 
            int family, 
            int model,
            string modelName,
            double MHz,
            int cacheSizeKb,
            string[] flags)
        {
            this.VendorID = vendorID;
            this.Family = family;
            this.Model = model;
            this.ModelName = modelName;
            this.MHz = MHz;
            this.CacheSizeKb = cacheSizeKb;
            this.Flags = flags;
        }

        public override string ToString()
        {
            return "<table>" +
                    "<tr>" +
                        $"<th>Vendor ID</th><td>{VendorID}</td>" +
                    "</tr><tr>" +
                        $"<th>Family</th><td>{Family}</td>" +
                        "</tr><tr>" +
                        $"<th>Model</th><td>{Model}</td>" +
                        "</tr><tr>" +
                        $"<th>Model Name</th><td>{ModelName}</td>" +
                        "</tr><tr>" +
                        $"<th>MHz</th><td>{MHz}</td>" +
                        "</tr><tr>" +
                        $"<th>Cache Size</th><td>{CacheSizeKb} Kb</td>" +
                        "</tr><tr>" +
                        $"<th>Flags</th><td>{string.Join(", ", Flags)} </td>" +
                    "</tr>" +
                "</table>";
        
        }
    }
}
