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
            return $"Model Number: {ModelNumber};\n" +
                $"Serial Number: {SerialNumber};\n" +
                $"Firmware Revision: {FirmwareRevision}\n;" +
                $"Capacity: {CapacityBytes} bytes;\n" +
                $"Sector Size: {SectorSizeBytes} bytes;";
        }
    }
}
