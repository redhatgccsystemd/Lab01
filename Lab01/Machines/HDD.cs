using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01
{
    public class HDD
    {
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string FirmwareRevision { get; set; }
        public long CapacityBytes { get; set; }
        public long SectorSizeBytes { get; set; }

        public HDD(string modelNumber, 
            string serialNumber, 
            string firmwareRevision, 
            long capacityBytes, 
            long sectorSizeBytes)
        {
            ModelNumber = modelNumber;
            SerialNumber = serialNumber;
            FirmwareRevision = firmwareRevision;
            CapacityBytes = capacityBytes;
            SectorSizeBytes = sectorSizeBytes;
        }

        public override string ToString()
        {
            return "<table>" +
        "<tr>" +
            $"<th>Model Number</th><td>{ModelNumber}</td>" +
        "</tr><tr>" +
            $"<th>Serial Number</th><td>{SerialNumber}</td>" +
            "</tr><tr>" +
            $"<th>Firmware Revision</th><td>{FirmwareRevision}</td>" +
            "</tr><tr>" +
            $"<th>Capacity</th><td>{CapacityBytes} bytes</td>" +
            "</tr><tr>" +
            $"<th>Sector Size</th><td>{SectorSizeBytes} bytes</td>" +
        "</tr>" +
    "</table>";
        }
    }
}
