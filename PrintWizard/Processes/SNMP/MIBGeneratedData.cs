using System.Collections.Generic;

namespace PrintWizard.Processes.SNMP
{
    public static class MIBGeneratedData
    {
        public static List<MibEntry> Entries = new List<MibEntry>
        {

            new MibEntry
            {
                Name = "internet",
                FullName = ".iso.org.dod.internet",
                OID = ".1.3.6.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "SNMPv2-SMI",
                Description = @""
            },
            new MibEntry
            {
                Name = "private",
                FullName = ".iso.org.dod.internet.private",
                OID = ".1.3.6.1.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "SNMPv2-SMI",
                Description = @""
            },
            new MibEntry
            {
                Name = "enterprises",
                FullName = ".iso.org.dod.internet.private.enterprises",
                OID = ".1.3.6.1.4.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "SNMPv2-SMI",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexmark",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark",
                OID = ".1.3.6.1.4.1.641",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-ROOT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexmarkModules",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.lexmarkModules",
                OID = ".1.3.6.1.4.1.641.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-ROOT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexmarkMIB",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.lexmarkModules.lexmarkMIB",
                OID = ".1.3.6.1.4.1.641.4.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-ROOT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "mpsMibModule",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.lexmarkModules.mpsMibModule",
                OID = ".1.3.6.1.4.1.641.4.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexmarkTCMIB",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.lexmarkModules.lexmarkTCMIB",
                OID = ".1.3.6.1.4.1.641.4.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-TC-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "settingsDefinitionMibModule",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.lexmarkModules.settingsDefinitionMibModule",
                OID = ".1.3.6.1.4.1.641.4.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @""
            },
            new MibEntry
            {
                Name = "settingsControlMibModule",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.lexmarkModules.settingsControlMibModule",
                OID = ".1.3.6.1.4.1.641.4.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-CONTROL-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexmarkMibObjects",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.lexmarkMibObjects",
                OID = ".1.3.6.1.4.1.641.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-ROOT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "mps",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps",
                OID = ".1.3.6.1.4.1.641.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "mpsMIBAdminInfo",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo",
                OID = ".1.3.6.1.4.1.641.6.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "mpsMIBCompliances",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBCompliances",
                OID = ".1.3.6.1.4.1.641.6.1.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "mpsMIBCompliance",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBCompliances.mpsMIBCompliance",
                OID = ".1.3.6.1.4.1.641.6.1.1.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The requirements for conformance to the LEXMARK mps MIB We expect printers to support one of four levels of support.  The following list shows the minimum level of support that must be implemented.  Additional tables may be supported at the device's descretion. Note:For tables that count sides/sheets, if duplex is not supported on a device it only needs to ever count sides. "
            },
            new MibEntry
            {
                Name = "mpsMIBGroups",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups",
                OID = ".1.3.6.1.4.1.641.6.1.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "deviceGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.deviceGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The Device Group."
            },
            new MibEntry
            {
                Name = "hwInventoryGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.hwInventoryGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The Hardware Inventory Group."
            },
            new MibEntry
            {
                Name = "supplyInventoryGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.supplyInventoryGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The supplies inventory Group."
            },
            new MibEntry
            {
                Name = "swInventoryGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.swInventoryGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The Software Inventory Group."
            },
            new MibEntry
            {
                Name = "statsGeneralCountGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsGeneralCountGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The general scan counts and statistics group."
            },
            new MibEntry
            {
                Name = "statsPaperGeneralCountGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsPaperGeneralCountGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The general paper usage count group."
            },
            new MibEntry
            {
                Name = "statsPaperSidesCountGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsPaperSidesCountGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The paper sides count group."
            },
            new MibEntry
            {
                Name = "statsPaperSheetsCountGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsPaperSheetsCountGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.8",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The paper sheets count group."
            },
            new MibEntry
            {
                Name = "statsPaperNupCountGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsPaperNupCountGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.9",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The paper sheets count group."
            },
            new MibEntry
            {
                Name = "statsPaperJobSizeGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsPaperJobSizeGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.10",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The job size group."
            },
            new MibEntry
            {
                Name = "statsScanGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsScanGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.11",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The scan counts and statistics group."
            },
            new MibEntry
            {
                Name = "statsCurrentSuppliesGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsCurrentSuppliesGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.12",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The current supplies listing group"
            },
            new MibEntry
            {
                Name = "statsSupplyHistoryGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsSupplyHistoryGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.13",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The supplies history listing group"
            },
            new MibEntry
            {
                Name = "statsSupplyHistogramGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.statsSupplyHistogramGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.14",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The supplies histogram group"
            },
            new MibEntry
            {
                Name = "deviceAlertGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.mpsMIBAdminInfo.mpsMIBGroups.deviceAlertGroup",
                OID = ".1.3.6.1.4.1.641.6.1.2.16",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The device alert group"
            },
            new MibEntry
            {
                Name = "device",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device",
                OID = ".1.3.6.1.4.1.641.6.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "deviceMibLocalization",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceMibLocalization",
                OID = ".1.3.6.1.4.1.641.6.2.1",
                Type = "INTEGER32",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The value of the prtLocalizationIndex in the Printer-MIB which corresponds to the language, country, and character set to be used for encoding any of the translated objects in this MIB.  This object does NOT change the localization of the console.  The default value for this object should be the language chosen by the user during the initial setup.  When read this object should return the current localization value."
            },
            new MibEntry
            {
                Name = "deviceTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable",
                OID = ".1.3.6.1.4.1.641.6.2.3",
                Type = "SEQUENCE OF DeviceEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of the devices attached.  Because the top level implementation of this mib may be on a print server, it is possible to have multiple printers attached.  This table should list all devices being serviced by this print server."
            },
            new MibEntry
            {
                Name = "deviceEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry",
                OID = ".1.3.6.1.4.1.641.6.2.3.1",
                Type = "DeviceEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a device."
            },
            new MibEntry
            {
                Name = "deviceIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceIndex",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A unique value used to identify this device."
            },
            new MibEntry
            {
                Name = "devicePort",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.devicePort",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of the port this device is attached to.  If this is an internal network adapter, the port should be 1.  Multiport ENAs should list an appropriate number."
            },
            new MibEntry
            {
                Name = "deviceHrDeviceIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceHrDeviceIndex",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index in the hrDeviceTable that corresponds to this device."
            },
            new MibEntry
            {
                Name = "deviceModel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceModel",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.4",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"UTF-8 encoded text to describe this device.  This should match the model name of the device."
            },
            new MibEntry
            {
                Name = "deviceSerialNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceSerialNumber",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.5",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Primary serial number for this device"
            },
            new MibEntry
            {
                Name = "deviceMibVersion",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceMibVersion",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The version of this mib supported by the device.  This will be in the form of x.y.z."
            },
            new MibEntry
            {
                Name = "deviceInstallDate",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceInstallDate",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.7",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The install date of the device.  This information should be provided by the attached device"
            },
            new MibEntry
            {
                Name = "deviceMibSupportLevel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceMibSupportLevel",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.8",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The support level of this device. An attached device can support various levels of this MIB, which is indicated in deviceMibSupportLevel.  The device should claim the highest support level for which it supports EVERYTHING included in that level.  A device may support additional items beyond the claimed level, the list given is just the minimum required implementation to claim a given support level. Support Level definition: none:The device referred to does not support any items in this mib minimum:The following items in the following table must be implemented paperGeneralCountTable: totalPrinted (sides) totalMonoPrinted (sides) totalColorPrinted (sides) (only necessary if a color box) value:All items in minimum plus genCountTable porCount paperGeneralCountTable: All applicable counts supplyInventoryTable For all user replaceable supplies swInventoryTable All software components listed with a minimum of swInventoryName and swInventoryRevision being reported only for code revs on menus page. currentSuppliesTable For all user replaceable supplies deviceAlertTable All critical alerts (device is down) should be listed feature:All items in value plus genCountTable faxesSent (if applicable) scanCount (if applicable) hwInventoryTable All major hardware items (printEngine, installed options) swInventoryTable All code levels including downloaded apps and solutions. paperSidesCount Table A minimum of 9 size/type combinations must be supported paperSheetsCount Table A minimum of 9 size/type combinations must be supported supplyHistoryTable A minimum of the last 3 ink/toner cartridges for mono products A minimum of the last 2 ink/toner cartridges of each colorant type for color products. supplyHistogram Table For all ink/toner cartridges. deviceAlertTable All alerts should be listed. enterprise:All items in feature plus genCountTable Any applicable counts (including power counts) paperSidesCount Table A minimum of 17 size/type combinations must be supported paperSheetsCount Table A minimum of 17 size/type combinations must be supported paperNupCountTable Counts should be included for all applicable nup settings paperJobSizeTable A minimum of 5 buckets of job size should be implemented. scanCountTable For all applicable scan types supplyHistoryTable A minimum of the last 5 ink/toner cartridges for mono products A minimum of the last 3 ink/toner cartridges of each colorant type for color products."
            },
            new MibEntry
            {
                Name = "deviceMachineType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceMachineType",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.9",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Displays the machine type."
            },
            new MibEntry
            {
                Name = "deviceTLI",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.device.deviceTable.deviceEntry.deviceTLI",
                OID = ".1.3.6.1.4.1.641.6.2.3.1.10",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The Top Level Indicator of the device. Unique identifier of the printer model."
            },
            new MibEntry
            {
                Name = "inventory",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory",
                OID = ".1.3.6.1.4.1.641.6.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hwInventoryTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable",
                OID = ".1.3.6.1.4.1.641.6.3.1",
                Type = "SEQUENCE OF HWInventoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of the hardware items associated with this device. If the item is tracked by the supplies tables (ie fuser), it should NOT be tracked here. Standard (built-in) options such as input trays, output bins, duplexers, harddrives, etc, SHOULD be included in this table.  A row for the basic print engine should be included as well. Examples: -All electronic cards -All hardware options -Op-Panel -Fax Card -Scanner -Any item that has a code version associated with it."
            },
            new MibEntry
            {
                Name = "hwInventoryEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry",
                OID = ".1.3.6.1.4.1.641.6.3.1.1",
                Type = "HWInventoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a hardware item."
            },
            new MibEntry
            {
                Name = "hwInventoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryIndex",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A unique value used to identify this hardware item."
            },
            new MibEntry
            {
                Name = "hwInventoryParentIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryParentIndex",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The hwInventoryIndex of the hardware device that the item in this row is tied to.  If there is no parent, this object should read 0. The base printer itself should only be used as a parent for devices that are integrated into it.  ie RIP card, tray one, fax card, scanner. Items that are options such as extra input trays, external duplexers, and add on output bins should rate their own row with no parent. Examples: 5-bin mailbox The mailbox unit as a whole would be one row, with a parent of 0. Each of the mailboxes would be row, with the parent of each mailbox pointing back to the mailbox unit. Finisher The finisher as a whole would be one row, with a parent of 0. The options of the finsher;output bins, stapler, hole punch, would each merit an individual row with the finisher unit as the parent "
            },
            new MibEntry
            {
                Name = "hwInventoryType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryType",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of item row is describing.  There is base set of possible items types and then a set of optional bits that can describe more about how this item is used. Bitmap -bits 0-7 - General description -bit  8   - Optional hardware.  0 - built in, 1 - optional item "
            },
            new MibEntry
            {
                Name = "hwInventoryAdminStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryAdminStatus",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.4",
                Type = "AdminStatusTC",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The current administrative status for this device.  If supported by the device, this may be used to control the status of this hardware component.  If the device does not support changing the administrative status via snmp, the set should fail and the current admin status should be returned."
            },
            new MibEntry
            {
                Name = "hwInventoryStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryStatus",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.5",
                Type = "StatusTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The current status of this item."
            },
            new MibEntry
            {
                Name = "hwInventoryPartNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryPartNumber",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The part number for the item.  If unknown, this string should be blank."
            },
            new MibEntry
            {
                Name = "hwInventorySerialNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventorySerialNumber",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The serial number for the item.  If unknown, this string should be blank."
            },
            new MibEntry
            {
                Name = "hwInventoryDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryDescription",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.8",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The description for the item.  If unknown, this string should be blank.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "hwInventoryData",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.hwInventoryTable.hwInventoryEntry.hwInventoryData",
                OID = ".1.3.6.1.4.1.641.6.3.1.1.9",
                Type = "KeyValueTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A set of key=value;pairs that give additional information on this hardware unit."
            },
            new MibEntry
            {
                Name = "supplyInventoryTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.supplyInventoryTable",
                OID = ".1.3.6.1.4.1.641.6.3.2",
                Type = "SEQUENCE OF SupplyInventoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of the supplies used by this device"
            },
            new MibEntry
            {
                Name = "supplyInventoryEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.supplyInventoryTable.supplyInventoryEntry",
                OID = ".1.3.6.1.4.1.641.6.3.2.1",
                Type = "SupplyInventoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a supply."
            },
            new MibEntry
            {
                Name = "supplyInventoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.supplyInventoryTable.supplyInventoryEntry.supplyInventoryIndex",
                OID = ".1.3.6.1.4.1.641.6.3.2.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A unique value used to identify this supply."
            },
            new MibEntry
            {
                Name = "supplyInventoryType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.supplyInventoryTable.supplyInventoryEntry.supplyInventoryType",
                OID = ".1.3.6.1.4.1.641.6.3.2.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of supply as referenced in the SupplyTypeTC that this row is describing."
            },
            new MibEntry
            {
                Name = "supplyInventoryColorantValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.supplyInventoryTable.supplyInventoryEntry.supplyInventoryColorantValue",
                OID = ".1.3.6.1.4.1.641.6.3.2.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The name of the color using standard string names from ISO 10175 (DPA) and ISO 10180 (SPDL) which are: other unknown white red green blue cyan magenta yellow black If a supply doesn't have a color associated with it, the value of 'none' should be returned."
            },
            new MibEntry
            {
                Name = "supplyInventoryDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.supplyInventoryTable.supplyInventoryEntry.supplyInventoryDescription",
                OID = ".1.3.6.1.4.1.641.6.3.2.1.4",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The description of this supply.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "supplyDynamicIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.supplyInventoryTable.supplyInventoryEntry.supplyDynamicIndex",
                OID = ".1.3.6.1.4.1.641.6.3.2.1.5",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"This value maps to the supply list in Settings MIB for this supply."
            },
            new MibEntry
            {
                Name = "swInventoryTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable",
                OID = ".1.3.6.1.4.1.641.6.3.3",
                Type = "SEQUENCE OF SWInventoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of the software installed on this device"
            },
            new MibEntry
            {
                Name = "swInventoryEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry",
                OID = ".1.3.6.1.4.1.641.6.3.3.1",
                Type = "SWInventoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a software package"
            },
            new MibEntry
            {
                Name = "swInventoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryIndex",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A unique value used to identify this software item."
            },
            new MibEntry
            {
                Name = "swInventoryParentIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryParentIndex",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The swInventoryIndex of the software object that the item in this row is tied to.  If there is no parent, this object should read 0. Example: An application framework is installed.  It should have an swInventoryParentIndex of 0.  If applications are installed that use that framework, those should have an swInventoryParentIndex that points to the application framework."
            },
            new MibEntry
            {
                Name = "swInventoryType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryType",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of software item this row describes."
            },
            new MibEntry
            {
                Name = "swInventoryAdminStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryAdminStatus",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.4",
                Type = "AdminStatusTC",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The current administrative status of this software.  If supported by the device, this may be used to control the status of this software component.  If the device does not support changing the administrative status via snmp, the set should fail and the current admin status should be returned."
            },
            new MibEntry
            {
                Name = "swInventoryStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryStatus",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.5",
                Type = "StatusTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The current status of this software."
            },
            new MibEntry
            {
                Name = "swInventoryName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryName",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The name of this software item.  This should be a specific, unique string."
            },
            new MibEntry
            {
                Name = "swInventoryRevision",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryRevision",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The revision of the install."
            },
            new MibEntry
            {
                Name = "swInventoryDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryDescription",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.8",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The description for the item.  If unknown, this string should be blank.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "swInventoryHWIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryHWIndex",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.9",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row in the hwInventoryTable that indicates the hardware this software is associated with.  If unknown, this should return 0. For instance, if the duplex unit has it's own firmware revision, it's parent would be the duplex hardware item in the hwInventoryTable."
            },
            new MibEntry
            {
                Name = "swInventoryData",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.inventory.swInventoryTable.swInventoryEntry.swInventoryData",
                OID = ".1.3.6.1.4.1.641.6.3.3.1.10",
                Type = "KeyValueTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A set of key=value;pairs that give additional information on this software unit."
            },
            new MibEntry
            {
                Name = "stats",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats",
                OID = ".1.3.6.1.4.1.641.6.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "generalStats",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.generalStats",
                OID = ".1.3.6.1.4.1.641.6.4.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "genCountTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.generalStats.genCountTable",
                OID = ".1.3.6.1.4.1.641.6.4.1.1",
                Type = "SEQUENCE OF GenCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of general counts.  These rows are intended to count items and events for the device other than page usages or supply usage. This table should only include counters that make sense for the device, and are tracked for the device.  In other words, if a count is zero, and can never be anything other than zero, it should not be returned."
            },
            new MibEntry
            {
                Name = "genCountEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.generalStats.genCountTable.genCountEntry",
                OID = ".1.3.6.1.4.1.641.6.4.1.1.1",
                Type = "GenCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing a general counter."
            },
            new MibEntry
            {
                Name = "genCountIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.generalStats.genCountTable.genCountEntry.genCountIndex",
                OID = ".1.3.6.1.4.1.641.6.4.1.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this row in the genCountTable"
            },
            new MibEntry
            {
                Name = "genCountType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.generalStats.genCountTable.genCountEntry.genCountType",
                OID = ".1.3.6.1.4.1.641.6.4.1.1.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of item this counter is counting."
            },
            new MibEntry
            {
                Name = "genCountUnits",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.generalStats.genCountTable.genCountEntry.genCountUnits",
                OID = ".1.3.6.1.4.1.641.6.4.1.1.1.3",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units this item is counting in"
            },
            new MibEntry
            {
                Name = "genCountValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.generalStats.genCountTable.genCountEntry.genCountValue",
                OID = ".1.3.6.1.4.1.641.6.4.1.1.1.4",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The value of this counter"
            },
            new MibEntry
            {
                Name = "paperStats",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats",
                OID = ".1.3.6.1.4.1.641.6.4.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "paperGeneralCountTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperGeneralCountTable",
                OID = ".1.3.6.1.4.1.641.6.4.2.1",
                Type = "SEQUENCE OF PaperGeneralCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of general counts for sheets and pages printed"
            },
            new MibEntry
            {
                Name = "paperGeneralCountEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperGeneralCountTable.paperGeneralCountEntry",
                OID = ".1.3.6.1.4.1.641.6.4.2.1.1",
                Type = "PaperGeneralCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing a general counter for sheets and pages printed. This table should only include items that make sense for this product. For instance, the printColor count should not be returned for mono products."
            },
            new MibEntry
            {
                Name = "paperGeneralCountIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperGeneralCountTable.paperGeneralCountEntry.paperGeneralCountIndex",
                OID = ".1.3.6.1.4.1.641.6.4.2.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this row in the paperGeneralCountTable"
            },
            new MibEntry
            {
                Name = "paperGeneralCountType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperGeneralCountTable.paperGeneralCountEntry.paperGeneralCountType",
                OID = ".1.3.6.1.4.1.641.6.4.2.1.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of item this counter is counting."
            },
            new MibEntry
            {
                Name = "paperGeneralCountUnits",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperGeneralCountTable.paperGeneralCountEntry.paperGeneralCountUnits",
                OID = ".1.3.6.1.4.1.641.6.4.2.1.1.3",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units this item is counting in.  For this table this should always be in units of Sheets or Sides. For the case of continuousPrint, the unit is in feet."
            },
            new MibEntry
            {
                Name = "paperGeneralCountValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperGeneralCountTable.paperGeneralCountEntry.paperGeneralCountValue",
                OID = ".1.3.6.1.4.1.641.6.4.2.1.1.4",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The value of the item this row is counting. For continuousPrint, the value is a whole number representation for a float value (1 decimal point) multipled by 10."
            },
            new MibEntry
            {
                Name = "paperSidesCountTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable",
                OID = ".1.3.6.1.4.1.641.6.4.2.2",
                Type = "SEQUENCE OF PaperSidesCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of sides counts for various printed size/type combinations"
            },
            new MibEntry
            {
                Name = "paperSidesCountEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1",
                Type = "PaperSidesCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on the number of sides printed for a given size/type combination."
            },
            new MibEntry
            {
                Name = "paperSidesCountIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry.paperSidesCountIndex",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this row in the paperSidesCountTable"
            },
            new MibEntry
            {
                Name = "paperSidesPaperSize",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry.paperSidesPaperSize",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1.2",
                Type = "PaperSizeTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The size of the paper "
            },
            new MibEntry
            {
                Name = "paperSidesPaperType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry.paperSidesPaperType",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1.3",
                Type = "PaperTypeTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of the paper"
            },
            new MibEntry
            {
                Name = "paperSidesMonoPicked",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry.paperSidesMonoPicked",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1.4",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of sides (impressions) of mono pages picked"
            },
            new MibEntry
            {
                Name = "paperSidesColorPicked",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry.paperSidesColorPicked",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1.5",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of sides (impressions) of color pages picked"
            },
            new MibEntry
            {
                Name = "paperSidesMonoSafe",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry.paperSidesMonoSafe",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1.6",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of sides (impressions) of mono pages that have been printed and delivered into an output bin"
            },
            new MibEntry
            {
                Name = "paperSidesColorSafe",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSidesCountTable.paperSidesCountEntry.paperSidesColorSafe",
                OID = ".1.3.6.1.4.1.641.6.4.2.2.1.7",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of sides (impressions) of color pages that have been printed and delivered into an output bin"
            },
            new MibEntry
            {
                Name = "paperSheetsCountTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSheetsCountTable",
                OID = ".1.3.6.1.4.1.641.6.4.2.3",
                Type = "SEQUENCE OF PaperSheetsCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of sheet (page) counts for various printed size/type combinations"
            },
            new MibEntry
            {
                Name = "paperSheetsCountEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSheetsCountTable.paperSheetsCountEntry",
                OID = ".1.3.6.1.4.1.641.6.4.2.3.1",
                Type = "PaperSheetsCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on the number of sheets (pages) printed for a given size/type combination."
            },
            new MibEntry
            {
                Name = "paperSheetsCountIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSheetsCountTable.paperSheetsCountEntry.paperSheetsCountIndex",
                OID = ".1.3.6.1.4.1.641.6.4.2.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this row in the paperSheetsCountTable"
            },
            new MibEntry
            {
                Name = "paperSheetsPaperSize",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSheetsCountTable.paperSheetsCountEntry.paperSheetsPaperSize",
                OID = ".1.3.6.1.4.1.641.6.4.2.3.1.2",
                Type = "PaperSizeTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The size of the paper "
            },
            new MibEntry
            {
                Name = "paperSheetsPaperType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSheetsCountTable.paperSheetsCountEntry.paperSheetsPaperType",
                OID = ".1.3.6.1.4.1.641.6.4.2.3.1.3",
                Type = "PaperTypeTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of the paper"
            },
            new MibEntry
            {
                Name = "paperSheetsPicked",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSheetsCountTable.paperSheetsCountEntry.paperSheetsPicked",
                OID = ".1.3.6.1.4.1.641.6.4.2.3.1.4",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of sheets (pages) picked"
            },
            new MibEntry
            {
                Name = "paperSheetsSafe",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperSheetsCountTable.paperSheetsCountEntry.paperSheetsSafe",
                OID = ".1.3.6.1.4.1.641.6.4.2.3.1.5",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of sheets (pages) that have been printed and delivered into an output bin"
            },
            new MibEntry
            {
                Name = "paperNupCountTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperNupCountTable",
                OID = ".1.3.6.1.4.1.641.6.4.2.4",
                Type = "SEQUENCE OF PaperNupCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of counts to show how many jobs have been printed with various multipage print (nup) settings.  This table may be sparse, nup values that have a count of 0 are not expected to be returned."
            },
            new MibEntry
            {
                Name = "paperNupCountEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperNupCountTable.paperNupCountEntry",
                OID = ".1.3.6.1.4.1.641.6.4.2.4.1",
                Type = "PaperNupCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on how much the printer's Nup feature has been used."
            },
            new MibEntry
            {
                Name = "paperNupCountIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperNupCountTable.paperNupCountEntry.paperNupCountIndex",
                OID = ".1.3.6.1.4.1.641.6.4.2.4.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this row in the paperNupCountTable"
            },
            new MibEntry
            {
                Name = "paperNupNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperNupCountTable.paperNupCountEntry.paperNupNumber",
                OID = ".1.3.6.1.4.1.641.6.4.2.4.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The Nup number for the jobs this row is describing.  This is the number of logical sides (impressions) that appear on one side of the printed sheet"
            },
            new MibEntry
            {
                Name = "paperNupSides",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperNupCountTable.paperNupCountEntry.paperNupSides",
                OID = ".1.3.6.1.4.1.641.6.4.2.4.1.3",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of physical sides of paper that have been printed using this value of Nup"
            },
            new MibEntry
            {
                Name = "paperNupLogicalSides",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperNupCountTable.paperNupCountEntry.paperNupLogicalSides",
                OID = ".1.3.6.1.4.1.641.6.4.2.4.1.4",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of logical sides that have been printed using this value of Nup.  For example, if a user prints a 3 page job using an Nup value of 4, the paperNupSides counter will be incremented by 1, and paperNupLogicalSides will be incremented by 3."
            },
            new MibEntry
            {
                Name = "paperJobSizeTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperJobSizeTable",
                OID = ".1.3.6.1.4.1.641.6.4.2.5",
                Type = "SEQUENCE OF PaperJobSizeEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Table to indicate how many jobs of different size have been printed. This table may be sparse.  Only job size buckets that have a non-zero count in them should be returned."
            },
            new MibEntry
            {
                Name = "paperJobSizeEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperJobSizeTable.paperJobSizeEntry",
                OID = ".1.3.6.1.4.1.641.6.4.2.5.1",
                Type = "PaperJobSizeEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on how many jobs of different sizes have been printed."
            },
            new MibEntry
            {
                Name = "paperJobSizeIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperJobSizeTable.paperJobSizeEntry.paperJobSizeIndex",
                OID = ".1.3.6.1.4.1.641.6.4.2.5.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this row in the paperJobSizeTable"
            },
            new MibEntry
            {
                Name = "paperJobSizeMinimum",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperJobSizeTable.paperJobSizeEntry.paperJobSizeMinimum",
                OID = ".1.3.6.1.4.1.641.6.4.2.5.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The minimum number of printed sides for jobs described by this row"
            },
            new MibEntry
            {
                Name = "paperJobSizeMaximum",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperJobSizeTable.paperJobSizeEntry.paperJobSizeMaximum",
                OID = ".1.3.6.1.4.1.641.6.4.2.5.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The maximum number of printed sides for jobs described by this row"
            },
            new MibEntry
            {
                Name = "paperJobSizeSideCount",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperJobSizeTable.paperJobSizeEntry.paperJobSizeSideCount",
                OID = ".1.3.6.1.4.1.641.6.4.2.5.1.4",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The total number of sides printed for all jobs where the number of sides for the job was between paperJobSizeMinimum and paperJobSizeMaximum (inclusive)"
            },
            new MibEntry
            {
                Name = "paperJobSizeJobCount",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.paperStats.paperJobSizeTable.paperJobSizeEntry.paperJobSizeJobCount",
                OID = ".1.3.6.1.4.1.641.6.4.2.5.1.5",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The total number of jobs printed where the number of sides for the job was between paperJobSizeMinimum and paperJobSizeMaximum (inclusive)"
            },
            new MibEntry
            {
                Name = "scanStats",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats",
                OID = ".1.3.6.1.4.1.641.6.4.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "scanCountTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats.scanCountTable",
                OID = ".1.3.6.1.4.1.641.6.4.3.1",
                Type = "SEQUENCE OF ScanCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of scan counts.  This table should only return counts that apply to this product.  For instance, fax scan counts should not be returned if the product doesn't support fax."
            },
            new MibEntry
            {
                Name = "scanCountEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats.scanCountTable.scanCountEntry",
                OID = ".1.3.6.1.4.1.641.6.4.3.1.1",
                Type = "ScanCountEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a supply."
            },
            new MibEntry
            {
                Name = "scanCountIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats.scanCountTable.scanCountEntry.scanCountIndex",
                OID = ".1.3.6.1.4.1.641.6.4.3.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this row in the scanCountTable"
            },
            new MibEntry
            {
                Name = "scanCountType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats.scanCountTable.scanCountEntry.scanCountType",
                OID = ".1.3.6.1.4.1.641.6.4.3.1.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Enumeration of the type of scan that is being counted. -bit 0-7  - Application using the scanned image -bit 8-9  - Type of scan 98 -- 00 =Simplex Adf 01 =Simplex Flatbed 10 =Duplex Flatbed (both sides scanned at the same time) 11 =Duplex ADF (both sides scanned at the same time)"
            },
            new MibEntry
            {
                Name = "scanCountSize",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats.scanCountTable.scanCountEntry.scanCountSize",
                OID = ".1.3.6.1.4.1.641.6.4.3.1.1.3",
                Type = "PaperSizeTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Enumeration of the size of the paper that was scanned. If the scan is a full glass flatbed scan, the size should be 'universal'."
            },
            new MibEntry
            {
                Name = "scanCountSides",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats.scanCountTable.scanCountEntry.scanCountSides",
                OID = ".1.3.6.1.4.1.641.6.4.3.1.1.4",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Count of the number of sides of paper that were scanned."
            },
            new MibEntry
            {
                Name = "scanCountSheets",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.scanStats.scanCountTable.scanCountEntry.scanCountSheets",
                OID = ".1.3.6.1.4.1.641.6.4.3.1.1.5",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Count of the number of sheets of paper that were scanned."
            },
            new MibEntry
            {
                Name = "supplyStats",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats",
                OID = ".1.3.6.1.4.1.641.6.4.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "currentSuppliesTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable",
                OID = ".1.3.6.1.4.1.641.6.4.4.1",
                Type = "SEQUENCE OF CurrentSuppliesEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of the supplies currently in use"
            },
            new MibEntry
            {
                Name = "currentSuppliesEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1",
                Type = "CurrentSuppliesEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a supply."
            },
            new MibEntry
            {
                Name = "currentSupplyIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row for a given supply in the currentSuppliesTable"
            },
            new MibEntry
            {
                Name = "currentSupplyInventoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyInventoryIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row in the supplyInventoryTable that corresponds to this supply."
            },
            new MibEntry
            {
                Name = "currentSupplyType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyType",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of supply as referenced in the SupplyTypeTC that this row is describing."
            },
            new MibEntry
            {
                Name = "currentSupplyColorantValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyColorantValue",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.4",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The name of the color using standard string names from ISO 10175 (DPA) and ISO 10180 (SPDL) which are: other unknown white red green blue cyan magenta yellow black If a supply doesn't have a color associated with it, the value of 'none' should be returned."
            },
            new MibEntry
            {
                Name = "currentSupplyDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyDescription",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.5",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The description of this supply.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "currentSupplySerialNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplySerialNumber",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The serial number (if known) of this supply.  If not known, this field should be blank."
            },
            new MibEntry
            {
                Name = "currentSupplyPartNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyPartNumber",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The part number (if known) of this supply.  If not known, this field should be blank."
            },
            new MibEntry
            {
                Name = "currentSupplyClass",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyClass",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.8",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of this supply.  Whether it is one that is consumed (such as toner) or filled (such as a waste box)"
            },
            new MibEntry
            {
                Name = "currentSupplyCartridgeType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyCartridgeType",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.9",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of cartridge that this is as defined in CartridgeTypeTC. Supplies that are not a toner/ink cartridge should return other(2)"
            },
            new MibEntry
            {
                Name = "currentSupplyInstallDate",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyInstallDate",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.10",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The date this particular supply was installed."
            },
            new MibEntry
            {
                Name = "currentSupplyPageCountAtInstall",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyPageCountAtInstall",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.11",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The page count of the printer when this supply was installed."
            },
            new MibEntry
            {
                Name = "currentSupplyCurrentStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyCurrentStatus",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.12",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The status of this supply"
            },
            new MibEntry
            {
                Name = "currentSupplyCapacityUnit",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyCapacityUnit",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.13",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units used to measure the capacity of a supply"
            },
            new MibEntry
            {
                Name = "currentSupplyCapacity",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyCapacity",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.14",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The average expected total capacity of this supply in currentSupplyCapacityUnits"
            },
            new MibEntry
            {
                Name = "currentSupplyFirstKnownLevel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyFirstKnownLevel",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.15",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The first known supply level for this supply in currentSupplyCapacityUnits"
            },
            new MibEntry
            {
                Name = "currentSupplyCurrentLevel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyCurrentLevel",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.16",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The estimated amount of this supply remaining in currentSupplyCapacityUnits"
            },
            new MibEntry
            {
                Name = "currentSupplyUsage",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyUsage",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.17",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The amount of this supply that has been used in currentSupplyCapacityUnits.  This number may give different results from currentSupplyCurrentLevel, as it only accounts for where the supply is used in creating a page.  For instance, it would account for pages where a certain toner color was put down.  However even if that color is not put down on a page, some toner may be used in the calibration operation (for instance) and that use would be only reflected in currentSupplyCurrentLevel"
            },
            new MibEntry
            {
                Name = "currentSupplyCalibrations",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyCalibrations",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.18",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of calibration cycles that have occurred while this supply was installed.  Only calibration cycles involving this supply should be counted."
            },
            new MibEntry
            {
                Name = "currentSupplyCoverage",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyCoverage",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.19",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Absolute value for the coverage usage of this supply. Coverage is an additive amount of this supply used for all pages that this supply has been used for.  Supplies for which this is not meaningful (ie toner waste box) should return 0."
            },
            new MibEntry
            {
                Name = "currentSupplyDaysRemaining",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.currentSuppliesTable.currentSuppliesEntry.currentSupplyDaysRemaining",
                OID = ".1.3.6.1.4.1.641.6.4.4.1.1.20",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Estimated days remaining of usage for this supply. The value for this is valid ONLY for toner cartridges supplies. Supplies for which this is not meaningful (ie toner waste box) should return -1."
            },
            new MibEntry
            {
                Name = "supplyHistoryTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable",
                OID = ".1.3.6.1.4.1.641.6.4.4.2",
                Type = "SEQUENCE OF SupplyHistoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of information on supplies used previously in the device"
            },
            new MibEntry
            {
                Name = "supplyHistoryEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1",
                Type = "SupplyHistoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a supply."
            },
            new MibEntry
            {
                Name = "supplyHistoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the history item for a give current Supply and Device. Devices may report on the previous 0 or more of each of supplies in the currentSupplyTable"
            },
            new MibEntry
            {
                Name = "supplyHistoryInventoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryInventoryIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row in the supplyInventoryTable that corresponds to this supply."
            },
            new MibEntry
            {
                Name = "supplyHistorySupplyType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistorySupplyType",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of supply as referenced in the SupplyTypeTC that this row is describing."
            },
            new MibEntry
            {
                Name = "supplyHistoryColorantValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryColorantValue",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.4",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The name of the color using standard string names from ISO 10175 (DPA) and ISO 10180 (SPDL) which are: other unknown white red green blue cyan magenta yellow black If a supply doesn't have a color associated with it, the value of 'none' should be returned."
            },
            new MibEntry
            {
                Name = "supplyHistoryDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryDescription",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.5",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The description of this supply.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "supplyHistorySerialNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistorySerialNumber",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The serial number (if known) of this supply.  If not known, this field should be blank."
            },
            new MibEntry
            {
                Name = "supplyHistoryCartridgeType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryCartridgeType",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.7",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of cartridge that this is as defined in CartridgeTypeTC.  Supplies that are not a toner/ink cartridge should return other(2)"
            },
            new MibEntry
            {
                Name = "supplyHistoryInstallDate",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryInstallDate",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.8",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The date this supply was first installed."
            },
            new MibEntry
            {
                Name = "supplyHistoryPageCount",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryPageCount",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.9",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of page sides (impressions) that were printed while this supply was installed in the device."
            },
            new MibEntry
            {
                Name = "supplyHistoryCapacityUnit",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryCapacityUnit",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.10",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units used to measure the capacity of a supply"
            },
            new MibEntry
            {
                Name = "supplyHistoryCapacity",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryCapacity",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.11",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The average expected total capacity of this supply in capacity units"
            },
            new MibEntry
            {
                Name = "supplyHistoryLastLevel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryLastLevel",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.12",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The last recorded level for this supply (in capacity units)"
            },
            new MibEntry
            {
                Name = "supplyHistoryUsage",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryUsage",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.13",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The amount of this supply that was used in supplyHistoryCapacityUnits"
            },
            new MibEntry
            {
                Name = "supplyHistoryCalibrations",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryCalibrations",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.14",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The number of calibration cycles that have occurred while this supply was installed.  Only calibration cycles involving this supply should be counted."
            },
            new MibEntry
            {
                Name = "supplyHistoryCoverage",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistoryTable.supplyHistoryEntry.supplyHistoryCoverage",
                OID = ".1.3.6.1.4.1.641.6.4.4.2.1.15",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Absolute value for the coverage usage of this supply.  Coverage is an additive amount of this supply used for all pages that this supply has been used for."
            },
            new MibEntry
            {
                Name = "supplyHistogramTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable",
                OID = ".1.3.6.1.4.1.641.6.4.4.3",
                Type = "SEQUENCE OF SupplyHistogramEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of information on supplies used previously in the device"
            },
            new MibEntry
            {
                Name = "supplyHistogramEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1",
                Type = "SupplyHistogramEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a supply."
            },
            new MibEntry
            {
                Name = "supplyHistogramIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this histogram row"
            },
            new MibEntry
            {
                Name = "supplyHistogramInventoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramInventoryIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row in the supplyInventoryTable that corresponds to this supply."
            },
            new MibEntry
            {
                Name = "supplyHistogramSupplyType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramSupplyType",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of supply as referenced in the SupplyTypeTC that this row is describing."
            },
            new MibEntry
            {
                Name = "supplyHistogramColorantValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramColorantValue",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.4",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The name of the color using standard string names from ISO 10175 (DPA) and ISO 10180 (SPDL) which are: other unknown white red green blue cyan magenta yellow black If a supply doesn't have a color associated with it, the value of 'none' should be returned."
            },
            new MibEntry
            {
                Name = "supplyHistogramDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramDescription",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.5",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The description of this supply.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "supplyHistogramCapacityUnit",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramCapacityUnit",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.6",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units used to measure the capacity of a supply"
            },
            new MibEntry
            {
                Name = "supplyHistogramCapacity",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramCapacity",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.7",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The average expected total capacity of this supply in capacity units"
            },
            new MibEntry
            {
                Name = "supplyHistogramCount",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramCount",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.8",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The amount of this supply that was used in supplyHistogramCountUnits (for the corresponding current supply).  This is intended to count the number of supplies of a given size that have been used over the life of this product."
            },
            new MibEntry
            {
                Name = "supplyHistogramCountUnits",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramTable.supplyHistogramEntry.supplyHistogramCountUnits",
                OID = ".1.3.6.1.4.1.641.6.4.4.3.1.9",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units that this supply is measured in."
            },
            new MibEntry
            {
                Name = "supplyHistogramWithHistoryTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable",
                OID = ".1.3.6.1.4.1.641.6.4.4.4",
                Type = "SEQUENCE OF SupplyHistogramHistoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of information on supplies used previously in the device"
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1",
                Type = "SupplyHistogramHistoryEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information on a supply."
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this histogram row"
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryInventoryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryInventoryIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row in the supplyInventoryTable that corresponds to this supply."
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryCountIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryCountIndex",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row in the history that corresponds to this supply."
            },
            new MibEntry
            {
                Name = "supplyHistogramHistorySupplyType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistorySupplyType",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The type of supply as referenced in the SupplyTypeTC that this row is describing."
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryColorantValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryColorantValue",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.5",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The name of the color using standard string names from ISO 10175 (DPA) and ISO 10180 (SPDL) which are: other unknown white red green blue cyan magenta yellow black If a supply doesn't have a color associated with it, the value of 'none' should be returned."
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryDescription",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.6",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The description of this supply.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryCapacityUnit",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryCapacityUnit",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.7",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units used to measure the capacity of a supply"
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryCapacity",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryCapacity",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.8",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The average expected total capacity of this supply in capacity units"
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryCount",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryCount",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.9",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The amount of this supply that was used in supplyHistogramHistoryCountUnits (for the corresponding current supply).  This is intended to count the number of supplies of a given size that have been used over the life of this product."
            },
            new MibEntry
            {
                Name = "supplyHistogramHistoryCountUnits",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.stats.supplyStats.supplyHistogramWithHistoryTable.supplyHistogramHistoryEntry.supplyHistogramHistoryCountUnits",
                OID = ".1.3.6.1.4.1.641.6.4.4.4.1.10",
                Type = "UnitsTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The units that this supply is measured in."
            },
            new MibEntry
            {
                Name = "alerts",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts",
                OID = ".1.3.6.1.4.1.641.6.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "deviceAlertTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable",
                OID = ".1.3.6.1.4.1.641.6.5.1",
                Type = "SEQUENCE OF DeviceAlertEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A table of alerts on the devices."
            },
            new MibEntry
            {
                Name = "deviceAlertEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry",
                OID = ".1.3.6.1.4.1.641.6.5.1.1",
                Type = "DeviceAlertEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information about this alert."
            },
            new MibEntry
            {
                Name = "deviceAlertIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertIndex",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of this alert in the alert table.  This table is expected to be rather dynamic, with rows added as alert conditions occur on devices, and then the rows being removed as alert conditions are cleared.  The data in this table should not persist over a POR, but should be reset when the printer is reset, with appropriated items being added back in as the printer finds them. While this OID is marked as read-only, it should not be returned as table-column, which means it should be treated as not-accessible. It is marked as read-only in the MIB only because many MIB compilers will complain about this being called not-accessible since the trap can return this index."
            },
            new MibEntry
            {
                Name = "deviceAlertConfigTableNode",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertConfigTableNode",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The subnode of the device node that indicates the table the holds information about the item this alert refers to.  For instance, if the alert is a hardware alert, this object should hold the value of '2', indicating that the alert is for a member of the device.hwInventoryTable.  Common values of this would be 2 -> hwInventoryTable 3 -> supplyInventoryTable 4 -> swInventoryTable"
            },
            new MibEntry
            {
                Name = "deviceAlertConfigTableIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertConfigTableIndex",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The index of the row of the table indicated by deviceAlertConfigTableNode that corresponds to the item that this alert pertains to.  For instance, if a printer's fuser is the first item listed in the supplyInventoryTable, then deviceAlertConfigTableNode =3 and deviceAlertConfigTableIndex =1."
            },
            new MibEntry
            {
                Name = "deviceAlertSeverity",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertSeverity",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The severity of this alert"
            },
            new MibEntry
            {
                Name = "deviceAlertCode",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertCode",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An alert code to indicate what type of alert condition this row refers to"
            },
            new MibEntry
            {
                Name = "deviceAlertDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertDescription",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.6",
                Type = "SNMPADMINSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A description of the alert condition.  If changing localization is supported, this description should be displayed in the language set in deviceMibLocalization."
            },
            new MibEntry
            {
                Name = "deviceAlertData",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertData",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.7",
                Type = "KeyValueTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A key=value;encoded string of information regarding this row."
            },
            new MibEntry
            {
                Name = "deviceAlertTime",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertTime",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.8",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The time and date when this alert was added to the table."
            },
            new MibEntry
            {
                Name = "deviceAlertSeverityLevel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertSeverityLevel",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.9",
                Type = "PrtAlertSeverityLevelTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The level of severity of this alert table entry.  The printer determines the severity level assigned to each entry into the table."
            },
            new MibEntry
            {
                Name = "deviceAlertTrainingLevel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertTrainingLevel",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.10",
                Type = "PrtAlertTrainingLevelTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"See textual convention PrtAlertTrainingLevelTC"
            },
            new MibEntry
            {
                Name = "deviceAlertPrtCode",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceAlertTable.deviceAlertEntry.deviceAlertPrtCode",
                OID = ".1.3.6.1.4.1.641.6.5.1.1.11",
                Type = "PrtAlertCodeTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"See associated textual convention PrtAlertCodeTC"
            },
            new MibEntry
            {
                Name = "deviceV1AlertMPS",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceV1AlertMPS",
                OID = ".1.3.6.1.4.1.641.6.5.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "deviceV2AlertMPSPrefix",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceV1AlertMPS.deviceV2AlertMPSPrefix",
                OID = ".1.3.6.1.4.1.641.6.5.2.0",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "deviceV2AlertMPS",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.alerts.deviceV1AlertMPS.deviceV2AlertMPSPrefix.deviceV2AlertMPS",
                OID = ".1.3.6.1.4.1.641.6.5.2.0.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"This trap is sent whenever a critical or serviceRequired event is added to the deviceAlertTable."
            },
            new MibEntry
            {
                Name = "logs",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.logs",
                OID = ".1.3.6.1.4.1.641.6.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "applications",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.applications",
                OID = ".1.3.6.1.4.1.641.6.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "outputfeature",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature",
                OID = ".1.3.6.1.4.1.641.6.8",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "outputOptionFeatureTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable",
                OID = ".1.3.6.1.4.1.641.6.8.1",
                Type = "SEQUENCE OF OUTPUTOptionEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Table of output bins and its atrributes"
            },
            new MibEntry
            {
                Name = "outputOptionEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry",
                OID = ".1.3.6.1.4.1.641.6.8.1.1",
                Type = "OUTPUTOptionEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"An entry containing information of an output bin option item."
            },
            new MibEntry
            {
                Name = "outputOptionIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputOptionIndex",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"A unique value used to identify this output option item."
            },
            new MibEntry
            {
                Name = "outputOptionName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputOptionName",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"The name assigned to this output bin. It will return the user-defined bin name if it has been set."
            },
            new MibEntry
            {
                Name = "outputLevelSensing",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputLevelSensing",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Specifies whether levelsense is supported on this output bin."
            },
            new MibEntry
            {
                Name = "outputOffsetting",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputOffsetting",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Specifies whether offset is supported on this output bin."
            },
            new MibEntry
            {
                Name = "outputFoldSupport",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputFoldSupport",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.5",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Specifies the fold type of this output bin and must be looked at as a bit field. outputFoldSupport will be defined as: Bit 0 =Supported Bit 1 =Z Fold Bit 2 =Half Fold Bit 3 =Letter Fold Bit 4 =Signature Bits 5-31 =Reserved "
            },
            new MibEntry
            {
                Name = "outputfaceOrientation",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputfaceOrientation",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.6",
                Type = "PrtOutputPageDeliveryOrientationTC",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"See associated textual convention PrtOutputPageDeliveryOrientationTC"
            },
            new MibEntry
            {
                Name = "outputBindingCapable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputBindingCapable",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.7",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Specifies the bind type of this output bin and must be looked at as a bit field. outputBindingCapable will be defined as: Bit 0 =Staple Bit 1 =BookStaple Bit 2 =Adhesive Binding Bit 3 =Comb Binding Bit 4 =Spiral Binding Bits 5-31 =Reserved "
            },
            new MibEntry
            {
                Name = "outputSeparationCapable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputSeparationCapable",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.8",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Specifies if the output bin is separation-capable. Currently, value is always 1."
            },
            new MibEntry
            {
                Name = "outputStitchingCapable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputStitchingCapable",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.9",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Specifies if the output bin is stitching-capable. Currently, value is always 0."
            },
            new MibEntry
            {
                Name = "outputPunchingCapable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.mps.outputfeature.outputOptionFeatureTable.outputOptionEntry.outputPunchingCapable",
                OID = ".1.3.6.1.4.1.641.6.8.1.1.10",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-MPS-MIB",
                Description = @"Specifies the punch hole mode supported by this output bin and must be looked at as a bit field. outputPunchingCapable will be defined as: Bit 0 =1 hole Bit 1 =2 hole Bit 2 =3 hole Bit 3 =4 hole Bit 4 =5 hole Bit 5 =6 hole Bit 6 =7 hole Bit 7 =8 hole Bits 8-31 =Reserved "
            },
            new MibEntry
            {
                Name = "settings",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings",
                OID = ".1.3.6.1.4.1.641.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "settingsDefinition",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition",
                OID = ".1.3.6.1.4.1.641.7.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "settingsQuery",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery",
                OID = ".1.3.6.1.4.1.641.7.3.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @""
            },
            new MibEntry
            {
                Name = "queryId",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryId",
                OID = ".1.3.6.1.4.1.641.7.3.7.1",
                Type = "INTEGER32",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An NPA ID from the npaIdTable.  Tables in the settingsQuery branch will only be populated with the information specified by this NPA ID."
            },
            new MibEntry
            {
                Name = "querySettingTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable",
                OID = ".1.3.6.1.4.1.641.7.3.7.2",
                Type = "SEQUENCE OF QuerySettingEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table defining the setting attributes that are dependent only on the selected NPA ID index value.   This information will permit usage and presentation of these settings by a remote tool."
            },
            new MibEntry
            {
                Name = "querySettingEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1",
                Type = "QuerySettingEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry containing a setting attribute definition."
            },
            new MibEntry
            {
                Name = "querySettingName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingName",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.1",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Setting 'public name' definition.  This is for tool usage and comparison of the setting definition to previous access methods."
            },
            new MibEntry
            {
                Name = "querySettingVccId",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingVccId",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"VCC setting Name if it exists.   "
            },
            new MibEntry
            {
                Name = "querySettingGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingGroup",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The Settings Group Identifier allows the remote tool to logically group settings into categories if desired."
            },
            new MibEntry
            {
                Name = "querySettingAccess",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingAccess",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Indicates the access level (RO, RW, or W)"
            },
            new MibEntry
            {
                Name = "querySettingReboot",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingReboot",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Integer  that indicates whether a reboot is required for activation or whether a change triggers a reboot"
            },
            new MibEntry
            {
                Name = "querySettingDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingDescription",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Setting description string"
            },
            new MibEntry
            {
                Name = "querySettingNpaId",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingNpaId",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.7",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"NPA ID value that is used for the index in an accessible field."
            },
            new MibEntry
            {
                Name = "querySettingIdValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingIdValue",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.8",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"ID for the Setting Name, permitting identification of the display string assigned to this setting..  For future use."
            },
            new MibEntry
            {
                Name = "querySettingIdStringName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingIdStringName",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.9",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The text string associated with the settingIdValue.   For future use."
            },
            new MibEntry
            {
                Name = "querySettingIdLocalizedString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingIdLocalizedString",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.10",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The localized text string associated with the querySettingIdValue, using the language selection specified in the LEXMARK-SETTINGS-CONTROL MIB. For future use."
            },
            new MibEntry
            {
                Name = "querySettingType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingTable.querySettingEntry.querySettingType",
                OID = ".1.3.6.1.4.1.641.7.3.7.2.1.11",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Specifies the type of this setting and must be looked at as a bit field. The first 3 bits are used to determine whether the Integer, String or Octet setting entries in the settingValueTable are to be used for return of the current and default values for this setting. Additional bits are used to determine whether the setting is indexed, a password, an integer range and/or enumeration, boolean, and signed/unsigned (applies to non-boolean integers). If the setting returns an integer result, then the 'settingCurrentValueIfInteger'  and 'settingFactoryDefaultIfInteger' entries will contain the current and default values.   If the setting returns a string result, then the 'settingCurrentValueIfString' and 'settingFactoryDefaultIfString' entries will contain the current and default values. If the setting returns an octet result, then the 'settingCurrentValueIfOctet' and 'settingFactoryDefaultIfOctet' entries will contain the current and default values. querySettingType will be defined as: Bit 0,1,2 - Define the variable type -Value 0 =Unknown -Value 1 =Integer -Value 2 =String -Value 3 =Octet -Values 4-7 =Reserved Bit 3 =Range Bit 4 =Enumeration Bit 5 =Indexed Bit 6 =Boolean Bit 7 =Password Bit 8 =Signed Bit 9 =Ip Address (v4) Bit 10 =Ip Address (v6) Bits 11-31 =Reserved "
            },
            new MibEntry
            {
                Name = "querySettingValueTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable",
                OID = ".1.3.6.1.4.1.641.7.3.7.3",
                Type = "SEQUENCE OF QuerySettingValueEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table defining the current and default values for the setting.  The querySettingIndex is only used for settings that are indexed, storing multiple values associated with one setting name.  Most settings are not indexed and return a single scalar result (settingValueIndex=1)."
            },
            new MibEntry
            {
                Name = "querySettingValueEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1",
                Type = "QuerySettingValueEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry containing a setting attribute definition."
            },
            new MibEntry
            {
                Name = "querySettingValueIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingValueIndex",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A unique value used to identify this querySettingEntry index.  "
            },
            new MibEntry
            {
                Name = "querySettingNpaIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingNpaIndex",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"For settings which have a single value associated with them (non-indexed) this will have a value of 0. For settings which have more than one value associated with them (indexed), the first indexed entry will have a value of 0. Each succeeding indexed entry will return the value of the previous indexed entry incremented by one (1)."
            },
            new MibEntry
            {
                Name = "querySettingCurValIfInt",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingCurValIfInt",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Current value for the setting if the setting returns an integer result. Otherwise, this column will not be returned ."
            },
            new MibEntry
            {
                Name = "querySettingCurrentValueIfString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingCurrentValueIfString",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.4",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Current value for the setting if the setting returns a string result. Otherwise, this column will not be returned ."
            },
            new MibEntry
            {
                Name = "querySettingCurValIfOctet",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingCurValIfOctet",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.5",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Current value for the setting if the setting returns an octet result. Otherwise, this column will not be returned. "
            },
            new MibEntry
            {
                Name = "querySettingFactDefIfInt",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingFactDefIfInt",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.6",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Factory Default Value for the setting  if the setting returns an integer result. Otherwise, this column will not be returned. "
            },
            new MibEntry
            {
                Name = "querySettingFactDefIfString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingFactDefIfString",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.7",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Factory Default Value for the setting if the setting returns a string result. Otherwise, this column will not be returned. "
            },
            new MibEntry
            {
                Name = "querySettingFactDefIfOctet",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.querySettingValueTable.querySettingValueEntry.querySettingFactDefIfOctet",
                OID = ".1.3.6.1.4.1.641.7.3.7.3.1.8",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Factory Default Value for the setting if the setting returns an octet result. Otherwise, this column will not be returned."
            },
            new MibEntry
            {
                Name = "queryValueRangeTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryValueRangeTable",
                OID = ".1.3.6.1.4.1.641.7.3.7.4",
                Type = "SEQUENCE OF QueryValueRangeEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table of value ranges for a setting which returns an integer result. NOTE:If the 'signed' bit of settingType (in the settingTable) is 1 for the given setting, then clients must interpret valueRangeMin, valueRangeMax and valueRangeIncrement as signed integers. Otherwise, clients must interpret these as unsigned integers."
            },
            new MibEntry
            {
                Name = "queryValueRangeEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryValueRangeTable.queryValueRangeEntry",
                OID = ".1.3.6.1.4.1.641.7.3.7.4.1",
                Type = "QueryValueRangeEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry of the queryValueRangeTable."
            },
            new MibEntry
            {
                Name = "queryValueRangeMin",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryValueRangeTable.queryValueRangeEntry.queryValueRangeMin",
                OID = ".1.3.6.1.4.1.641.7.3.7.4.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Minimum value."
            },
            new MibEntry
            {
                Name = "queryValueRangeMax",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryValueRangeTable.queryValueRangeEntry.queryValueRangeMax",
                OID = ".1.3.6.1.4.1.641.7.3.7.4.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Max value."
            },
            new MibEntry
            {
                Name = "queryValueRangeIncrement",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryValueRangeTable.queryValueRangeEntry.queryValueRangeIncrement",
                OID = ".1.3.6.1.4.1.641.7.3.7.4.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"How much a value increments."
            },
            new MibEntry
            {
                Name = "queryValueRangeDecimalPlaces",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryValueRangeTable.queryValueRangeEntry.queryValueRangeDecimalPlaces",
                OID = ".1.3.6.1.4.1.641.7.3.7.4.1.4",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"How many decimal places do I have?"
            },
            new MibEntry
            {
                Name = "queryEnumValuesTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable",
                OID = ".1.3.6.1.4.1.641.7.3.7.5",
                Type = "SEQUENCE OF QueryEnumValuesEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table of enumeration values."
            },
            new MibEntry
            {
                Name = "queryEnumValuesEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1",
                Type = "QueryEnumValuesEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry of the EnumValuesTable."
            },
            new MibEntry
            {
                Name = "queryEnumValuesIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry.queryEnumValuesIndex",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A unique value used to identify this queryEnumValuesEntry index."
            },
            new MibEntry
            {
                Name = "queryEnumValuesValueIfInt",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry.queryEnumValuesValueIfInt",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Integer enum value. This column is not returned if the setting is a string enumeration"
            },
            new MibEntry
            {
                Name = "queryEnumValuesName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry.queryEnumValuesName",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"String setting value name that is derived from the VCC value name."
            },
            new MibEntry
            {
                Name = "queryEnumValuesTextIdValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry.queryEnumValuesTextIdValue",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1.4",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"raw integer giving Text-ID value for the enum. For potential future usage.  Note:if value is 0, then use enumTextIdLocalized string."
            },
            new MibEntry
            {
                Name = "queryEnumValuesTextIdString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry.queryEnumValuesTextIdString",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1.5",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Text-ID identifier string for the enum. For potential future usage.   Note:if value is null, then use enumTextIdLocalized string."
            },
            new MibEntry
            {
                Name = "queryEnumValuesTextIdLocalized",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry.queryEnumValuesTextIdLocalized",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Localized Text-ID string for the enum. For potential future usage"
            },
            new MibEntry
            {
                Name = "queryEnumValuesValueIfString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryEnumValuesTable.queryEnumValuesEntry.queryEnumValuesValueIfString",
                OID = ".1.3.6.1.4.1.641.7.3.7.5.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"String enumeration value. This column is not returned if the setting is an integer enumeration"
            },
            new MibEntry
            {
                Name = "queryLimitsTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryLimitsTable",
                OID = ".1.3.6.1.4.1.641.7.3.7.6",
                Type = "SEQUENCE OF QueryLimitsEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table of limits that is utilized when the setting value returned is a String or Octet."
            },
            new MibEntry
            {
                Name = "queryLimitsEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryLimitsTable.queryLimitsEntry",
                OID = ".1.3.6.1.4.1.641.7.3.7.6.1",
                Type = "QueryLimitsEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry of the limitsTable."
            },
            new MibEntry
            {
                Name = "queryLimitsMaxLength",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryLimitsTable.queryLimitsEntry.queryLimitsMaxLength",
                OID = ".1.3.6.1.4.1.641.7.3.7.6.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The maximum length of a string or octet in bytes."
            },
            new MibEntry
            {
                Name = "queryLimitsMinLength",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryLimitsTable.queryLimitsEntry.queryLimitsMinLength",
                OID = ".1.3.6.1.4.1.641.7.3.7.6.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The minimum length of a string or octet in bytes."
            },
            new MibEntry
            {
                Name = "queryRegularExpression",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingsQuery.queryLimitsTable.queryLimitsEntry.queryRegularExpression",
                OID = ".1.3.6.1.4.1.641.7.3.7.6.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The specific textual syntax that this setting needs to conform to."
            },
            new MibEntry
            {
                Name = "npaIdTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.npaIdTable",
                OID = ".1.3.6.1.4.1.641.7.3.1",
                Type = "SEQUENCE OF NpaIdEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table of settings NPA IDs that have been returned."
            },
            new MibEntry
            {
                Name = "npaIdEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.npaIdTable.npaIdEntry",
                OID = ".1.3.6.1.4.1.641.7.3.1.1",
                Type = "NpaIdEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry of the npaIdTable."
            },
            new MibEntry
            {
                Name = "npaIdIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.npaIdTable.npaIdEntry.npaIdIndex",
                OID = ".1.3.6.1.4.1.641.7.3.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A unique value used to identify this settingsDefinition entry index."
            },
            new MibEntry
            {
                Name = "settingTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable",
                OID = ".1.3.6.1.4.1.641.7.3.2",
                Type = "SEQUENCE OF SettingEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table defining the setting attributes that are dependent only on the selected NPA ID index value.   This information will permit usage and presentation of these settings by a remote tool."
            },
            new MibEntry
            {
                Name = "settingEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry",
                OID = ".1.3.6.1.4.1.641.7.3.2.1",
                Type = "SettingEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry containing a setting attribute definition."
            },
            new MibEntry
            {
                Name = "settingName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingName",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.1",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Setting 'public name' definition.  This is for tool usage and comparison of the setting definition to previous access methods."
            },
            new MibEntry
            {
                Name = "settingVccId",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingVccId",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"VCC setting Name if it exists.   "
            },
            new MibEntry
            {
                Name = "settingGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingGroup",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The Settings Group Identifier allows the remote tool to logically group settings into categories if desired."
            },
            new MibEntry
            {
                Name = "settingAccess",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingAccess",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Indicates the access level (RO, RW, or W)"
            },
            new MibEntry
            {
                Name = "settingReboot",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingReboot",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Integer  that indicates whether a reboot is required for activation or whether a change triggers a reboot"
            },
            new MibEntry
            {
                Name = "settingDescription",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingDescription",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Setting description string"
            },
            new MibEntry
            {
                Name = "settingNpaId",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingNpaId",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.7",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"NPA ID value that is used for the index in an accessible field."
            },
            new MibEntry
            {
                Name = "settingIdValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingIdValue",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.8",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"ID for the Setting Name, permitting identification of the display string assigned to this setting..  For future use."
            },
            new MibEntry
            {
                Name = "settingIdStringName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingIdStringName",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.9",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The text string associated with the settingIdValue.   For future use."
            },
            new MibEntry
            {
                Name = "settingIdLocalizedString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingIdLocalizedString",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.10",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The localized text string associated with the settingIdValue, using the language selection specified in the LEXMARK-SETTINGS-CONTROL MIB. For future use."
            },
            new MibEntry
            {
                Name = "settingType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingTable.settingEntry.settingType",
                OID = ".1.3.6.1.4.1.641.7.3.2.1.11",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Specifies the type of this setting and must be looked at as a bit field. The first 3 bits are used to determine whether the Integer, String or Octet setting entries in the settingValueTable are to be used for return of the current and default values for this setting. Additional bits are used to determine whether the setting is indexed, a password, an integer range and/or enumeration, boolean, and signed/unsigned (applies to non-boolean integers). If the setting returns an integer result, then the 'settingCurrentValueIfInteger'  and 'settingFactoryDefaultIfInteger' entries will contain the current and default values.   If the setting returns a string result, then the 'settingCurrentValueIfString' and 'settingFactoryDefaultIfString' entries will contain the current and default values. If the setting returns an octet result, then the 'settingCurrentValueIfOctet' and 'settingFactoryDefaultIfOctet' entries will contain the current and default values. settingType will be defined as: Bit 0,1,2 - Define the variable type -Value 0 =Unknown -Value 1 =Integer -Value 2 =String -Value 3 =Octet -Values 4-7 =Reserved Bit 3 =Range Bit 4 =Enumeration Bit 5 =Indexed Bit 6 =Boolean Bit 7 =Password Bit 8 =Signed Bit 9 =Ip Address (v4) Bit 10 =Ip Address (v6) Bits 11-31 =Reserved "
            },
            new MibEntry
            {
                Name = "settingValueTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable",
                OID = ".1.3.6.1.4.1.641.7.3.3",
                Type = "SEQUENCE OF SettingValueEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table defining the current and default values for the setting.  The settingValueIndex is only used for settings that are indexed, storing multiple values associated with one setting name.  Most settings are not indexed and return a single scalar result (settingValueIndex=1)."
            },
            new MibEntry
            {
                Name = "settingValueEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry",
                OID = ".1.3.6.1.4.1.641.7.3.3.1",
                Type = "SettingValueEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry containing a setting attribute definition."
            },
            new MibEntry
            {
                Name = "settingValueIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingValueIndex",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A unique value used to indicate the row of this table."
            },
            new MibEntry
            {
                Name = "settingNpaIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingNpaIndex",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"For settings which have a single value associated with them (non-indexed) this will have a value of 0. For settings which have more than one value associated with them (indexed), the first indexed entry will have a value of 0. Each succeeding indexed entry will return the value of the previous indexed entry incremented by one (1)."
            },
            new MibEntry
            {
                Name = "settingCurrentValueIfInteger",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingCurrentValueIfInteger",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Current value for the setting if the setting returns an integer result. Otherwise, this column will not be returned ."
            },
            new MibEntry
            {
                Name = "settingCurrentValueIfString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingCurrentValueIfString",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.4",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Current value for the setting if the setting returns a string result. Otherwise, this column will not be returned ."
            },
            new MibEntry
            {
                Name = "settingCurrentValueIfOctet",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingCurrentValueIfOctet",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.5",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Current value for the setting if the setting returns an octet result. Otherwise, this column will not be returned ."
            },
            new MibEntry
            {
                Name = "settingFactoryDefaultIfInteger",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingFactoryDefaultIfInteger",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.6",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Factory Default Value for the setting  if the setting returns an integer result. Otherwise, this column will not be returned. "
            },
            new MibEntry
            {
                Name = "settingFactoryDefaultIfString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingFactoryDefaultIfString",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.7",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Factory Default Value for the setting if the setting returns a string result. Otherwise, this column will not be returned. "
            },
            new MibEntry
            {
                Name = "settingFactoryDefaultIfOctet",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.settingValueTable.settingValueEntry.settingFactoryDefaultIfOctet",
                OID = ".1.3.6.1.4.1.641.7.3.3.1.8",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Factory Default Value for the setting if the setting returns an octet result. Otherwise, this column will not be returned. "
            },
            new MibEntry
            {
                Name = "valueRangeTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.valueRangeTable",
                OID = ".1.3.6.1.4.1.641.7.3.4",
                Type = "SEQUENCE OF ValueRangeEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table of value ranges for a setting which returns an integer result. NOTE:If the 'signed' bit of settingType (in the settingTable) is 1 for the given setting, then clients must interpret valueRangeMin, valueRangeMax and valueRangeIncrement as signed integers. Otherwise, clients must interpret these as unsigned integers."
            },
            new MibEntry
            {
                Name = "valueRangeEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.valueRangeTable.valueRangeEntry",
                OID = ".1.3.6.1.4.1.641.7.3.4.1",
                Type = "ValueRangeEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry of the valueRangeTable."
            },
            new MibEntry
            {
                Name = "valueRangeMin",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.valueRangeTable.valueRangeEntry.valueRangeMin",
                OID = ".1.3.6.1.4.1.641.7.3.4.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Minimum value."
            },
            new MibEntry
            {
                Name = "valueRangeMax",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.valueRangeTable.valueRangeEntry.valueRangeMax",
                OID = ".1.3.6.1.4.1.641.7.3.4.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Max value."
            },
            new MibEntry
            {
                Name = "valueRangeIncrement",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.valueRangeTable.valueRangeEntry.valueRangeIncrement",
                OID = ".1.3.6.1.4.1.641.7.3.4.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"How much a value increments."
            },
            new MibEntry
            {
                Name = "valueRangeDecimalPlaces",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.valueRangeTable.valueRangeEntry.valueRangeDecimalPlaces",
                OID = ".1.3.6.1.4.1.641.7.3.4.1.4",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"How many decimal places do I have?"
            },
            new MibEntry
            {
                Name = "enumValuesTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable",
                OID = ".1.3.6.1.4.1.641.7.3.5",
                Type = "SEQUENCE OF EnumValuesEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table of enumeration values."
            },
            new MibEntry
            {
                Name = "enumValuesEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry",
                OID = ".1.3.6.1.4.1.641.7.3.5.1",
                Type = "EnumValuesEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry of the EnumValuesTable."
            },
            new MibEntry
            {
                Name = "enumValuesIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry.enumValuesIndex",
                OID = ".1.3.6.1.4.1.641.7.3.5.1.1",
                Type = "INTEGER32",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A unique value used to identify this enumValuesEntry index."
            },
            new MibEntry
            {
                Name = "enumValuesValueIfInt",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry.enumValuesValueIfInt",
                OID = ".1.3.6.1.4.1.641.7.3.5.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Integer enum value. This column is not returned if the setting is a string enumeration."
            },
            new MibEntry
            {
                Name = "enumValuesName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry.enumValuesName",
                OID = ".1.3.6.1.4.1.641.7.3.5.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"String setting value name that is derived from the VCC value name."
            },
            new MibEntry
            {
                Name = "enumValuesTextIdValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry.enumValuesTextIdValue",
                OID = ".1.3.6.1.4.1.641.7.3.5.1.4",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"raw integer giving Text-ID value for the enum. For potential future usage.  Note:if value is 0, then use enumTextIdLocalized string."
            },
            new MibEntry
            {
                Name = "enumValuesTextIdString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry.enumValuesTextIdString",
                OID = ".1.3.6.1.4.1.641.7.3.5.1.5",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Text-ID identifier string for the enum. For potential future usage.   Note:if value is null, then use enumTextIdLocalized string."
            },
            new MibEntry
            {
                Name = "enumValuesTextIdLocalized",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry.enumValuesTextIdLocalized",
                OID = ".1.3.6.1.4.1.641.7.3.5.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"Localized Text-ID string for the enum. For potential future usage"
            },
            new MibEntry
            {
                Name = "enumValuesValueIfString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.enumValuesTable.enumValuesEntry.enumValuesValueIfString",
                OID = ".1.3.6.1.4.1.641.7.3.5.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"String enumeration value. This column is not returned if the setting is an integer enumeration."
            },
            new MibEntry
            {
                Name = "limitsTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.limitsTable",
                OID = ".1.3.6.1.4.1.641.7.3.6",
                Type = "SEQUENCE OF LimitsEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"A table of limits that is utilized when the setting value returned is a string or octet."
            },
            new MibEntry
            {
                Name = "limitsEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.limitsTable.limitsEntry",
                OID = ".1.3.6.1.4.1.641.7.3.6.1",
                Type = "LimitsEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"An entry of the limitsTable."
            },
            new MibEntry
            {
                Name = "limitsMaxLength",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.limitsTable.limitsEntry.limitsMaxLength",
                OID = ".1.3.6.1.4.1.641.7.3.6.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The maximum length of a string or octet in bytes."
            },
            new MibEntry
            {
                Name = "limitsMinLength",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.limitsTable.limitsEntry.limitsMinLength",
                OID = ".1.3.6.1.4.1.641.7.3.6.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The minimum length of a string or octet in bytes."
            },
            new MibEntry
            {
                Name = "regularExpression",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsDefinition.limitsTable.limitsEntry.regularExpression",
                OID = ".1.3.6.1.4.1.641.7.3.6.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The specific textual syntax that this setting needs to conform to."
            },
            new MibEntry
            {
                Name = "settingsMIBAdminInfo",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsMIBAdminInfo",
                OID = ".1.3.6.1.4.1.641.7.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "settingsMIBGroups",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsMIBAdminInfo.settingsMIBGroups",
                OID = ".1.3.6.1.4.1.641.7.1.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "definitionGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsMIBAdminInfo.settingsMIBGroups.definitionGroup",
                OID = ".1.3.6.1.4.1.641.7.1.2.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The Definition Group."
            },
            new MibEntry
            {
                Name = "controlGroup",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsMIBAdminInfo.settingsMIBGroups.controlGroup",
                OID = ".1.3.6.1.4.1.641.7.1.2.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-CONTROL-MIB",
                Description = @"The Control Group."
            },
            new MibEntry
            {
                Name = "settingsMIBCompliances",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsMIBAdminInfo.settingsMIBCompliances",
                OID = ".1.3.6.1.4.1.641.7.1.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "definitionMIBCompliance",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsMIBAdminInfo.settingsMIBCompliances.definitionMIBCompliance",
                OID = ".1.3.6.1.4.1.641.7.1.1.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-DEFINITION",
                Description = @"The requirements for conformance to the LEXMARK-SETTINGS-CONTROL MIB."
            },
            new MibEntry
            {
                Name = "controlMIBCompliance",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsMIBAdminInfo.settingsMIBCompliances.controlMIBCompliance",
                OID = ".1.3.6.1.4.1.641.7.1.1.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-CONTROL-MIB",
                Description = @"The requirements for conformance to the LEXMARK-SETTINGS-CONTROL MIB."
            },
            new MibEntry
            {
                Name = "settingsControl",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsControl",
                OID = ".1.3.6.1.4.1.641.7.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-SETTINGS-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "mibWalkControl",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsControl.mibWalkControl",
                OID = ".1.3.6.1.4.1.641.7.2.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-SETTINGS-CONTROL-MIB",
                Description = @"Controls what is returned in a MIB walk of the device settings.  A device control setting is defined which will specify whether the 7.2 (settingsValue) MIB data and/or the 7.3 (settingsDefinition) MIB data will be included in a device MIB walk. This is defined because it takes a long time (and generates a lot of web traffic) to return a response for these MIBs.     The default will be neither the 7.2 nor the 7.3 MIBs will be included in a 1.3.6.1.4.1.641 MIB walk."
            },
            new MibEntry
            {
                Name = "mibLocalizeControl",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.settings.settingsControl.mibLocalizeControl",
                OID = ".1.3.6.1.4.1.641.7.2.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-SETTINGS-CONTROL-MIB",
                Description = @"Selects the language to be retuned when a localized response is specified.  The desired language will be specified with the two byte language selection values specified for the device."
            },
            new MibEntry
            {
                Name = "adapter",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter",
                OID = ".1.3.6.1.4.1.641.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "opsys",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys",
                OID = ".1.3.6.1.4.1.641.1.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "opsysCodeRev",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCodeRev",
                OID = ".1.3.6.1.4.1.641.1.1.1",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual identification of network adapter's firmware revision level.  For example:7.15.1"
            },
            new MibEntry
            {
                Name = "opsysJobTimeout",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysJobTimeout",
                OID = ".1.3.6.1.4.1.641.1.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The adapter job timeout period in seconds."
            },
            new MibEntry
            {
                Name = "opsysCurrentJob",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCurrentJob",
                OID = ".1.3.6.1.4.1.641.1.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual description of the currently printing job containing the Source NOS, Source server, Source user, Job number, and Job size, separated by CR LF.  A NULL string indicates no active job. For multiport adapters, this reflects job status of printer port 1."
            },
            new MibEntry
            {
                Name = "opsysRAMSize",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysRAMSize",
                OID = ".1.3.6.1.4.1.641.1.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The size of the network adapter's RAM in bytes."
            },
            new MibEntry
            {
                Name = "opsysNVRAMSize",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysNVRAMSize",
                OID = ".1.3.6.1.4.1.641.1.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The size of the network adapter's NVRAM in bytes."
            },
            new MibEntry
            {
                Name = "opsysROMSize",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysROMSize",
                OID = ".1.3.6.1.4.1.641.1.1.6",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The size of the network adapter's ROM in bytes."
            },
            new MibEntry
            {
                Name = "opsysROMType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysROMType",
                OID = ".1.3.6.1.4.1.641.1.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual description of the network adapter's ROM technology. Currently valid types are:MASK_ROM, OTP, FLASH, UV_EPROM, EEPROM, and OTHER."
            },
            new MibEntry
            {
                Name = "opsysProtocols",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysProtocols",
                OID = ".1.3.6.1.4.1.641.1.1.8",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A bitmap representing the protocols supported by the network adapter. Bit  Value  Protocol ------------------ 0    1      LexLink 1    2      Netware 2    4      AppleTalk 3    8      TCP/IP 4    16     AirPrint 5    32     reserved 6    64     NDS"
            },
            new MibEntry
            {
                Name = "opsysTimeToReset",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysTimeToReset",
                OID = ".1.3.6.1.4.1.641.1.1.9",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The amount of time remaining until the adapter performs a power on reset.  A value of -1 indicates no reset is scheduled. Setting to 0 causes the adapter to reset immediately. The only valid set value is 0."
            },
            new MibEntry
            {
                Name = "opsysCardPartNo",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCardPartNo",
                OID = ".1.3.6.1.4.1.641.1.1.10",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of the network adapter's part number."
            },
            new MibEntry
            {
                Name = "opsysCardEC",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCardEC",
                OID = ".1.3.6.1.4.1.641.1.1.11",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of the network adapter's EC level."
            },
            new MibEntry
            {
                Name = "opsysCurrentJobTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCurrentJobTable",
                OID = ".1.3.6.1.4.1.641.1.1.12",
                Type = "SEQUENCE OF OpsysCurrentJobEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of current job information for each of the network adapter's printer ports."
            },
            new MibEntry
            {
                Name = "opsysCurrentJobEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCurrentJobTable.opsysCurrentJobEntry",
                OID = ".1.3.6.1.4.1.641.1.1.12.1",
                Type = "OpsysCurrentJobEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing job information for one printer port."
            },
            new MibEntry
            {
                Name = "opsysCurrentJobEntryIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCurrentJobTable.opsysCurrentJobEntry.opsysCurrentJobEntryIndex",
                OID = ".1.3.6.1.4.1.641.1.1.12.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify job information for one printer port.  Each entry corresponds to a value lexhdwrPortTableIndex."
            },
            new MibEntry
            {
                Name = "opsysCurrentJobString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysCurrentJobTable.opsysCurrentJobEntry.opsysCurrentJobString",
                OID = ".1.3.6.1.4.1.641.1.1.12.1.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual description of the this printer port's currently printing job containing the Source NOS, Source server, Source user, Job number, and Job size, separated by CR LF. A NULL string indicates no active job."
            },
            new MibEntry
            {
                Name = "opsysDeviceType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysDeviceType",
                OID = ".1.3.6.1.4.1.641.1.1.13",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A two byte code representing the adapter's type."
            },
            new MibEntry
            {
                Name = "opsysAdapterName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysAdapterName",
                OID = ".1.3.6.1.4.1.641.1.1.14",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A Unicode representation of the adapter's name."
            },
            new MibEntry
            {
                Name = "opsysAdapterCapabilities",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.opsys.opsysAdapterCapabilities",
                OID = ".1.3.6.1.4.1.641.1.1.15",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A bitmap representing the capabilities of the adapter. Bit  Value       Frame type --------------------------------------- 31   0x80000000  NPANT via Netware and IP 30   0x40000000  Receive-only Fax 29   0x20000000  reserved 28   0x10000000  Adapter HTTP 27   0x08000000  Printer HTTP 26   0x04000000  HTTP Configuration Page 25   0x02000000  Copier Option"
            },
            new MibEntry
            {
                Name = "lexlink",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexlink",
                OID = ".1.3.6.1.4.1.641.1.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexlinkActivated",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexlink.lexlinkActivated",
                OID = ".1.3.6.1.4.1.641.1.2.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The activation status of the LexLink protocol.  If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lexlinkNickname",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexlink.lexlinkNickname",
                OID = ".1.3.6.1.4.1.641.1.2.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The nickname assigned to the adapter for the LexLink protocol. Note that some adapters may not support the maximum length."
            },
            new MibEntry
            {
                Name = "lexipx",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx",
                OID = ".1.3.6.1.4.1.641.1.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexipxActivated",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxActivated",
                OID = ".1.3.6.1.4.1.641.1.3.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The activation status of the Netware protocol.  If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lexipxLoginName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxLoginName",
                OID = ".1.3.6.1.4.1.641.1.3.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The adapter's Netware login name.  If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lexipxNetNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxNetNumber",
                OID = ".1.3.6.1.4.1.641.1.3.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The network number of the Netware network to which the adapter is connected."
            },
            new MibEntry
            {
                Name = "lexipxSAPMode",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxSAPMode",
                OID = ".1.3.6.1.4.1.641.1.3.4",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The network adapter's current Netware SAP'ing status."
            },
            new MibEntry
            {
                Name = "lexipxServerMode",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxServerMode",
                OID = ".1.3.6.1.4.1.641.1.3.5",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The current Netware server mode of the adapter.  If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lexipxNumPorts",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxNumPorts",
                OID = ".1.3.6.1.4.1.641.1.3.6",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of Netware printer ports."
            },
            new MibEntry
            {
                Name = "lexipxPortInfoTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPortInfoTable",
                OID = ".1.3.6.1.4.1.641.1.3.7",
                Type = "SEQUENCE OF LexipxPortInfoEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of Netware printer port information."
            },
            new MibEntry
            {
                Name = "lexipxPortInfoEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPortInfoTable.lexipxPortInfoEntry",
                OID = ".1.3.6.1.4.1.641.1.3.7.1",
                Type = "LexipxPortInfoEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing Netware printer port information."
            },
            new MibEntry
            {
                Name = "lexipxPortInfoIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPortInfoTable.lexipxPortInfoEntry.lexipxPortInfoIndex",
                OID = ".1.3.6.1.4.1.641.1.3.7.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify Netware printer ports."
            },
            new MibEntry
            {
                Name = "lexipxPortInfoPollIntvl",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPortInfoTable.lexipxPortInfoEntry.lexipxPortInfoPollIntvl",
                OID = ".1.3.6.1.4.1.641.1.3.7.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The Netware queue polling interval for this printer port."
            },
            new MibEntry
            {
                Name = "lexipxPortInfoEnable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPortInfoTable.lexipxPortInfoEntry.lexipxPortInfoEnable",
                OID = ".1.3.6.1.4.1.641.1.3.7.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The Netware queue status of this printer port."
            },
            new MibEntry
            {
                Name = "lexipxPortInfoBannerPage",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPortInfoTable.lexipxPortInfoEntry.lexipxPortInfoBannerPage",
                OID = ".1.3.6.1.4.1.641.1.3.7.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The Netware queue banner page status for this printer port."
            },
            new MibEntry
            {
                Name = "lexipxNumPrefServers",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxNumPrefServers",
                OID = ".1.3.6.1.4.1.641.1.3.8",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The maximum number of preferred Netware servers supported by this network adapter."
            },
            new MibEntry
            {
                Name = "lexipxPrefSrvrTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPrefSrvrTable",
                OID = ".1.3.6.1.4.1.641.1.3.9",
                Type = "SEQUENCE OF LexipxPrefSrvrEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of the network adapter's preferred Netware servers."
            },
            new MibEntry
            {
                Name = "lexipxPrefSrvrEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPrefSrvrTable.lexipxPrefSrvrEntry",
                OID = ".1.3.6.1.4.1.641.1.3.9.1",
                Type = "LexipxPrefSrvrEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing preferred Netware server information."
            },
            new MibEntry
            {
                Name = "lexipxPrefSrvrIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPrefSrvrTable.lexipxPrefSrvrEntry.lexipxPrefSrvrIndex",
                OID = ".1.3.6.1.4.1.641.1.3.9.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify preferred Netware servers."
            },
            new MibEntry
            {
                Name = "lexipxPrefSrvrName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxPrefSrvrTable.lexipxPrefSrvrEntry.lexipxPrefSrvrName",
                OID = ".1.3.6.1.4.1.641.1.3.9.1.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The name of this preferred Netware server. If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable",
                OID = ".1.3.6.1.4.1.641.1.3.10",
                Type = "SEQUENCE OF LexipxConnSrvrEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of connected Netware server information."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry",
                OID = ".1.3.6.1.4.1.641.1.3.10.1",
                Type = "LexipxConnSrvrEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing connected Netware server information."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry.lexipxConnSrvrIndex",
                OID = ".1.3.6.1.4.1.641.1.3.10.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify connected Netware servers."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry.lexipxConnSrvrName",
                OID = ".1.3.6.1.4.1.641.1.3.10.1.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The name of this connected Netware server."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrNet",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry.lexipxConnSrvrNet",
                OID = ".1.3.6.1.4.1.641.1.3.10.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The Netware network number of this connected Netware server."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrNode",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry.lexipxConnSrvrNode",
                OID = ".1.3.6.1.4.1.641.1.3.10.1.4",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The Netware node address of the connected Netware server."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrConnNum",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry.lexipxConnSrvrConnNum",
                OID = ".1.3.6.1.4.1.641.1.3.10.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The connection number of the connected Netware server (pserver mode only)."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrConnId",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry.lexipxConnSrvrConnId",
                OID = ".1.3.6.1.4.1.641.1.3.10.1.6",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The connection ID of the connected Netware server (rprinter mode only)."
            },
            new MibEntry
            {
                Name = "lexipxConnSrvrPSConnID",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxConnSrvrTable.lexipxConnSrvrEntry.lexipxConnSrvrPSConnID",
                OID = ".1.3.6.1.4.1.641.1.3.10.1.7",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The connection ID of the connected Netware pserver (rprinter mode only)."
            },
            new MibEntry
            {
                Name = "lexipxFrameType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxFrameType",
                OID = ".1.3.6.1.4.1.641.1.3.11",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A bitmap of the supported IPX frame types. Bit  Value  Frame type ---------------------------------- 0    1      Token-Ring 1    2      Token-Ring Source Routed 2    4      Token-Ring SNAP 3    8      Token-Ring SNAP Source Routed 4    16     Ethernet 802.2 5    32     Ethernet 802.3 6    64     Ethernet Type 2 7    128    Ethernet SNAP"
            },
            new MibEntry
            {
                Name = "lexipxTrapTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxTrapTable",
                OID = ".1.3.6.1.4.1.641.1.3.12",
                Type = "SEQUENCE OF LexipxTrapEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of IPX trap destination configurations."
            },
            new MibEntry
            {
                Name = "lexipxTrapEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxTrapTable.lexipxTrapEntry",
                OID = ".1.3.6.1.4.1.641.1.3.12.1",
                Type = "LexipxTrapEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing an IPX trap destination's configuration."
            },
            new MibEntry
            {
                Name = "lexipxTrapIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxTrapTable.lexipxTrapEntry.lexipxTrapIndex",
                OID = ".1.3.6.1.4.1.641.1.3.12.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify IPX trap destinations."
            },
            new MibEntry
            {
                Name = "lexipxTrapMask",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxTrapTable.lexipxTrapEntry.lexipxTrapMask",
                OID = ".1.3.6.1.4.1.641.1.3.12.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The trap mask for the trap destination.  It is implemented as a bitmap specifying a mask of intervention required conditions for which the adapter should send trap messages.  Setting a bit to 1 enables the corresponding trap.  A value of 511 will cause the adapter to send traps for all intervention required conditions. The bitmap is defined below: Bit  Value  Condition ---------------------------------- 0    1      Output hopper full 1    2      Load Paper 2    4      Paper Jam 3    8      Toner Low 4    16     Service Required 5    32     Disk Error 6    64     Cover Opened 7    128    Page Complexity Error 8    256    Offline"
            },
            new MibEntry
            {
                Name = "lexipxTrapNetworkAddress",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxTrapTable.lexipxTrapEntry.lexipxTrapNetworkAddress",
                OID = ".1.3.6.1.4.1.641.1.3.12.1.3",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The IPX network address of the trap destination. (4 bytes)"
            },
            new MibEntry
            {
                Name = "lexipxTrapNodeAddress",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxTrapTable.lexipxTrapEntry.lexipxTrapNodeAddress",
                OID = ".1.3.6.1.4.1.641.1.3.12.1.4",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The IPX node address of the trap destination. (6 bytes)"
            },
            new MibEntry
            {
                Name = "lexipxTrapType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxTrapType",
                OID = ".1.3.6.1.4.1.641.1.3.13",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The type of SNMP over IPX traps that will be sent by the adapter. Setting this variable to multiplexed(1) configures all intervention required conditions to send an irCondition trap (specific trap number 1) and for the clearing of intervention required conditions to send an irCleared trap (specific trap number 0). Setting this variable to individual(2) causes each intervention required condition to send its corresponding trap (specific traps numbered 2 through 10) and for the clearing of intervention required conditions to cause an irClearedTypeII trap (specific trap number 11). See the Trap Definitions Group for more information. Individual(2) is the default for IPX and is necessary for NMS annotations."
            },
            new MibEntry
            {
                Name = "lexipxGSQ",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexipx.lexipxGSQ",
                OID = ".1.3.6.1.4.1.641.1.3.14",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The General Service Query (GSQ) interval.  This is the period in seconds that the adapter waits after a failed GSQ before attempting another as it searches for Netware servers."
            },
            new MibEntry
            {
                Name = "lextalk",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextalk",
                OID = ".1.3.6.1.4.1.641.1.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lextalkActivated",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextalk.lextalkActivated",
                OID = ".1.3.6.1.4.1.641.1.4.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The activation status of the AppleTalk protocol. If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lextalkAddress",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextalk.lextalkAddress",
                OID = ".1.3.6.1.4.1.641.1.4.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The AppleTalk Address of the network card. This variable is not implemented on the XLe adapters."
            },
            new MibEntry
            {
                Name = "lextalkName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextalk.lextalkName",
                OID = ".1.3.6.1.4.1.641.1.4.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The AppleTalk name of this adapter. This variable is not implemented on the XLe adapters."
            },
            new MibEntry
            {
                Name = "lextalkZone",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextalk.lextalkZone",
                OID = ".1.3.6.1.4.1.641.1.4.4",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The AppleTalk zone name of this adapter. This variable is not implemented on the XLe adapters."
            },
            new MibEntry
            {
                Name = "lextalkType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextalk.lextalkType",
                OID = ".1.3.6.1.4.1.641.1.4.5",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The AppleTalk type of this adapter. This variable is not implemented on the XLe adapters."
            },
            new MibEntry
            {
                Name = "lextcp",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp",
                OID = ".1.3.6.1.4.1.641.1.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexhttp",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp",
                OID = ".1.3.6.1.4.1.641.1.5.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexhttpEnable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpEnable",
                OID = ".1.3.6.1.4.1.641.1.5.6.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The status of whether the adapter will enable the HTTP server. If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lexhttpNumLinks",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpNumLinks",
                OID = ".1.3.6.1.4.1.641.1.5.6.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of configurable HTTP links for the adapter."
            },
            new MibEntry
            {
                Name = "lexhttpBytesRemaining",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpBytesRemaining",
                OID = ".1.3.6.1.4.1.641.1.5.6.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of bytes available to store HTTP link and label information."
            },
            new MibEntry
            {
                Name = "lexhttpResetLinks",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpResetLinks",
                OID = ".1.3.6.1.4.1.641.1.5.6.4",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A control for restoring default values for HTTP link settings. Setting the variable to reset will cause all of the HTTP link settings to be reset to their default values."
            },
            new MibEntry
            {
                Name = "lexhttpLinkTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpLinkTable",
                OID = ".1.3.6.1.4.1.641.1.5.6.5",
                Type = "SEQUENCE OF LexhttpLinkTableEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of HTTP Link settings."
            },
            new MibEntry
            {
                Name = "lexhttpLinkTableEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpLinkTable.lexhttpLinkTableEntry",
                OID = ".1.3.6.1.4.1.641.1.5.6.5.1",
                Type = "LexhttpLinkTableEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing HTTP link settings."
            },
            new MibEntry
            {
                Name = "lexhttpLinkTableIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpLinkTable.lexhttpLinkTableEntry.lexhttpLinkTableIndex",
                OID = ".1.3.6.1.4.1.641.1.5.6.5.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify HTTP link settings."
            },
            new MibEntry
            {
                Name = "lexhttpLinkTableStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpLinkTable.lexhttpLinkTableEntry.lexhttpLinkTableStatus",
                OID = ".1.3.6.1.4.1.641.1.5.6.5.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The status of the HTTP link. Get operation: linkOff       -- Server will not display the link personalOn    -- Server will display the custom link useDefault    -- Write-only defaultOff    -- Reserved defaultOn     -- Server will display the default link eraseCustom   -- Write-only Set operation: linkOff       -- Puts the link in linkOff status customOn      -- Puts the link in customOn status useDefault    -- Clears the Label and URL for this link and puts the .                link in defaultOn status defaultOff    -- Read-only defaultOn     -- Read-only eraseCustom   -- Clears the Label and URL for this link and puts the .                link in linkOff status"
            },
            new MibEntry
            {
                Name = "lexhttpLinkTableLabel",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpLinkTable.lexhttpLinkTableEntry.lexhttpLinkTableLabel",
                OID = ".1.3.6.1.4.1.641.1.5.6.5.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The text to be displayed as the label of this HTTP link.  It may be set to define a custom link.  Note that when read, this always reflects what the server would display.  As such, if the status of this link is defaultOn, it will not return your custom label if read even though it has been stored.  Setting the status for this link to customOn will activate your custom link label.  Remember that setting the status of this link to eraseCustom or useDefault clears this variable."
            },
            new MibEntry
            {
                Name = "lexhttpLinkTableURL",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpLinkTable.lexhttpLinkTableEntry.lexhttpLinkTableURL",
                OID = ".1.3.6.1.4.1.641.1.5.6.5.1.4",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The URL to be hyperlinked to by the HTTP link.  It may be set to define a custom link.  Note that when read, this always reflects what the server would use.  As such, if the status of this link is defaultOn, it will not return your custom URL if read even though it has been stored.  Setting the status for this link to customOn will activate your custom link URL.  Remember that setting the status of this link to eraseCustom or useDefault clears this variable."
            },
            new MibEntry
            {
                Name = "lexhttpConfigEnable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexhttp.lexhttpConfigEnable",
                OID = ".1.3.6.1.4.1.641.1.5.6.6",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The status of whether HTTP configuration page is enabled."
            },
            new MibEntry
            {
                Name = "lexdhcp",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp",
                OID = ".1.3.6.1.4.1.641.1.5.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexdhcpDhcpEnable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpDhcpEnable",
                OID = ".1.3.6.1.4.1.641.1.5.7.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The status of whether DHCP is enabled."
            },
            new MibEntry
            {
                Name = "lexdhcpRarpEnable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpRarpEnable",
                OID = ".1.3.6.1.4.1.641.1.5.7.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The status of whether RARP is enabled."
            },
            new MibEntry
            {
                Name = "lexdhcpAddressSource",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpAddressSource",
                OID = ".1.3.6.1.4.1.641.1.5.7.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The method by which the current IP parameters were obtained."
            },
            new MibEntry
            {
                Name = "lexdhcpWinsStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpWinsStatus",
                OID = ".1.3.6.1.4.1.641.1.5.7.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The adapter's WINS server registration status."
            },
            new MibEntry
            {
                Name = "lexdhcpWinsServer",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpWinsServer",
                OID = ".1.3.6.1.4.1.641.1.5.7.5",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The IP address of the WINS server."
            },
            new MibEntry
            {
                Name = "lexdhcpHostname",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpHostname",
                OID = ".1.3.6.1.4.1.641.1.5.7.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The adapter's TCP/IP hostname. Setting 63 chars for OEM - MS310dn, 510dn, 610dn but other Lexmark Printers still max of 15 characters"
            },
            new MibEntry
            {
                Name = "lexdhcpLeaseLength",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpLeaseLength",
                OID = ".1.3.6.1.4.1.641.1.5.7.7",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The length of the adapter's DHCP address lease in seconds."
            },
            new MibEntry
            {
                Name = "lexdhcpTimetoExpire",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpTimetoExpire",
                OID = ".1.3.6.1.4.1.641.1.5.7.8",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of seconds until the DHCP address lease expires."
            },
            new MibEntry
            {
                Name = "lexdhcpDNSServer",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lexdhcp.lexdhcpDNSServer",
                OID = ".1.3.6.1.4.1.641.1.5.7.9",
                Type = "IPADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The IP address of the DNS server."
            },
            new MibEntry
            {
                Name = "lextcpActivated",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpActivated",
                OID = ".1.3.6.1.4.1.641.1.5.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The activation status of the TCP/IP Protocol. If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lextcpBootpEnable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpBootpEnable",
                OID = ".1.3.6.1.4.1.641.1.5.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The status of whether or not BOOTP is attempted to determine the IP parameters. If this variable is changed, the adapter must be reset before the change will take effect.  See opsysTimeToReset."
            },
            new MibEntry
            {
                Name = "lextcpAddressServ",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpAddressServ",
                OID = ".1.3.6.1.4.1.641.1.5.3",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The IP address of the DHCP, BOOTP, or RARP server that provided the adapter's IP address."
            },
            new MibEntry
            {
                Name = "lextcpNumNPAPservers",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpNumNPAPservers",
                OID = ".1.3.6.1.4.1.641.1.5.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The maximum number of concurrent NPAP over TCP server connections."
            },
            new MibEntry
            {
                Name = "lextcpNPAPserversTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpNPAPserversTable",
                OID = ".1.3.6.1.4.1.641.1.5.5",
                Type = "SEQUENCE OF LextcpNPAPserversEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of NPAP over TCP server information."
            },
            new MibEntry
            {
                Name = "lextcpNPAPserversEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpNPAPserversTable.lextcpNPAPserversEntry",
                OID = ".1.3.6.1.4.1.641.1.5.5.1",
                Type = "LextcpNPAPserversEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing NPAP over TCP server information."
            },
            new MibEntry
            {
                Name = "lextcpNPAPserverIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpNPAPserversTable.lextcpNPAPserversEntry.lextcpNPAPserverIndex",
                OID = ".1.3.6.1.4.1.641.1.5.5.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify NPAP over TCP servers."
            },
            new MibEntry
            {
                Name = "lextcpNPAPserverAddress",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextcp.lextcpNPAPserversTable.lextcpNPAPserversEntry.lextcpNPAPserverAddress",
                OID = ".1.3.6.1.4.1.641.1.5.5.1.2",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The IP address of this NPAP over TCP server."
            },
            new MibEntry
            {
                Name = "lexhdwr",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr",
                OID = ".1.3.6.1.4.1.641.1.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexhdwrNumPorts",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrNumPorts",
                OID = ".1.3.6.1.4.1.641.1.6.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of printer ports supported by this network adapter."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable",
                OID = ".1.3.6.1.4.1.641.1.6.2",
                Type = "SEQUENCE OF LexhdwrPortTableEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of the adapter's printer port hardware settings."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry",
                OID = ".1.3.6.1.4.1.641.1.6.2.1",
                Type = "LexhdwrPortTableEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing printer port hardware settings."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableIndex",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify printer ports."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableType",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The type of attachment for this printer port."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm1",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm1",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For serial and parallel ports, this is the port timeout in seconds. For internal ports, this parameter is unused."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm2",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm2",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For serial ports, this is the baud rate in bits per second. For parallel ports, this is the port mode and is defined as follows: standard(0), enhanced(1) For internal ports, this parameter is unused."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm3",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm3",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For serial ports, this is the parity and is defined as follows: none(0), odd(1), even(2), space(3), mark(4) For parallel and internal ports, this parameter is unused."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm4",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm4",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.6",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For serial ports, this is the number of data bits. For parallel and internal ports, this parameter is unused."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm5",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm5",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.7",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For serial ports, this is the number of stop bits and is defined as follows: bitsOne(2), bitsOneAndHalf(3), bitsTwo(4) For parallel and internal ports, this parameter is unused."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm6",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm6",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.8",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For serial ports, this is the pacing mode and is defined as follows: paceDtr(0), paceXonXff(1) For non XLe parallel ports, this is the parallel protocol and is defined as follows: auto(2), ecp(3), byte(4), nibble(5), compatible(6) For internal ports, and XLe parallel ports this parameter is unused."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm7",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm7",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.9",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For all ports, this is the configured NPAP mode. For internal ports this is a read-only variable."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm8",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm8",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.10",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For all ports, this is the NPAP status. For internal ports this is a read-only variable."
            },
            new MibEntry
            {
                Name = "lexhdwrPortTableParm9",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexhdwr.lexhdwrPortTable.lexhdwrPortTableEntry.lexhdwrPortTableParm9",
                OID = ".1.3.6.1.4.1.641.1.6.2.1.11",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"For serial ports, this is the class of device attached. This variable is unused on the XLe adapters."
            },
            new MibEntry
            {
                Name = "lexmac",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexmac",
                OID = ".1.3.6.1.4.1.641.1.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lexmacType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexmac.lexmacType",
                OID = ".1.3.6.1.4.1.641.1.7.1",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of network medium to which the network adapter is attached (e.g. Ethernet)."
            },
            new MibEntry
            {
                Name = "lexmacSpeed",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexmac.lexmacSpeed",
                OID = ".1.3.6.1.4.1.641.1.7.2",
                Type = "GAUGE",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The speed, in bits per second, of the network medium to which the network adapter is attached."
            },
            new MibEntry
            {
                Name = "lexmacConnType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexmac.lexmacConnType",
                OID = ".1.3.6.1.4.1.641.1.7.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The connection type by which the network adapter is connected to the network medium."
            },
            new MibEntry
            {
                Name = "lexmacUAA",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexmac.lexmacUAA",
                OID = ".1.3.6.1.4.1.641.1.7.4",
                Type = "PHYSADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The network adapter's universally administered network address."
            },
            new MibEntry
            {
                Name = "lexmacLAA",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lexmac.lexmacLAA",
                OID = ".1.3.6.1.4.1.641.1.7.5",
                Type = "PHYSADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The network adapter's locally administered network address.  A value of all zeros indicates that the LAA is not in use."
            },
            new MibEntry
            {
                Name = "lextrap",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap",
                OID = ".1.3.6.1.4.1.641.1.8",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "lextrapDestNum",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap.lextrapDestNum",
                OID = ".1.3.6.1.4.1.641.1.8.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The maximum number of IP trap destinations supported by this network adapter."
            },
            new MibEntry
            {
                Name = "lextrapDestTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap.lextrapDestTable",
                OID = ".1.3.6.1.4.1.641.1.8.2",
                Type = "SEQUENCE OF LextrapDestEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of IP trap destination configurations."
            },
            new MibEntry
            {
                Name = "lextrapDestEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap.lextrapDestTable.lextrapDestEntry",
                OID = ".1.3.6.1.4.1.641.1.8.2.1",
                Type = "LextrapDestEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing an IP trap destination configuration."
            },
            new MibEntry
            {
                Name = "lextrapDestIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap.lextrapDestTable.lextrapDestEntry.lextrapDestIndex",
                OID = ".1.3.6.1.4.1.641.1.8.2.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify IP trap destinations."
            },
            new MibEntry
            {
                Name = "lextrapDestIPAddr",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap.lextrapDestTable.lextrapDestEntry.lextrapDestIPAddr",
                OID = ".1.3.6.1.4.1.641.1.8.2.1.2",
                Type = "IPADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The IP address of the trap destination."
            },
            new MibEntry
            {
                Name = "lextrapDestMask",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap.lextrapDestTable.lextrapDestEntry.lextrapDestMask",
                OID = ".1.3.6.1.4.1.641.1.8.2.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The trap mask for the trap destination.  It is implemented as a bitmap specifying a mask of intervention required conditions for which the adapter should send trap messages.  Setting a bit to 1 enables the corresponding trap.  A value of 1023 will cause the adapter to send traps for all intervention required conditions. The bitmap is defined below: Bit  Value  Condition ---------------------------------- 0    1      Output hopper full 1    2      Load Paper 2    4      Paper Jam 3    8      Toner Low 4    16     Service Required 5    32     Disk Error 6    64     Cover Opened 7    128    Page Complexity Error 8    256    Offline 9    512    Printer MIB (RFC 1759)"
            },
            new MibEntry
            {
                Name = "lextrapIPTrapType",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.lextrap.lextrapIPTrapType",
                OID = ".1.3.6.1.4.1.641.1.8.3",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The type of SNMP over IP traps that will be sent by the adapter. Setting this variable to multiplexed(1) configures all intervention required conditions to send an irCondition trap (specific trap number 1) and for the clearing of intervention required conditions to send an irCleared trap (specific trap number 0). Setting this variable to individual(2) causes each intervention required condition to send its corresponding trap (specific traps numbered 2 through 10) and for the clearing of intervention required conditions to cause an irClearedTypeII trap (specific trap number 11). See the Trap Definitions Group for more information. Type 1 is the default for IP."
            },
            new MibEntry
            {
                Name = "time",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time",
                OID = ".1.3.6.1.4.1.641.1.9",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "timeReset",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeReset",
                OID = ".1.3.6.1.4.1.641.1.9.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A control for initiating an update of the system time and date using the specified timeSource.  Setting the variable to reset will cause the system to update it's time and date using the specified time source. See timeSource."
            },
            new MibEntry
            {
                Name = "timeSource",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeSource",
                OID = ".1.3.6.1.4.1.641.1.9.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The source for setting the system time and date.  If this variable is changed, the time must be reset before the change will have an effect. See timeReset."
            },
            new MibEntry
            {
                Name = "timeUTCOffset",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeUTCOffset",
                OID = ".1.3.6.1.4.1.641.1.9.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The offset in minutes from UTC (formerly GMT) of local time.  Use a negative value if West of UTC.  Use a positive value if East of UTC."
            },
            new MibEntry
            {
                Name = "timeDSTEnable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeDSTEnable",
                OID = ".1.3.6.1.4.1.641.1.9.4",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The status of whether automatic Daylight Savings Time adjust is enabled. See timeDSTStartDate, timeDSTEndDate, and timeDSTOffset for configuration options."
            },
            new MibEntry
            {
                Name = "timeDSTStartDate",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeDSTStartDate",
                OID = ".1.3.6.1.4.1.641.1.9.5",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of the day and time the Daylight Savings Time adjust should start if enabled (see timeDSTEnable).  The format of string is as follows: Byte Meaning ---------------------------------------------------------------- 0    Which occurence in the month of the day specified in byte 1. Valid values are: F => First Occurence 1 => First Occurence 2 => Second Occurence 3 => Third Occurence 4 => Fourth Occurence 5 => Fifth Occurence L => Last Occurence 1    A 1-digit field indicating the day of week (0=Sun..6=Sat) 2-3  A 2-digit field indicating the month. 4-5  A 2-digit field indicating the hour 6-7  A 2-digit field indicating the minute 8-9  A 2-digit field indicating the second The default setting is F004020000 which corresponds to the first Sunday of April at 2:00:00 am."
            },
            new MibEntry
            {
                Name = "timeDSTEndDate",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeDSTEndDate",
                OID = ".1.3.6.1.4.1.641.1.9.6",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of the day and time the Daylight Savings Time adjust should end if enabled (see timeDSTEnable).  The format of string is as defined for timeDSTStartDate The default setting is L010020000 which corresponds to the last Sunday of October at 2:00:00 am."
            },
            new MibEntry
            {
                Name = "timeDSTOffset",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeDSTOffset",
                OID = ".1.3.6.1.4.1.641.1.9.7",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The offset in minutes that should be applied to local time during Daylight Savings Time."
            },
            new MibEntry
            {
                Name = "timeServerAddress",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeServerAddress",
                OID = ".1.3.6.1.4.1.641.1.9.8",
                Type = "IPADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"If the specified time source is NTP (see timeSource), this is the IP address of the NTP server to use.  Otherwise, the value is ignored."
            },
            new MibEntry
            {
                Name = "timeServerName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.adapter.time.timeServerName",
                OID = ".1.3.6.1.4.1.641.1.9.9",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"If the specified time source is NTP (see timeSource), and the NTP server address is not set (0.0.0.0), this is the DNS domainname of the NTP server. If the specified time source is Netware (see timeSource), the is the name of Netware server.  Otherwise, the value is ignored."
            },
            new MibEntry
            {
                Name = "printer",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer",
                OID = ".1.3.6.1.4.1.641.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "prtgen",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen",
                OID = ".1.3.6.1.4.1.641.2.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "pgcount",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.pgcount",
                OID = ".1.3.6.1.4.1.641.2.1.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "pgTotal",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.pgcount.pgTotal",
                OID = ".1.3.6.1.4.1.641.2.1.5.1",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The total number of pages printed."
            },
            new MibEntry
            {
                Name = "pgMono",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.pgcount.pgMono",
                OID = ".1.3.6.1.4.1.641.2.1.5.2",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of monochrome pages printed."
            },
            new MibEntry
            {
                Name = "pgColor",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.pgcount.pgColor",
                OID = ".1.3.6.1.4.1.641.2.1.5.3",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of color pages printed."
            },
            new MibEntry
            {
                Name = "prtgenNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenNumber",
                OID = ".1.3.6.1.4.1.641.2.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of printers, regardless of their current state, available to this adapter."
            },
            new MibEntry
            {
                Name = "prtgenInfoTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable",
                OID = ".1.3.6.1.4.1.641.2.1.2",
                Type = "SEQUENCE OF PrtgenInfoEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of the network adapter's attached printer information."
            },
            new MibEntry
            {
                Name = "prtgenInfoEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry",
                OID = ".1.3.6.1.4.1.641.2.1.2.1",
                Type = "PrtgenInfoEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing attached printer information."
            },
            new MibEntry
            {
                Name = "prtgenPrinterIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry.prtgenPrinterIndex",
                OID = ".1.3.6.1.4.1.641.2.1.2.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the network adapter to identify attached printers."
            },
            new MibEntry
            {
                Name = "prtgenPrinterName",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry.prtgenPrinterName",
                OID = ".1.3.6.1.4.1.641.2.1.2.1.2",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual description of the make and model of the attached printer, if known."
            },
            new MibEntry
            {
                Name = "prtgenPeripheralID",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry.prtgenPeripheralID",
                OID = ".1.3.6.1.4.1.641.2.1.2.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual description of the peripheral ID of the attached printer as defined by the IEEE 1284 standard, if known."
            },
            new MibEntry
            {
                Name = "prtgenCodeRevision",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry.prtgenCodeRevision",
                OID = ".1.3.6.1.4.1.641.2.1.2.1.4",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of the code revision level of the attached printer, if known."
            },
            new MibEntry
            {
                Name = "prtgenResValue",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry.prtgenResValue",
                OID = ".1.3.6.1.4.1.641.2.1.2.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"This object is currently unused and reserved."
            },
            new MibEntry
            {
                Name = "prtgenSerialNo",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry.prtgenSerialNo",
                OID = ".1.3.6.1.4.1.641.2.1.2.1.6",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of the serial number of the attached printer, if known."
            },
            new MibEntry
            {
                Name = "prtgenAssetTag",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenInfoTable.prtgenInfoEntry.prtgenAssetTag",
                OID = ".1.3.6.1.4.1.641.2.1.2.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A textual representation of the asset tag of the printer, if known."
            },
            new MibEntry
            {
                Name = "prtgenStatusTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable",
                OID = ".1.3.6.1.4.1.641.2.1.3",
                Type = "SEQUENCE OF PrtgenStatusEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of the network adapter's attached printer status."
            },
            new MibEntry
            {
                Name = "prtgenStatusEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry",
                OID = ".1.3.6.1.4.1.641.2.1.3.1",
                Type = "PrtgenStatusEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing attached printer status."
            },
            new MibEntry
            {
                Name = "prtgenStatPrinterIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatPrinterIndex",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the network adapter to identify attached printers."
            },
            new MibEntry
            {
                Name = "prtgenStatusIRC",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusIRC",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current intervention required code."
            },
            new MibEntry
            {
                Name = "prtgenStatusOutHopFull",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusOutHopFull",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current output hopper status."
            },
            new MibEntry
            {
                Name = "prtgenStatusInputEmpty",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusInputEmpty",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current active input paper tray status."
            },
            new MibEntry
            {
                Name = "prtgenStatusPaperJam",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusPaperJam",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current paper path status."
            },
            new MibEntry
            {
                Name = "prtgenStatusTonerError",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusTonerError",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.6",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current toner supply status."
            },
            new MibEntry
            {
                Name = "prtgenStatusSrvcReqd",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusSrvcReqd",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.7",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current service required status."
            },
            new MibEntry
            {
                Name = "prtgenStatusDiskError",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusDiskError",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.8",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current disk sub-system status."
            },
            new MibEntry
            {
                Name = "prtgenStatusCoverOpen",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusCoverOpen",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.9",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current cover status."
            },
            new MibEntry
            {
                Name = "prtgenStatusPageComplex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusPageComplex",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.10",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current complex page status."
            },
            new MibEntry
            {
                Name = "prtgenStatusLineStatus",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusLineStatus",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.11",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current online/offline status."
            },
            new MibEntry
            {
                Name = "prtgenStatusBusy",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusBusy",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.12",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current bust status."
            },
            new MibEntry
            {
                Name = "prtgenStatusWaiting",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusWaiting",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.13",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current waiting status."
            },
            new MibEntry
            {
                Name = "prtgenStatusWarming",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusWarming",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.14",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current warming status."
            },
            new MibEntry
            {
                Name = "prtgenStatusPrinting",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenStatusTable.prtgenStatusEntry.prtgenStatusPrinting",
                OID = ".1.3.6.1.4.1.641.2.1.3.1.15",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's current printing status."
            },
            new MibEntry
            {
                Name = "prtgenFamilyID",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.printer.prtgen.prtgenFamilyID",
                OID = ".1.3.6.1.4.1.641.2.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The printer's NPA family ID."
            },
            new MibEntry
            {
                Name = "attachment",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment",
                OID = ".1.3.6.1.4.1.641.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "fax",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax",
                OID = ".1.3.6.1.4.1.641.3.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "faxNumber",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxNumber",
                OID = ".1.3.6.1.4.1.641.3.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of fax modems attached to the adapter."
            },
            new MibEntry
            {
                Name = "faxTable",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable",
                OID = ".1.3.6.1.4.1.641.3.1.2",
                Type = "SEQUENCE OF FaxEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A table of the network adapter's attached fax modems configuration data."
            },
            new MibEntry
            {
                Name = "faxEntry",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry",
                OID = ".1.3.6.1.4.1.641.3.1.2.1",
                Type = "FaxEntry",
                Access = AccessType.Unknown,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"An entry containing attached fax modem configuration data."
            },
            new MibEntry
            {
                Name = "faxIndex",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxIndex",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A unique value used by the adapter to identify fax ports."
            },
            new MibEntry
            {
                Name = "faxPort",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxPort",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The network adapter's port to which this modem is attached."
            },
            new MibEntry
            {
                Name = "faxAdapterCapabilities",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxAdapterCapabilities",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A bitmap representing the fax capabilities of the network adapter. Bit  Value   Capabilities ----------------------------- 0    1       Fine Resolution 1    2       2D Encoding 2    4       T6 Encoding 3    8       ECM 4    16      Binary File Transfer 5    32      300 x 300 6    64      400 x 400 7    128     200 x 400 8    256     Uncompressed Mode 9    512     255mm Width 10   1024    303mm Width 11   2048    Legal Length 12   4096    Unlimited Length 13   8192    V.17 (14400) 14   16384   V.33 (14400) 15   32768   V.29 and V.27 (9600) 16   65536   V.29 (9600) 17   131072  V.27 (4800) 18   262144  V27 (2400)"
            },
            new MibEntry
            {
                Name = "faxModemCapabilities",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxModemCapabilities",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A bitmap representing the fax capabilities of the attached modem. Bit  Value   Capabilities ----------------------------- 0    1       Fine Resolution 1    2       2D Encoding 2    4       T6 Encoding 3    8       ECM 4    16      Binary File Transfer 5    32      300 x 300 6    64      400 x 400 7    128     200 x 400 8    256     Uncompressed Mode 9    512     255mm Width 10   1024    303mm Width 11   2048    Legal Length 12   4096    Unlimited Length 13   8192    V.17 (14400) 14   16384   V.33 (14400) 15   32768   V.29 and V.27 (9600) 16   65536   V.29 (9600) 17   131072  V.27 (4800) 18   262144  V27 (2400)"
            },
            new MibEntry
            {
                Name = "faxSelectedCapabilities",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxSelectedCapabilities",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A bitmap representing the user selected fax capabilities. Bit  Value   Capabilities ----------------------------- 0    1       Fine Resolution 1    2       2D Encoding 2    4       T6 Encoding 3    8       ECM 4    16      Binary File Transfer 5    32      300 x 300 6    64      400 x 400 7    128     200 x 400 8    256     Uncompressed Mode 9    512     255mm Width 10   1024    303mm Width 11   2048    Legal Length 12   4096    Unlimited Length 13   8192    V.17 (14400) 14   16384   V.33 (14400) 15   32768   V.29 and V.27 (9600) 16   65536   V.29 (9600) 17   131072  V.27 (4800) 18   262144  V27 (2400)"
            },
            new MibEntry
            {
                Name = "faxActiveCapabilities",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxActiveCapabilities",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.6",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"A bitmap representing the active fax capabilities.  This is the logical and of faxAdapterCapabilities, faxModemCapabilities, and faxSelectedCapabilities. Bit  Value   Capabilities ----------------------------- 0    1       Fine Resolution 1    2       2D Encoding 2    4       T6 Encoding 3    8       ECM 4    16      Binary File Transfer 5    32      300 x 300 6    64      400 x 400 7    128     200 x 400 8    256     Uncompressed Mode 9    512     255mm Width 10   1024    303mm Width 11   2048    Legal Length 12   4096    Unlimited Length 13   8192    V.17 (14400) 14   16384   V.33 (14400) 15   32768   V.29 and V.27 (9600) 16   65536   V.29 (9600) 17   131072  V.27 (4800) 18   262144  V27 (2400)"
            },
            new MibEntry
            {
                Name = "faxIDString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxIDString",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.7",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The textual identification that is used to identify this fax device. This text is sent to a connected fax device at the start of a call."
            },
            new MibEntry
            {
                Name = "faxInitString",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxInitString",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.8",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The commands used be the network adapter to initialize an attached modem."
            },
            new MibEntry
            {
                Name = "faxNumberRings",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxNumberRings",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.9",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The number of rings that the network adapter should wait before answering."
            },
            new MibEntry
            {
                Name = "faxScaling",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxScaling",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.10",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The mechanism used to resolve size descrepancies between the received fax the printer's available forms."
            },
            new MibEntry
            {
                Name = "faxBinaryEncoding",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxBinaryEncoding",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.11",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The encoding used when sending fax data to the attached printer."
            },
            new MibEntry
            {
                Name = "faxPrinterPort",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxPrinterPort",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.13",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The port (printer) to which received faxes should be printed."
            },
            new MibEntry
            {
                Name = "faxInputTray",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxInputTray",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.14",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The input tray from which received faxes should be printed. The value 255 indicates printer default."
            },
            new MibEntry
            {
                Name = "faxOutputBin",
                FullName = ".iso.org.dod.internet.private.enterprises.lexmark.attachment.fax.faxTable.faxEntry.faxOutputBin",
                OID = ".1.3.6.1.4.1.641.3.1.2.1.15",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "LEXMARK-PVT-MIB",
                Description = @"The output bin to which received faxes should be printed. The value 255 indicates printer default."
            },
            new MibEntry
            {
                Name = "mgmt",
                FullName = ".iso.org.dod.internet.mgmt",
                OID = ".1.3.6.1.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "SNMPv2-SMI",
                Description = @""
            },
            new MibEntry
            {
                Name = "mib-2",
                FullName = ".iso.org.dod.internet.mgmt.mib-2",
                OID = ".1.3.6.1.2.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "SNMPv2-SMI",
                Description = @""
            },
            new MibEntry
            {
                Name = "system",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system",
                OID = ".1.3.6.1.2.1.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "sysDescr",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system.sysDescr",
                OID = ".1.3.6.1.2.1.1.1",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"A textual description of the entity.  This value should include the full name and version identification of the system's hardware type, software operating-system, and networking software.  It is mandatory that this only contain printable ASCII characters."
            },
            new MibEntry
            {
                Name = "sysObjectID",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system.sysObjectID",
                OID = ".1.3.6.1.2.1.1.2",
                Type = "OBJECT IDENTIFIER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The vendor's authoritative identification of the network management subsystem contained in the entity.  This value is allocated within the SMI enterprises subtree (1.3.6.1.4.1) and provides an easy and unambiguous means for determining `what kind of box' is being managed.  For example, if vendor `Flintstones, Inc.' was assigned the subtree 1.3.6.1.4.1.4242, it could assign the identifier 1.3.6.1.4.1.4242.1.1 to its `Fred Router'."
            },
            new MibEntry
            {
                Name = "sysUpTime",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system.sysUpTime",
                OID = ".1.3.6.1.2.1.1.3",
                Type = "TIMETICKS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The time (in hundredths of a second) since the network management portion of the system was last re-initialized."
            },
            new MibEntry
            {
                Name = "sysContact",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system.sysContact",
                OID = ".1.3.6.1.2.1.1.4",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The textual identification of the contact person for this managed node, together with information on how to contact this person."
            },
            new MibEntry
            {
                Name = "sysName",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system.sysName",
                OID = ".1.3.6.1.2.1.1.5",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"An administratively-assigned name for this managed node.  By convention, this is the node's fully-qualified domain name."
            },
            new MibEntry
            {
                Name = "sysLocation",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system.sysLocation",
                OID = ".1.3.6.1.2.1.1.6",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The physical location of this node (e.g., `telephone closet, 3rd floor')."
            },
            new MibEntry
            {
                Name = "sysServices",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.system.sysServices",
                OID = ".1.3.6.1.2.1.1.7",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"A value which indicates the set of services that this entity primarily offers. The value is a sum.  This sum initially takes the value zero, Then, for each layer, L, in the range 1 through 7, that this node performs transactions for, 2 raised to (L - 1) is added to the sum.  For example, a node which performs primarily routing functions would have a value of 4 (2^(3-1)).  In contrast, a node which is a host offering application services would have a value of 72 (2^(4-1) + 2^(7-1)).  Note that in the context of the Internet suite of protocols, values should be calculated accordingly: layer  functionality 1  physical (e.g., repeaters) 2  datalink/subnetwork (e.g., bridges) 3  internet (e.g., IP gateways) 4  end-to-end  (e.g., IP hosts) 7  applications (e.g., mail relays) For systems including OSI protocols, layers 5 and 6 may also be counted."
            },
            new MibEntry
            {
                Name = "interfaces",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces",
                OID = ".1.3.6.1.2.1.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "ifNumber",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifNumber",
                OID = ".1.3.6.1.2.1.2.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of network interfaces (regardless of their current state) present on this system."
            },
            new MibEntry
            {
                Name = "ifTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable",
                OID = ".1.3.6.1.2.1.2.2",
                Type = "SEQUENCE OF IfEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"A list of interface entries.  The number of entries is given by the value of ifNumber."
            },
            new MibEntry
            {
                Name = "ifEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry",
                OID = ".1.3.6.1.2.1.2.2.1",
                Type = "IfEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"An interface entry containing objects at the subnetwork layer and below for a particular interface."
            },
            new MibEntry
            {
                Name = "ifIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifIndex",
                OID = ".1.3.6.1.2.1.2.2.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"A unique value for each interface.  Its value ranges between 1 and the value of ifNumber.  The value for each interface must remain constant at least from one re-initialization of the entity's network management system to the next re- initialization."
            },
            new MibEntry
            {
                Name = "ifDescr",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifDescr",
                OID = ".1.3.6.1.2.1.2.2.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"A textual string containing information about the interface.  This string should include the name of the manufacturer, the product name and the version of the hardware interface."
            },
            new MibEntry
            {
                Name = "ifType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifType",
                OID = ".1.3.6.1.2.1.2.2.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The type of interface, distinguished according to the physical/link protocol(s) immediately `below' the network layer in the protocol stack."
            },
            new MibEntry
            {
                Name = "ifMtu",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifMtu",
                OID = ".1.3.6.1.2.1.2.2.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The size of the largest datagram which can be sent/received on the interface, specified in octets.  For interfaces that are used for transmitting network datagrams, this is the size of the largest network datagram that can be sent on the interface."
            },
            new MibEntry
            {
                Name = "ifSpeed",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifSpeed",
                OID = ".1.3.6.1.2.1.2.2.1.5",
                Type = "GAUGE",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"An estimate of the interface's current bandwidth in bits per second.  For interfaces which do not vary in bandwidth or for those where no accurate estimation can be made, this object should contain the nominal bandwidth."
            },
            new MibEntry
            {
                Name = "ifPhysAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifPhysAddress",
                OID = ".1.3.6.1.2.1.2.2.1.6",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The interface's address at the protocol layer immediately `below' the network layer in the protocol stack.  For interfaces which do not have such an address (e.g., a serial line), this object should contain an octet string of zero length."
            },
            new MibEntry
            {
                Name = "ifAdminStatus",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifAdminStatus",
                OID = ".1.3.6.1.2.1.2.2.1.7",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The desired state of the interface.  The testing(3) state indicates that no operational packets can be passed."
            },
            new MibEntry
            {
                Name = "ifOperStatus",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifOperStatus",
                OID = ".1.3.6.1.2.1.2.2.1.8",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The current operational state of the interface. The testing(3) state indicates that no operational packets can be passed."
            },
            new MibEntry
            {
                Name = "ifLastChange",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifLastChange",
                OID = ".1.3.6.1.2.1.2.2.1.9",
                Type = "TIMETICKS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The value of sysUpTime at the time the interface entered its current operational state.  If the current state was entered prior to the last re- initialization of the local network management subsystem, then this object contains a zero value."
            },
            new MibEntry
            {
                Name = "ifInOctets",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifInOctets",
                OID = ".1.3.6.1.2.1.2.2.1.10",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of octets received on the interface, including framing characters."
            },
            new MibEntry
            {
                Name = "ifInUcastPkts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifInUcastPkts",
                OID = ".1.3.6.1.2.1.2.2.1.11",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of subnetwork-unicast packets delivered to a higher-layer protocol."
            },
            new MibEntry
            {
                Name = "ifInNUcastPkts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifInNUcastPkts",
                OID = ".1.3.6.1.2.1.2.2.1.12",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of non-unicast (i.e., subnetwork- broadcast or subnetwork-multicast) packets delivered to a higher-layer protocol."
            },
            new MibEntry
            {
                Name = "ifInDiscards",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifInDiscards",
                OID = ".1.3.6.1.2.1.2.2.1.13",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of inbound packets which were chosen to be discarded even though no errors had been detected to prevent their being deliverable to a higher-layer protocol.  One possible reason for discarding such a packet could be to free up buffer space."
            },
            new MibEntry
            {
                Name = "ifInErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifInErrors",
                OID = ".1.3.6.1.2.1.2.2.1.14",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of inbound packets that contained errors preventing them from being deliverable to a higher-layer protocol."
            },
            new MibEntry
            {
                Name = "ifInUnknownProtos",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifInUnknownProtos",
                OID = ".1.3.6.1.2.1.2.2.1.15",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of packets received via the interface which were discarded because of an unknown or unsupported protocol."
            },
            new MibEntry
            {
                Name = "ifOutOctets",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifOutOctets",
                OID = ".1.3.6.1.2.1.2.2.1.16",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of octets transmitted out of the interface, including framing characters."
            },
            new MibEntry
            {
                Name = "ifOutUcastPkts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifOutUcastPkts",
                OID = ".1.3.6.1.2.1.2.2.1.17",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of packets that higher-level protocols requested be transmitted to a subnetwork-unicast address, including those that were discarded or not sent."
            },
            new MibEntry
            {
                Name = "ifOutNUcastPkts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifOutNUcastPkts",
                OID = ".1.3.6.1.2.1.2.2.1.18",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of packets that higher-level protocols requested be transmitted to a non- unicast (i.e., a subnetwork-broadcast or subnetwork-multicast) address, including those that were discarded or not sent."
            },
            new MibEntry
            {
                Name = "ifOutDiscards",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifOutDiscards",
                OID = ".1.3.6.1.2.1.2.2.1.19",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of outbound packets which were chosen to be discarded even though no errors had been detected to prevent their being transmitted.  One possible reason for discarding such a packet could be to free up buffer space."
            },
            new MibEntry
            {
                Name = "ifOutErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifOutErrors",
                OID = ".1.3.6.1.2.1.2.2.1.20",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of outbound packets that could not be transmitted because of errors."
            },
            new MibEntry
            {
                Name = "ifOutQLen",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifOutQLen",
                OID = ".1.3.6.1.2.1.2.2.1.21",
                Type = "GAUGE",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The length of the output packet queue (in packets)."
            },
            new MibEntry
            {
                Name = "ifSpecific",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.interfaces.ifTable.ifEntry.ifSpecific",
                OID = ".1.3.6.1.2.1.2.2.1.22",
                Type = "OBJECT IDENTIFIER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"A reference to MIB definitions specific to the particular media being used to realize the interface.  For example, if the interface is realized by an ethernet, then the value of this object refers to a document defining objects specific to ethernet.  If this information is not present, its value should be set to the OBJECT IDENTIFIER {0 0 }, which is a syntatically valid object identifier, and any conformant implementation of ASN.1 and BER must be able to generate and recognize this value."
            },
            new MibEntry
            {
                Name = "at",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.at",
                OID = ".1.3.6.1.2.1.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "atTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.at.atTable",
                OID = ".1.3.6.1.2.1.3.1",
                Type = "SEQUENCE OF AtEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"The Address Translation tables contain the NetworkAddress to `physical' address equivalences. Some interfaces do not use translation tables for determining address equivalences (e.g., DDN-X.25 has an algorithmic method);if all interfaces are of this type, then the Address Translation table is empty, i.e., has zero entries."
            },
            new MibEntry
            {
                Name = "atEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.at.atTable.atEntry",
                OID = ".1.3.6.1.2.1.3.1.1",
                Type = "AtEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"Each entry contains one NetworkAddress to `physical' address equivalence."
            },
            new MibEntry
            {
                Name = "atIfIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.at.atTable.atEntry.atIfIndex",
                OID = ".1.3.6.1.2.1.3.1.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The interface on which this entry's equivalence is effective.  The interface identified by a particular value of this index is the same interface as identified by the same value of ifIndex."
            },
            new MibEntry
            {
                Name = "atPhysAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.at.atTable.atEntry.atPhysAddress",
                OID = ".1.3.6.1.2.1.3.1.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The media-dependent `physical' address. Setting this object to a null string (one of zero length) has the effect of invaliding the corresponding entry in the atTable object.  That is, it effectively dissasociates the interface identified with said entry from the mapping identified with said entry.  It is an implementation-specific matter as to whether the agent removes an invalidated entry from the table. Accordingly, management stations must be prepared to receive tabular information from agents that corresponds to entries not currently in use. Proper interpretation of such entries requires examination of the relevant atPhysAddress object."
            },
            new MibEntry
            {
                Name = "atNetAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.at.atTable.atEntry.atNetAddress",
                OID = ".1.3.6.1.2.1.3.1.1.3",
                Type = "NETWORKADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The NetworkAddress (e.g., the IP address) corresponding to the media-dependent `physical' address."
            },
            new MibEntry
            {
                Name = "ip",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip",
                OID = ".1.3.6.1.2.1.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "ipForwarding",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipForwarding",
                OID = ".1.3.6.1.2.1.4.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The indication of whether this entity is acting as an IP gateway in respect to the forwarding of datagrams received by, but not addressed to, this entity.  IP gateways forward datagrams.  IP hosts do not (except those source-routed via the host). Note that for some managed nodes, this object may take on only a subset of the values possible. Accordingly, it is appropriate for an agent to return a `badValue' response if a management station attempts to change this object to an inappropriate value."
            },
            new MibEntry
            {
                Name = "ipDefaultTTL",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipDefaultTTL",
                OID = ".1.3.6.1.2.1.4.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The default value inserted into the Time-To-Live field of the IP header of datagrams originated at this entity, whenever a TTL value is not supplied by the transport layer protocol."
            },
            new MibEntry
            {
                Name = "ipInReceives",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipInReceives",
                OID = ".1.3.6.1.2.1.4.3",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of input datagrams received from interfaces, including those received in error."
            },
            new MibEntry
            {
                Name = "ipInHdrErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipInHdrErrors",
                OID = ".1.3.6.1.2.1.4.4",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of input datagrams discarded due to errors in their IP headers, including bad checksums, version number mismatch, other format errors, time-to-live exceeded, errors discovered in processing their IP options, etc."
            },
            new MibEntry
            {
                Name = "ipInAddrErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipInAddrErrors",
                OID = ".1.3.6.1.2.1.4.5",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of input datagrams discarded because the IP address in their IP header's destination field was not a valid address to be received at this entity.  This count includes invalid addresses (e.g., 0.0.0.0) and addresses of unsupported Classes (e.g., Class E).  For entities which are not IP Gateways and therefore do not forward datagrams, this counter includes datagrams discarded because the destination address was not a local address."
            },
            new MibEntry
            {
                Name = "ipForwDatagrams",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipForwDatagrams",
                OID = ".1.3.6.1.2.1.4.6",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of input datagrams for which this entity was not their final IP destination, as a result of which an attempt was made to find a route to forward them to that final destination. In entities which do not act as IP Gateways, this counter will include only those packets which were Source-Routed via this entity, and the Source- Route option processing was successful."
            },
            new MibEntry
            {
                Name = "ipInUnknownProtos",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipInUnknownProtos",
                OID = ".1.3.6.1.2.1.4.7",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of locally-addressed datagrams received successfully but discarded because of an unknown or unsupported protocol."
            },
            new MibEntry
            {
                Name = "ipInDiscards",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipInDiscards",
                OID = ".1.3.6.1.2.1.4.8",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of input IP datagrams for which no problems were encountered to prevent their continued processing, but which were discarded (e.g., for lack of buffer space).  Note that this counter does not include any datagrams discarded while awaiting re-assembly."
            },
            new MibEntry
            {
                Name = "ipInDelivers",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipInDelivers",
                OID = ".1.3.6.1.2.1.4.9",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of input datagrams successfully delivered to IP user-protocols (including ICMP)."
            },
            new MibEntry
            {
                Name = "ipOutRequests",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipOutRequests",
                OID = ".1.3.6.1.2.1.4.10",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of IP datagrams which local IP user-protocols (including ICMP) supplied to IP in requests for transmission.  Note that this counter does not include any datagrams counted in ipForwDatagrams."
            },
            new MibEntry
            {
                Name = "ipOutDiscards",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipOutDiscards",
                OID = ".1.3.6.1.2.1.4.11",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of output IP datagrams for which no problem was encountered to prevent their transmission to their destination, but which were discarded (e.g., for lack of buffer space).  Note that this counter would include datagrams counted in ipForwDatagrams if any such packets met this (discretionary) discard criterion."
            },
            new MibEntry
            {
                Name = "ipOutNoRoutes",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipOutNoRoutes",
                OID = ".1.3.6.1.2.1.4.12",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of IP datagrams discarded because no route could be found to transmit them to their destination.  Note that this counter includes any packets counted in ipForwDatagrams which meet this `no-route' criterion.  Note that this includes any datagarms which a host cannot route because all of its default gateways are down."
            },
            new MibEntry
            {
                Name = "ipReasmTimeout",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipReasmTimeout",
                OID = ".1.3.6.1.2.1.4.13",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The maximum number of seconds which received fragments are held while they are awaiting reassembly at this entity."
            },
            new MibEntry
            {
                Name = "ipReasmReqds",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipReasmReqds",
                OID = ".1.3.6.1.2.1.4.14",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of IP fragments received which needed to be reassembled at this entity."
            },
            new MibEntry
            {
                Name = "ipReasmOKs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipReasmOKs",
                OID = ".1.3.6.1.2.1.4.15",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of IP datagrams successfully re- assembled."
            },
            new MibEntry
            {
                Name = "ipReasmFails",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipReasmFails",
                OID = ".1.3.6.1.2.1.4.16",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of failures detected by the IP re- assembly algorithm (for whatever reason:timed out, errors, etc).  Note that this is not necessarily a count of discarded IP fragments since some algorithms (notably the algorithm in RFC 815) can lose track of the number of fragments by combining them as they are received."
            },
            new MibEntry
            {
                Name = "ipFragOKs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipFragOKs",
                OID = ".1.3.6.1.2.1.4.17",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of IP datagrams that have been successfully fragmented at this entity."
            },
            new MibEntry
            {
                Name = "ipFragFails",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipFragFails",
                OID = ".1.3.6.1.2.1.4.18",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of IP datagrams that have been discarded because they needed to be fragmented at this entity but could not be, e.g., because their Don't Fragment flag was set."
            },
            new MibEntry
            {
                Name = "ipFragCreates",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipFragCreates",
                OID = ".1.3.6.1.2.1.4.19",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of IP datagram fragments that have been generated as a result of fragmentation at this entity."
            },
            new MibEntry
            {
                Name = "ipAddrTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipAddrTable",
                OID = ".1.3.6.1.2.1.4.20",
                Type = "SEQUENCE OF IpAddrEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"The table of addressing information relevant to this entity's IP addresses."
            },
            new MibEntry
            {
                Name = "ipAddrEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipAddrTable.ipAddrEntry",
                OID = ".1.3.6.1.2.1.4.20.1",
                Type = "IpAddrEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"The addressing information for one of this entity's IP addresses."
            },
            new MibEntry
            {
                Name = "ipAdEntAddr",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipAddrTable.ipAddrEntry.ipAdEntAddr",
                OID = ".1.3.6.1.2.1.4.20.1.1",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The IP address to which this entry's addressing information pertains."
            },
            new MibEntry
            {
                Name = "ipAdEntIfIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipAddrTable.ipAddrEntry.ipAdEntIfIndex",
                OID = ".1.3.6.1.2.1.4.20.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The index value which uniquely identifies the interface to which this entry is applicable.  The interface identified by a particular value of this index is the same interface as identified by the same value of ifIndex."
            },
            new MibEntry
            {
                Name = "ipAdEntNetMask",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipAddrTable.ipAddrEntry.ipAdEntNetMask",
                OID = ".1.3.6.1.2.1.4.20.1.3",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The subnet mask associated with the IP address of this entry.  The value of the mask is an IP address with all the network bits set to 1 and all the hosts bits set to 0."
            },
            new MibEntry
            {
                Name = "ipAdEntBcastAddr",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipAddrTable.ipAddrEntry.ipAdEntBcastAddr",
                OID = ".1.3.6.1.2.1.4.20.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The value of the least-significant bit in the IP broadcast address used for sending datagrams on the (logical) interface associated with the IP address of this entry.  For example, when the Internet standard all-ones broadcast address is used, the value will be 1.  This value applies to both the subnet and network broadcasts addresses used by the entity on this (logical) interface."
            },
            new MibEntry
            {
                Name = "ipAdEntReasmMaxSize",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipAddrTable.ipAddrEntry.ipAdEntReasmMaxSize",
                OID = ".1.3.6.1.2.1.4.20.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The size of the largest IP datagram which this entity can re-assemble from incoming IP fragmented datagrams received on this interface."
            },
            new MibEntry
            {
                Name = "ipRouteTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable",
                OID = ".1.3.6.1.2.1.4.21",
                Type = "SEQUENCE OF IpRouteEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"This entity's IP Routing table."
            },
            new MibEntry
            {
                Name = "ipRouteEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry",
                OID = ".1.3.6.1.2.1.4.21.1",
                Type = "IpRouteEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"A route to a particular destination."
            },
            new MibEntry
            {
                Name = "ipRouteDest",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteDest",
                OID = ".1.3.6.1.2.1.4.21.1.1",
                Type = "IPADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The destination IP address of this route.  An entry with a value of 0.0.0.0 is considered a default route.  Multiple routes to a single destination can appear in the table, but access to such multiple entries is dependent on the table- access mechanisms defined by the network management protocol in use."
            },
            new MibEntry
            {
                Name = "ipRouteIfIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteIfIndex",
                OID = ".1.3.6.1.2.1.4.21.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The index value which uniquely identifies the local interface through which the next hop of this route should be reached.  The interface identified by a particular value of this index is the same interface as identified by the same value of ifIndex."
            },
            new MibEntry
            {
                Name = "ipRouteMetric1",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteMetric1",
                OID = ".1.3.6.1.2.1.4.21.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The primary routing metric for this route.  The semantics of this metric are determined by the routing-protocol specified in the route's ipRouteProto value.  If this metric is not used, its value should be set to -1."
            },
            new MibEntry
            {
                Name = "ipRouteMetric2",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteMetric2",
                OID = ".1.3.6.1.2.1.4.21.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"An alternate routing metric for this route.  The semantics of this metric are determined by the routing-protocol specified in the route's ipRouteProto value.  If this metric is not used, its value should be set to -1."
            },
            new MibEntry
            {
                Name = "ipRouteMetric3",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteMetric3",
                OID = ".1.3.6.1.2.1.4.21.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"An alternate routing metric for this route.  The semantics of this metric are determined by the routing-protocol specified in the route's ipRouteProto value.  If this metric is not used, its value should be set to -1."
            },
            new MibEntry
            {
                Name = "ipRouteMetric4",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteMetric4",
                OID = ".1.3.6.1.2.1.4.21.1.6",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"An alternate routing metric for this route.  The semantics of this metric are determined by the routing-protocol specified in the route's ipRouteProto value.  If this metric is not used, its value should be set to -1."
            },
            new MibEntry
            {
                Name = "ipRouteNextHop",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteNextHop",
                OID = ".1.3.6.1.2.1.4.21.1.7",
                Type = "IPADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The IP address of the next hop of this route. (In the case of a route bound to an interface which is realized via a broadcast media, the value of this field is the agent's IP address on that interface.)"
            },
            new MibEntry
            {
                Name = "ipRouteType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteType",
                OID = ".1.3.6.1.2.1.4.21.1.8",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The type of route.  Note that the values direct(3) and indirect(4) refer to the notion of direct and indirect routing in the IP architecture. Setting this object to the value invalid(2) has the effect of invalidating the corresponding entry in the ipRouteTable object.  That is, it effectively dissasociates the destination identified with said entry from the route identified with said entry.  It is an implementation-specific matter as to whether the agent removes an invalidated entry from the table. Accordingly, management stations must be prepared to receive tabular information from agents that corresponds to entries not currently in use. Proper interpretation of such entries requires examination of the relevant ipRouteType object."
            },
            new MibEntry
            {
                Name = "ipRouteProto",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteProto",
                OID = ".1.3.6.1.2.1.4.21.1.9",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The routing mechanism via which this route was learned.  Inclusion of values for gateway routing protocols is not intended to imply that hosts should support those protocols."
            },
            new MibEntry
            {
                Name = "ipRouteAge",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteAge",
                OID = ".1.3.6.1.2.1.4.21.1.10",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of seconds since this route was last updated or otherwise determined to be correct. Note that no semantics of `too old' can be implied except through knowledge of the routing protocol by which the route was learned."
            },
            new MibEntry
            {
                Name = "ipRouteMask",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteMask",
                OID = ".1.3.6.1.2.1.4.21.1.11",
                Type = "IPADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"Indicate the mask to be logical-ANDed with the destination address before being compared to the value in the ipRouteDest field.  For those systems that do not support arbitrary subnet masks, an agent constructs the value of the ipRouteMask by determining whether the value of the correspondent ipRouteDest field belong to a class-A, B, or C network, and then using one of: mask           network 255.0.0.0      class-A 255.255.0.0    class-B 255.255.255.0  class-C If the value of the ipRouteDest is 0.0.0.0 (a default route), then the mask value is also 0.0.0.0.  It should be noted that all IP routing subsystems implicitly use this mechanism."
            },
            new MibEntry
            {
                Name = "ipRouteMetric5",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteMetric5",
                OID = ".1.3.6.1.2.1.4.21.1.12",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"An alternate routing metric for this route.  The semantics of this metric are determined by the routing-protocol specified in the route's ipRouteProto value.  If this metric is not used, its value should be set to -1."
            },
            new MibEntry
            {
                Name = "ipRouteInfo",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRouteTable.ipRouteEntry.ipRouteInfo",
                OID = ".1.3.6.1.2.1.4.21.1.13",
                Type = "OBJECT IDENTIFIER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"A reference to MIB definitions specific to the particular routing protocol which is responsible for this route, as determined by the value specified in the route's ipRouteProto value.  If this information is not present, its value should be set to the OBJECT IDENTIFIER {0 0 }, which is a syntatically valid object identifier, and any conformant implementation of ASN.1 and BER must be able to generate and recognize this value."
            },
            new MibEntry
            {
                Name = "ipNetToMediaTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipNetToMediaTable",
                OID = ".1.3.6.1.2.1.4.22",
                Type = "SEQUENCE OF IpNetToMediaEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"The IP Address Translation table used for mapping from IP addresses to physical addresses."
            },
            new MibEntry
            {
                Name = "ipNetToMediaEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipNetToMediaTable.ipNetToMediaEntry",
                OID = ".1.3.6.1.2.1.4.22.1",
                Type = "IpNetToMediaEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"Each entry contains one IpAddress to `physical' address equivalence."
            },
            new MibEntry
            {
                Name = "ipNetToMediaIfIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipNetToMediaTable.ipNetToMediaEntry.ipNetToMediaIfIndex",
                OID = ".1.3.6.1.2.1.4.22.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The interface on which this entry's equivalence is effective.  The interface identified by a particular value of this index is the same interface as identified by the same value of ifIndex."
            },
            new MibEntry
            {
                Name = "ipNetToMediaPhysAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipNetToMediaTable.ipNetToMediaEntry.ipNetToMediaPhysAddress",
                OID = ".1.3.6.1.2.1.4.22.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The media-dependent `physical' address."
            },
            new MibEntry
            {
                Name = "ipNetToMediaNetAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipNetToMediaTable.ipNetToMediaEntry.ipNetToMediaNetAddress",
                OID = ".1.3.6.1.2.1.4.22.1.3",
                Type = "IPADDRESS",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The IpAddress corresponding to the media- dependent `physical' address."
            },
            new MibEntry
            {
                Name = "ipNetToMediaType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipNetToMediaTable.ipNetToMediaEntry.ipNetToMediaType",
                OID = ".1.3.6.1.2.1.4.22.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The type of mapping. Setting this object to the value invalid(2) has the effect of invalidating the corresponding entry in the ipNetToMediaTable.  That is, it effectively dissasociates the interface identified with said entry from the mapping identified with said entry. It is an implementation-specific matter as to whether the agent removes an invalidated entry from the table.  Accordingly, management stations must be prepared to receive tabular information from agents that corresponds to entries not currently in use.  Proper interpretation of such entries requires examination of the relevant ipNetToMediaType object."
            },
            new MibEntry
            {
                Name = "ipRoutingDiscards",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.ip.ipRoutingDiscards",
                OID = ".1.3.6.1.2.1.4.23",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of routing entries which were chosen to be discarded even though they are valid.  One possible reason for discarding such an entry could be to free-up buffer space for other routing entries."
            },
            new MibEntry
            {
                Name = "icmp",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp",
                OID = ".1.3.6.1.2.1.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "icmpInMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInMsgs",
                OID = ".1.3.6.1.2.1.5.1",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of ICMP messages which the entity received.  Note that this counter includes all those counted by icmpInErrors."
            },
            new MibEntry
            {
                Name = "icmpInErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInErrors",
                OID = ".1.3.6.1.2.1.5.2",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP messages which the entity received but determined as having ICMP-specific errors (bad ICMP checksums, bad length, etc.)."
            },
            new MibEntry
            {
                Name = "icmpInDestUnreachs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInDestUnreachs",
                OID = ".1.3.6.1.2.1.5.3",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Destination Unreachable messages received."
            },
            new MibEntry
            {
                Name = "icmpInTimeExcds",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInTimeExcds",
                OID = ".1.3.6.1.2.1.5.4",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Time Exceeded messages received."
            },
            new MibEntry
            {
                Name = "icmpInParmProbs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInParmProbs",
                OID = ".1.3.6.1.2.1.5.5",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Parameter Problem messages received."
            },
            new MibEntry
            {
                Name = "icmpInSrcQuenchs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInSrcQuenchs",
                OID = ".1.3.6.1.2.1.5.6",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Source Quench messages received."
            },
            new MibEntry
            {
                Name = "icmpInRedirects",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInRedirects",
                OID = ".1.3.6.1.2.1.5.7",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Redirect messages received."
            },
            new MibEntry
            {
                Name = "icmpInEchos",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInEchos",
                OID = ".1.3.6.1.2.1.5.8",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Echo (request) messages received."
            },
            new MibEntry
            {
                Name = "icmpInEchoReps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInEchoReps",
                OID = ".1.3.6.1.2.1.5.9",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Echo Reply messages received."
            },
            new MibEntry
            {
                Name = "icmpInTimestamps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInTimestamps",
                OID = ".1.3.6.1.2.1.5.10",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Timestamp (request) messages received."
            },
            new MibEntry
            {
                Name = "icmpInTimestampReps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInTimestampReps",
                OID = ".1.3.6.1.2.1.5.11",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Timestamp Reply messages received."
            },
            new MibEntry
            {
                Name = "icmpInAddrMasks",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInAddrMasks",
                OID = ".1.3.6.1.2.1.5.12",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Address Mask Request messages received."
            },
            new MibEntry
            {
                Name = "icmpInAddrMaskReps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpInAddrMaskReps",
                OID = ".1.3.6.1.2.1.5.13",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Address Mask Reply messages received."
            },
            new MibEntry
            {
                Name = "icmpOutMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutMsgs",
                OID = ".1.3.6.1.2.1.5.14",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of ICMP messages which this entity attempted to send.  Note that this counter includes all those counted by icmpOutErrors."
            },
            new MibEntry
            {
                Name = "icmpOutErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutErrors",
                OID = ".1.3.6.1.2.1.5.15",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP messages which this entity did not send due to problems discovered within ICMP such as a lack of buffers.  This value should not include errors discovered outside the ICMP layer such as the inability of IP to route the resultant datagram.  In some implementations there may be no types of error which contribute to this counter's value."
            },
            new MibEntry
            {
                Name = "icmpOutDestUnreachs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutDestUnreachs",
                OID = ".1.3.6.1.2.1.5.16",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Destination Unreachable messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutTimeExcds",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutTimeExcds",
                OID = ".1.3.6.1.2.1.5.17",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Time Exceeded messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutParmProbs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutParmProbs",
                OID = ".1.3.6.1.2.1.5.18",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Parameter Problem messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutSrcQuenchs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutSrcQuenchs",
                OID = ".1.3.6.1.2.1.5.19",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Source Quench messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutRedirects",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutRedirects",
                OID = ".1.3.6.1.2.1.5.20",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Redirect messages sent.  For a host, this object will always be zero, since hosts do not send redirects."
            },
            new MibEntry
            {
                Name = "icmpOutEchos",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutEchos",
                OID = ".1.3.6.1.2.1.5.21",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Echo (request) messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutEchoReps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutEchoReps",
                OID = ".1.3.6.1.2.1.5.22",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Echo Reply messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutTimestamps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutTimestamps",
                OID = ".1.3.6.1.2.1.5.23",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Timestamp (request) messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutTimestampReps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutTimestampReps",
                OID = ".1.3.6.1.2.1.5.24",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Timestamp Reply messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutAddrMasks",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutAddrMasks",
                OID = ".1.3.6.1.2.1.5.25",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Address Mask Request messages sent."
            },
            new MibEntry
            {
                Name = "icmpOutAddrMaskReps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.icmp.icmpOutAddrMaskReps",
                OID = ".1.3.6.1.2.1.5.26",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of ICMP Address Mask Reply messages sent."
            },
            new MibEntry
            {
                Name = "tcp",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp",
                OID = ".1.3.6.1.2.1.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "tcpRtoAlgorithm",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpRtoAlgorithm",
                OID = ".1.3.6.1.2.1.6.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The algorithm used to determine the timeout value used for retransmitting unacknowledged octets."
            },
            new MibEntry
            {
                Name = "tcpRtoMin",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpRtoMin",
                OID = ".1.3.6.1.2.1.6.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The minimum value permitted by a TCP implementation for the retransmission timeout, measured in milliseconds.  More refined semantics for objects of this type depend upon the algorithm used to determine the retransmission timeout.  In particular, when the timeout algorithm is rsre(3), an object of this type has the semantics of the LBOUND quantity described in RFC 793."
            },
            new MibEntry
            {
                Name = "tcpRtoMax",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpRtoMax",
                OID = ".1.3.6.1.2.1.6.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The maximum value permitted by a TCP implementation for the retransmission timeout, measured in milliseconds.  More refined semantics for objects of this type depend upon the algorithm used to determine the retransmission timeout.  In particular, when the timeout algorithm is rsre(3), an object of this type has the semantics of the UBOUND quantity described in RFC 793."
            },
            new MibEntry
            {
                Name = "tcpMaxConn",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpMaxConn",
                OID = ".1.3.6.1.2.1.6.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The limit on the total number of TCP connections the entity can support.  In entities where the maximum number of connections is dynamic, this object should contain the value -1."
            },
            new MibEntry
            {
                Name = "tcpActiveOpens",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpActiveOpens",
                OID = ".1.3.6.1.2.1.6.5",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of times TCP connections have made a direct transition to the SYN-SENT state from the CLOSED state."
            },
            new MibEntry
            {
                Name = "tcpPassiveOpens",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpPassiveOpens",
                OID = ".1.3.6.1.2.1.6.6",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of times TCP connections have made a direct transition to the SYN-RCVD state from the LISTEN state."
            },
            new MibEntry
            {
                Name = "tcpAttemptFails",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpAttemptFails",
                OID = ".1.3.6.1.2.1.6.7",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of times TCP connections have made a direct transition to the CLOSED state from either the SYN-SENT state or the SYN-RCVD state, plus the number of times TCP connections have made a direct transition to the LISTEN state from the SYN-RCVD state."
            },
            new MibEntry
            {
                Name = "tcpEstabResets",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpEstabResets",
                OID = ".1.3.6.1.2.1.6.8",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of times TCP connections have made a direct transition to the CLOSED state from either the ESTABLISHED state or the CLOSE-WAIT state."
            },
            new MibEntry
            {
                Name = "tcpCurrEstab",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpCurrEstab",
                OID = ".1.3.6.1.2.1.6.9",
                Type = "GAUGE",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of TCP connections for which the current state is either ESTABLISHED or CLOSE- WAIT."
            },
            new MibEntry
            {
                Name = "tcpInSegs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpInSegs",
                OID = ".1.3.6.1.2.1.6.10",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of segments received, including those received in error.  This count includes segments received on currently established connections."
            },
            new MibEntry
            {
                Name = "tcpOutSegs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpOutSegs",
                OID = ".1.3.6.1.2.1.6.11",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of segments sent, including those on current connections but excluding those containing only retransmitted octets."
            },
            new MibEntry
            {
                Name = "tcpRetransSegs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpRetransSegs",
                OID = ".1.3.6.1.2.1.6.12",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of segments retransmitted - that is, the number of TCP segments transmitted containing one or more previously transmitted octets."
            },
            new MibEntry
            {
                Name = "tcpConnTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpConnTable",
                OID = ".1.3.6.1.2.1.6.13",
                Type = "SEQUENCE OF TcpConnEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"A table containing TCP connection-specific information."
            },
            new MibEntry
            {
                Name = "tcpConnEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpConnTable.tcpConnEntry",
                OID = ".1.3.6.1.2.1.6.13.1",
                Type = "TcpConnEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"Information about a particular current TCP connection.  An object of this type is transient, in that it ceases to exist when (or soon after) the connection makes the transition to the CLOSED state."
            },
            new MibEntry
            {
                Name = "tcpConnState",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpConnTable.tcpConnEntry.tcpConnState",
                OID = ".1.3.6.1.2.1.6.13.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"The state of this TCP connection. The only value which may be set by a management station is deleteTCB(12).  Accordingly, it is appropriate for an agent to return a `badValue' response if a management station attempts to set this object to any other value. If a management station sets this object to the value deleteTCB(12), then this has the effect of deleting the TCB (as defined in RFC 793) of the corresponding connection on the managed node, resulting in immediate termination of the connection. As an implementation-specific option, a RST segment may be sent from the managed node to the other TCP endpoint (note however that RST segments are not sent reliably)."
            },
            new MibEntry
            {
                Name = "tcpConnLocalAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpConnTable.tcpConnEntry.tcpConnLocalAddress",
                OID = ".1.3.6.1.2.1.6.13.1.2",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The local IP address for this TCP connection.  In the case of a connection in the listen state which is willing to accept connections for any IP interface associated with the node, the value 0.0.0.0 is used."
            },
            new MibEntry
            {
                Name = "tcpConnLocalPort",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpConnTable.tcpConnEntry.tcpConnLocalPort",
                OID = ".1.3.6.1.2.1.6.13.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The local port number for this TCP connection."
            },
            new MibEntry
            {
                Name = "tcpConnRemAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpConnTable.tcpConnEntry.tcpConnRemAddress",
                OID = ".1.3.6.1.2.1.6.13.1.4",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The remote IP address for this TCP connection."
            },
            new MibEntry
            {
                Name = "tcpConnRemPort",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpConnTable.tcpConnEntry.tcpConnRemPort",
                OID = ".1.3.6.1.2.1.6.13.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The remote port number for this TCP connection."
            },
            new MibEntry
            {
                Name = "tcpInErrs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpInErrs",
                OID = ".1.3.6.1.2.1.6.14",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of segments received in error (e.g., bad TCP checksums)."
            },
            new MibEntry
            {
                Name = "tcpOutRsts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.tcp.tcpOutRsts",
                OID = ".1.3.6.1.2.1.6.15",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of TCP segments sent containing the RST flag."
            },
            new MibEntry
            {
                Name = "udp",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp",
                OID = ".1.3.6.1.2.1.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "udpInDatagrams",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpInDatagrams",
                OID = ".1.3.6.1.2.1.7.1",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of UDP datagrams delivered to UDP users."
            },
            new MibEntry
            {
                Name = "udpNoPorts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpNoPorts",
                OID = ".1.3.6.1.2.1.7.2",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of received UDP datagrams for which there was no application at the destination port."
            },
            new MibEntry
            {
                Name = "udpInErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpInErrors",
                OID = ".1.3.6.1.2.1.7.3",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of received UDP datagrams that could not be delivered for reasons other than the lack of an application at the destination port."
            },
            new MibEntry
            {
                Name = "udpOutDatagrams",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpOutDatagrams",
                OID = ".1.3.6.1.2.1.7.4",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of UDP datagrams sent from this entity."
            },
            new MibEntry
            {
                Name = "udpTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpTable",
                OID = ".1.3.6.1.2.1.7.5",
                Type = "SEQUENCE OF UdpEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"A table containing UDP listener information."
            },
            new MibEntry
            {
                Name = "udpEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpTable.udpEntry",
                OID = ".1.3.6.1.2.1.7.5.1",
                Type = "UdpEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"Information about a particular current UDP listener."
            },
            new MibEntry
            {
                Name = "udpLocalAddress",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpTable.udpEntry.udpLocalAddress",
                OID = ".1.3.6.1.2.1.7.5.1.1",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The local IP address for this UDP listener.  In the case of a UDP listener which is willing to accept datagrams for any IP interface associated with the node, the value 0.0.0.0 is used."
            },
            new MibEntry
            {
                Name = "udpLocalPort",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.udp.udpTable.udpEntry.udpLocalPort",
                OID = ".1.3.6.1.2.1.7.5.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The local port number for this UDP listener."
            },
            new MibEntry
            {
                Name = "egp",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp",
                OID = ".1.3.6.1.2.1.8",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "egpInMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpInMsgs",
                OID = ".1.3.6.1.2.1.8.1",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP messages received without error."
            },
            new MibEntry
            {
                Name = "egpInErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpInErrors",
                OID = ".1.3.6.1.2.1.8.2",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP messages received that proved to be in error."
            },
            new MibEntry
            {
                Name = "egpOutMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpOutMsgs",
                OID = ".1.3.6.1.2.1.8.3",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of locally generated EGP messages."
            },
            new MibEntry
            {
                Name = "egpOutErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpOutErrors",
                OID = ".1.3.6.1.2.1.8.4",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of locally generated EGP messages not sent due to resource limitations within an EGP entity."
            },
            new MibEntry
            {
                Name = "egpNeighTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable",
                OID = ".1.3.6.1.2.1.8.5",
                Type = "SEQUENCE OF EgpNeighEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"The EGP neighbor table."
            },
            new MibEntry
            {
                Name = "egpNeighEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry",
                OID = ".1.3.6.1.2.1.8.5.1",
                Type = "EgpNeighEntry",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @"Information about this entity's relationship with a particular EGP neighbor."
            },
            new MibEntry
            {
                Name = "egpNeighState",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighState",
                OID = ".1.3.6.1.2.1.8.5.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The EGP state of the local system with respect to this entry's EGP neighbor.  Each EGP state is represented by a value that is one greater than the numerical value associated with said state in RFC 904."
            },
            new MibEntry
            {
                Name = "egpNeighAddr",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighAddr",
                OID = ".1.3.6.1.2.1.8.5.1.2",
                Type = "IPADDRESS",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The IP address of this entry's EGP neighbor."
            },
            new MibEntry
            {
                Name = "egpNeighAs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighAs",
                OID = ".1.3.6.1.2.1.8.5.1.3",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The autonomous system of this EGP peer.  Zero should be specified if the autonomous system number of the neighbor is not yet known."
            },
            new MibEntry
            {
                Name = "egpNeighInMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighInMsgs",
                OID = ".1.3.6.1.2.1.8.5.1.4",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP messages received without error from this EGP peer."
            },
            new MibEntry
            {
                Name = "egpNeighInErrs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighInErrs",
                OID = ".1.3.6.1.2.1.8.5.1.5",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP messages received from this EGP peer that proved to be in error (e.g., bad EGP checksum)."
            },
            new MibEntry
            {
                Name = "egpNeighOutMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighOutMsgs",
                OID = ".1.3.6.1.2.1.8.5.1.6",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of locally generated EGP messages to this EGP peer."
            },
            new MibEntry
            {
                Name = "egpNeighOutErrs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighOutErrs",
                OID = ".1.3.6.1.2.1.8.5.1.7",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of locally generated EGP messages not sent to this EGP peer due to resource limitations within an EGP entity."
            },
            new MibEntry
            {
                Name = "egpNeighInErrMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighInErrMsgs",
                OID = ".1.3.6.1.2.1.8.5.1.8",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP-defined error messages received from this EGP peer."
            },
            new MibEntry
            {
                Name = "egpNeighOutErrMsgs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighOutErrMsgs",
                OID = ".1.3.6.1.2.1.8.5.1.9",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP-defined error messages sent to this EGP peer."
            },
            new MibEntry
            {
                Name = "egpNeighStateUps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighStateUps",
                OID = ".1.3.6.1.2.1.8.5.1.10",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP state transitions to the UP state with this EGP peer."
            },
            new MibEntry
            {
                Name = "egpNeighStateDowns",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighStateDowns",
                OID = ".1.3.6.1.2.1.8.5.1.11",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The number of EGP state transitions from the UP state to any other state with this EGP peer."
            },
            new MibEntry
            {
                Name = "egpNeighIntervalHello",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighIntervalHello",
                OID = ".1.3.6.1.2.1.8.5.1.12",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The interval between EGP Hello command retransmissions (in hundredths of a second).  This represents the t1 timer as defined in RFC 904."
            },
            new MibEntry
            {
                Name = "egpNeighIntervalPoll",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighIntervalPoll",
                OID = ".1.3.6.1.2.1.8.5.1.13",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The interval between EGP poll command retransmissions (in hundredths of a second).  This represents the t3 timer as defined in RFC 904."
            },
            new MibEntry
            {
                Name = "egpNeighMode",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighMode",
                OID = ".1.3.6.1.2.1.8.5.1.14",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The polling mode of this EGP entity, either passive or active."
            },
            new MibEntry
            {
                Name = "egpNeighEventTrigger",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpNeighTable.egpNeighEntry.egpNeighEventTrigger",
                OID = ".1.3.6.1.2.1.8.5.1.15",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"A control variable used to trigger operator- initiated Start and Stop events.  When read, this variable always returns the most recent value that egpNeighEventTrigger was set to.  If it has not been set since the last initialization of the network management subsystem on the node, it returns a value of `stop'. When set, this variable causes a Start or Stop event on the specified neighbor, as specified on pages 8-10 of RFC 904.  Briefly, a Start event causes an Idle peer to begin neighbor acquisition and a non-Idle peer to reinitiate neighbor acquisition.  A stop event causes a non-Idle peer to return to the Idle state until a Start event occurs, either via egpNeighEventTrigger or otherwise."
            },
            new MibEntry
            {
                Name = "egpAs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.egp.egpAs",
                OID = ".1.3.6.1.2.1.8.6",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The autonomous system number of this EGP entity."
            },
            new MibEntry
            {
                Name = "transmission",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.transmission",
                OID = ".1.3.6.1.2.1.10",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "snmp",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp",
                OID = ".1.3.6.1.2.1.11",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "RFC1213-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "snmpInPkts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInPkts",
                OID = ".1.3.6.1.2.1.11.1",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of Messages delivered to the SNMP entity from the transport service."
            },
            new MibEntry
            {
                Name = "snmpOutPkts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutPkts",
                OID = ".1.3.6.1.2.1.11.2",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Messages which were passed from the SNMP protocol entity to the transport service."
            },
            new MibEntry
            {
                Name = "snmpInBadVersions",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInBadVersions",
                OID = ".1.3.6.1.2.1.11.3",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Messages which were delivered to the SNMP protocol entity and were for an unsupported SNMP version."
            },
            new MibEntry
            {
                Name = "snmpInBadCommunityNames",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInBadCommunityNames",
                OID = ".1.3.6.1.2.1.11.4",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Messages delivered to the SNMP protocol entity which used a SNMP community name not known to said entity."
            },
            new MibEntry
            {
                Name = "snmpInBadCommunityUses",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInBadCommunityUses",
                OID = ".1.3.6.1.2.1.11.5",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Messages delivered to the SNMP protocol entity which represented an SNMP operation which was not allowed by the SNMP community named in the Message."
            },
            new MibEntry
            {
                Name = "snmpInASNParseErrs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInASNParseErrs",
                OID = ".1.3.6.1.2.1.11.6",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of ASN.1 or BER errors encountered by the SNMP protocol entity when decoding received SNMP Messages."
            },
            new MibEntry
            {
                Name = "snmpInTooBigs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInTooBigs",
                OID = ".1.3.6.1.2.1.11.8",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were delivered to the SNMP protocol entity and for which the value of the error-status field is `tooBig'."
            },
            new MibEntry
            {
                Name = "snmpInNoSuchNames",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInNoSuchNames",
                OID = ".1.3.6.1.2.1.11.9",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were delivered to the SNMP protocol entity and for which the value of the error-status field is `noSuchName'."
            },
            new MibEntry
            {
                Name = "snmpInBadValues",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInBadValues",
                OID = ".1.3.6.1.2.1.11.10",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were delivered to the SNMP protocol entity and for which the value of the error-status field is `badValue'."
            },
            new MibEntry
            {
                Name = "snmpInReadOnlys",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInReadOnlys",
                OID = ".1.3.6.1.2.1.11.11",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number valid SNMP PDUs which were delivered to the SNMP protocol entity and for which the value of the error-status field is `readOnly'.  It should be noted that it is a protocol error to generate an SNMP PDU which contains the value `readOnly' in the error-status field, as such this object is provided as a means of detecting incorrect implementations of the SNMP."
            },
            new MibEntry
            {
                Name = "snmpInGenErrs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInGenErrs",
                OID = ".1.3.6.1.2.1.11.12",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were delivered to the SNMP protocol entity and for which the value of the error-status field is `genErr'."
            },
            new MibEntry
            {
                Name = "snmpInTotalReqVars",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInTotalReqVars",
                OID = ".1.3.6.1.2.1.11.13",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of MIB objects which have been retrieved successfully by the SNMP protocol entity as the result of receiving valid SNMP Get-Request and Get-Next PDUs."
            },
            new MibEntry
            {
                Name = "snmpInTotalSetVars",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInTotalSetVars",
                OID = ".1.3.6.1.2.1.11.14",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of MIB objects which have been altered successfully by the SNMP protocol entity as the result of receiving valid SNMP Set-Request PDUs."
            },
            new MibEntry
            {
                Name = "snmpInGetRequests",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInGetRequests",
                OID = ".1.3.6.1.2.1.11.15",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Get-Request PDUs which have been accepted and processed by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpInGetNexts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInGetNexts",
                OID = ".1.3.6.1.2.1.11.16",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Get-Next PDUs which have been accepted and processed by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpInSetRequests",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInSetRequests",
                OID = ".1.3.6.1.2.1.11.17",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Set-Request PDUs which have been accepted and processed by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpInGetResponses",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInGetResponses",
                OID = ".1.3.6.1.2.1.11.18",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Get-Response PDUs which have been accepted and processed by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpInTraps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpInTraps",
                OID = ".1.3.6.1.2.1.11.19",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Trap PDUs which have been accepted and processed by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpOutTooBigs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutTooBigs",
                OID = ".1.3.6.1.2.1.11.20",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were generated by the SNMP protocol entity and for which the value of the error-status field is `tooBig.'"
            },
            new MibEntry
            {
                Name = "snmpOutNoSuchNames",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutNoSuchNames",
                OID = ".1.3.6.1.2.1.11.21",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were generated by the SNMP protocol entity and for which the value of the error-status is `noSuchName'."
            },
            new MibEntry
            {
                Name = "snmpOutBadValues",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutBadValues",
                OID = ".1.3.6.1.2.1.11.22",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were generated by the SNMP protocol entity and for which the value of the error-status field is `badValue'."
            },
            new MibEntry
            {
                Name = "snmpOutGenErrs",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutGenErrs",
                OID = ".1.3.6.1.2.1.11.24",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP PDUs which were generated by the SNMP protocol entity and for which the value of the error-status field is `genErr'."
            },
            new MibEntry
            {
                Name = "snmpOutGetRequests",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutGetRequests",
                OID = ".1.3.6.1.2.1.11.25",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Get-Request PDUs which have been generated by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpOutGetNexts",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutGetNexts",
                OID = ".1.3.6.1.2.1.11.26",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Get-Next PDUs which have been generated by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpOutSetRequests",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutSetRequests",
                OID = ".1.3.6.1.2.1.11.27",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Set-Request PDUs which have been generated by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpOutGetResponses",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutGetResponses",
                OID = ".1.3.6.1.2.1.11.28",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Get-Response PDUs which have been generated by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpOutTraps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpOutTraps",
                OID = ".1.3.6.1.2.1.11.29",
                Type = "COUNTER",
                Access = AccessType.ReadOnly,
                MIBModule = "RFC1213-MIB",
                Description = @"The total number of SNMP Trap PDUs which have been generated by the SNMP protocol entity."
            },
            new MibEntry
            {
                Name = "snmpEnableAuthenTraps",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.snmp.snmpEnableAuthenTraps",
                OID = ".1.3.6.1.2.1.11.30",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "RFC1213-MIB",
                Description = @"Indicates whether the SNMP agent process is permitted to generate authentication-failure traps.  The value of this object overrides any configuration information;as such, it provides a means whereby all authentication-failure traps may be disabled. Note that it is strongly recommended that this object be stored in non-volatile memory so that it remains constant between re-initializations of the network management system."
            },
            new MibEntry
            {
                Name = "host",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host",
                OID = ".1.3.6.1.2.1.25",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrSystem",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem",
                OID = ".1.3.6.1.2.1.25.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrSystemUptime",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem.hrSystemUptime",
                OID = ".1.3.6.1.2.1.25.1.1",
                Type = "TIMETICKS",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The amount of time since this host was last initialized.  Note that this is different from sysUpTime in the SNMPv2-MIB [RFC1907] because sysUpTime is the uptime of the network management portion of the system."
            },
            new MibEntry
            {
                Name = "hrSystemDate",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem.hrSystemDate",
                OID = ".1.3.6.1.2.1.25.1.2",
                Type = "DateAndTime",
                Access = AccessType.ReadWrite,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The host's notion of the local date and time of day."
            },
            new MibEntry
            {
                Name = "hrSystemInitialLoadDevice",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem.hrSystemInitialLoadDevice",
                OID = ".1.3.6.1.2.1.25.1.3",
                Type = "INTEGER32",
                Access = AccessType.ReadWrite,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The index of the hrDeviceEntry for the device from which this host is configured to load its initial operating system configuration (i.e., which operating system code and/or boot parameters). Note that writing to this object just changes the configuration that will be used the next time the operating system is loaded and does not actually cause the reload to occur."
            },
            new MibEntry
            {
                Name = "hrSystemInitialLoadParameters",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem.hrSystemInitialLoadParameters",
                OID = ".1.3.6.1.2.1.25.1.4",
                Type = "OCTET STRING",
                Access = AccessType.ReadWrite,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"This object contains the parameters (e.g. a pathname and parameter) supplied to the load device when requesting the initial operating system configuration from that device. Note that writing to this object just changes the configuration that will be used the next time the operating system is loaded and does not actually cause the reload to occur."
            },
            new MibEntry
            {
                Name = "hrSystemNumUsers",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem.hrSystemNumUsers",
                OID = ".1.3.6.1.2.1.25.1.5",
                Type = "GAUGE32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The number of user sessions for which this host is storing state information.  A session is a collection of processes requiring a single act of user authentication and possibly subject to collective job control."
            },
            new MibEntry
            {
                Name = "hrSystemProcesses",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem.hrSystemProcesses",
                OID = ".1.3.6.1.2.1.25.1.6",
                Type = "GAUGE32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The number of process contexts currently loaded or running on this system."
            },
            new MibEntry
            {
                Name = "hrSystemMaxProcesses",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSystem.hrSystemMaxProcesses",
                OID = ".1.3.6.1.2.1.25.1.7",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The maximum number of process contexts this system can support.  If there is no fixed maximum, the value should be zero.  On systems that have a fixed maximum, this object can help diagnose failures that occur when this maximum is reached."
            },
            new MibEntry
            {
                Name = "hrStorage",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage",
                OID = ".1.3.6.1.2.1.25.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrStorageTypes",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTypes",
                OID = ".1.3.6.1.2.1.25.2.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrMemorySize",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrMemorySize",
                OID = ".1.3.6.1.2.1.25.2.2",
                Type = "Integer32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The amount of physical read-write main memory, typically RAM, contained by the host."
            },
            new MibEntry
            {
                Name = "hrStorageTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable",
                OID = ".1.3.6.1.2.1.25.2.3",
                Type = "SEQUENCE OF HrStorageEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of logical storage areas on the host. An entry shall be placed in the storage table for each logical area of storage that is allocated and has fixed resource limits.  The amount of storage represented in an entity is the amount actually usable by the requesting entity, and excludes loss due to formatting or file system reference information. These entries are associated with logical storage areas, as might be seen by an application, rather than physical storage entities which are typically seen by an operating system.  Storage such as tapes and floppies without file systems on them are typically not allocated in chunks by the operating system to requesting applications, and therefore shouldn't appear in this table.  Examples of valid storage for this table include disk partitions, file systems, ram (for some architectures this is further segmented into regular memory, extended memory, and so on), backing store for virtual memory (`swap space'). This table is intended to be a useful diagnostic for `out of memory' and `out of buffers' types of failures.  In addition, it can be a useful performance monitoring tool for tracking memory, disk, or buffer usage."
            },
            new MibEntry
            {
                Name = "hrStorageEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry",
                OID = ".1.3.6.1.2.1.25.2.3.1",
                Type = "HrStorageEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one logical storage area on the host.  As an example, an instance of the hrStorageType object might be named hrStorageType.3"
            },
            new MibEntry
            {
                Name = "hrStorageIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry.hrStorageIndex",
                OID = ".1.3.6.1.2.1.25.2.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A unique value for each logical storage area contained by the host."
            },
            new MibEntry
            {
                Name = "hrStorageType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry.hrStorageType",
                OID = ".1.3.6.1.2.1.25.2.3.1.2",
                Type = "AutonomousType",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The type of storage represented by this entry."
            },
            new MibEntry
            {
                Name = "hrStorageDescr",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry.hrStorageDescr",
                OID = ".1.3.6.1.2.1.25.2.3.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A description of the type and instance of the storage described by this entry."
            },
            new MibEntry
            {
                Name = "hrStorageAllocationUnits",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry.hrStorageAllocationUnits",
                OID = ".1.3.6.1.2.1.25.2.3.1.4",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The size, in bytes, of the data objects allocated from this pool.  If this entry is monitoring sectors, blocks, buffers, or packets, for example, this number will commonly be greater than one.  Otherwise this number will typically be one."
            },
            new MibEntry
            {
                Name = "hrStorageSize",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry.hrStorageSize",
                OID = ".1.3.6.1.2.1.25.2.3.1.5",
                Type = "INTEGER32",
                Access = AccessType.ReadWrite,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The size of the storage represented by this entry, in units of hrStorageAllocationUnits. This object is writable to allow remote configuration of the size of the storage area in those cases where such an operation makes sense and is possible on the underlying system. For example, the amount of main memory allocated to a buffer pool might be modified or the amount of disk space allocated to virtual memory might be modified."
            },
            new MibEntry
            {
                Name = "hrStorageUsed",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry.hrStorageUsed",
                OID = ".1.3.6.1.2.1.25.2.3.1.6",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The amount of the storage represented by this entry that is allocated, in units of hrStorageAllocationUnits."
            },
            new MibEntry
            {
                Name = "hrStorageAllocationFailures",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrStorage.hrStorageTable.hrStorageEntry.hrStorageAllocationFailures",
                OID = ".1.3.6.1.2.1.25.2.3.1.7",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The number of requests for storage represented by this entry that could not be honored due to not enough storage.  It should be noted that as this object has a SYNTAX of Counter32, that it does not have a defined initial value.  However, it is recommended that this object be initialized to zero, even though management stations must not depend on such an initialization."
            },
            new MibEntry
            {
                Name = "hrDevice",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice",
                OID = ".1.3.6.1.2.1.25.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrDeviceTypes",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTypes",
                OID = ".1.3.6.1.2.1.25.3.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrDeviceTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable",
                OID = ".1.3.6.1.2.1.25.3.2",
                Type = "SEQUENCE OF HrDeviceEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of devices contained by the host."
            },
            new MibEntry
            {
                Name = "hrDeviceEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable.hrDeviceEntry",
                OID = ".1.3.6.1.2.1.25.3.2.1",
                Type = "HrDeviceEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one device contained by the host.  As an example, an instance of the hrDeviceType object might be named hrDeviceType.3"
            },
            new MibEntry
            {
                Name = "hrDeviceIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable.hrDeviceEntry.hrDeviceIndex",
                OID = ".1.3.6.1.2.1.25.3.2.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A unique value for each device contained by the host. The value for each device must remain constant at least from one re-initialization of the agent to the next re-initialization."
            },
            new MibEntry
            {
                Name = "hrDeviceType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable.hrDeviceEntry.hrDeviceType",
                OID = ".1.3.6.1.2.1.25.3.2.1.2",
                Type = "AutonomousType",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"An indication of the type of device. If this value is `hrDeviceProcessor {hrDeviceTypes 3 }' then an entry exists in the hrProcessorTable which corresponds to this device. If this value is `hrDeviceNetwork {hrDeviceTypes 4 }', then an entry exists in the hrNetworkTable which corresponds to this device. If this value is `hrDevicePrinter {hrDeviceTypes 5 }', then an entry exists in the hrPrinterTable which corresponds to this device. If this value is `hrDeviceDiskStorage {hrDeviceTypes 6 }', then an entry exists in the hrDiskStorageTable which corresponds to this device."
            },
            new MibEntry
            {
                Name = "hrDeviceDescr",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable.hrDeviceEntry.hrDeviceDescr",
                OID = ".1.3.6.1.2.1.25.3.2.1.3",
                Type = "DISPLAYSTRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A textual description of this device, including the device's manufacturer and revision, and optionally, its serial number."
            },
            new MibEntry
            {
                Name = "hrDeviceID",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable.hrDeviceEntry.hrDeviceID",
                OID = ".1.3.6.1.2.1.25.3.2.1.4",
                Type = "OBJECT IDENTIFIER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The product ID for this device."
            },
            new MibEntry
            {
                Name = "hrDeviceStatus",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable.hrDeviceEntry.hrDeviceStatus",
                OID = ".1.3.6.1.2.1.25.3.2.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The current operational state of the device described by this row of the table.  A value unknown(1) indicates that the current state of the device is unknown.  running(2) indicates that the device is up and running and that no unusual error conditions are known.  The warning(3) state indicates that agent has been informed of an unusual error condition by the operational software (e.g., a disk device driver) but that the device is still 'operational'.  An example would be a high number of soft errors on a disk.  A value of testing(4), indicates that the device is not available for use because it is in the testing state. The state of down(5) is used only when the agent has been informed that the device is not available for any use."
            },
            new MibEntry
            {
                Name = "hrDeviceErrors",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDeviceTable.hrDeviceEntry.hrDeviceErrors",
                OID = ".1.3.6.1.2.1.25.3.2.1.6",
                Type = "COUNTER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The number of errors detected on this device.  It should be noted that as this object has a SYNTAX of Counter32, that it does not have a defined initial value.  However, it is recommended that this object be initialized to zero, even though management stations must not depend on such an initialization."
            },
            new MibEntry
            {
                Name = "hrProcessorTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrProcessorTable",
                OID = ".1.3.6.1.2.1.25.3.3",
                Type = "SEQUENCE OF HrProcessorEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of processors contained by the host. Note that this table is potentially sparse:a (conceptual) entry exists only if the correspondent value of the hrDeviceType object is `hrDeviceProcessor'."
            },
            new MibEntry
            {
                Name = "hrProcessorEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrProcessorTable.hrProcessorEntry",
                OID = ".1.3.6.1.2.1.25.3.3.1",
                Type = "HrProcessorEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one processor contained by the host.  The hrDeviceIndex in the index represents the entry in the hrDeviceTable that corresponds to the hrProcessorEntry. As an example of how objects in this table are named, an instance of the hrProcessorFrwID object might be named hrProcessorFrwID.3"
            },
            new MibEntry
            {
                Name = "hrProcessorFrwID",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrProcessorTable.hrProcessorEntry.hrProcessorFrwID",
                OID = ".1.3.6.1.2.1.25.3.3.1.1",
                Type = "OBJECT IDENTIFIER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The product ID of the firmware associated with the processor."
            },
            new MibEntry
            {
                Name = "hrProcessorLoad",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrProcessorTable.hrProcessorEntry.hrProcessorLoad",
                OID = ".1.3.6.1.2.1.25.3.3.1.2",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The average, over the last minute, of the percentage of time that this processor was not idle. Implementations may approximate this one minute smoothing period if necessary."
            },
            new MibEntry
            {
                Name = "hrNetworkTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrNetworkTable",
                OID = ".1.3.6.1.2.1.25.3.4",
                Type = "SEQUENCE OF HrNetworkEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of network devices contained by the host. Note that this table is potentially sparse:a (conceptual) entry exists only if the correspondent value of the hrDeviceType object is `hrDeviceNetwork'."
            },
            new MibEntry
            {
                Name = "hrNetworkEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrNetworkTable.hrNetworkEntry",
                OID = ".1.3.6.1.2.1.25.3.4.1",
                Type = "HrNetworkEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one network device contained by the host.  The hrDeviceIndex in the index represents the entry in the hrDeviceTable that corresponds to the hrNetworkEntry. As an example of how objects in this table are named, an instance of the hrNetworkIfIndex object might be named hrNetworkIfIndex.3"
            },
            new MibEntry
            {
                Name = "hrNetworkIfIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrNetworkTable.hrNetworkEntry.hrNetworkIfIndex",
                OID = ".1.3.6.1.2.1.25.3.4.1.1",
                Type = "InterfaceIndexOrZero",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The value of ifIndex which corresponds to this network device. If this device is not represented in the ifTable, then this value shall be zero."
            },
            new MibEntry
            {
                Name = "hrPrinterTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPrinterTable",
                OID = ".1.3.6.1.2.1.25.3.5",
                Type = "SEQUENCE OF HrPrinterEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of printers local to the host. Note that this table is potentially sparse:a (conceptual) entry exists only if the correspondent value of the hrDeviceType object is `hrDevicePrinter'."
            },
            new MibEntry
            {
                Name = "hrPrinterEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPrinterTable.hrPrinterEntry",
                OID = ".1.3.6.1.2.1.25.3.5.1",
                Type = "HrPrinterEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one printer local to the host.  The hrDeviceIndex in the index represents the entry in the hrDeviceTable that corresponds to the hrPrinterEntry. As an example of how objects in this table are named, an instance of the hrPrinterStatus object might be named hrPrinterStatus.3"
            },
            new MibEntry
            {
                Name = "hrPrinterStatus",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPrinterTable.hrPrinterEntry.hrPrinterStatus",
                OID = ".1.3.6.1.2.1.25.3.5.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The current status of this printer device."
            },
            new MibEntry
            {
                Name = "hrPrinterDetectedErrorState",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPrinterTable.hrPrinterEntry.hrPrinterDetectedErrorState",
                OID = ".1.3.6.1.2.1.25.3.5.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"This object represents any error conditions detected by the printer.  The error conditions are encoded as bits in an octet string, with the following definitions: Condition         Bit # lowPaper              0 noPaper               1 lowToner              2 noToner               3 doorOpen              4 jammed                5 offline               6 serviceRequested      7 inputTrayMissing      8 outputTrayMissing     9 markerSupplyMissing  10 outputNearFull       11 outputFull           12 inputTrayEmpty       13 overduePreventMaint  14 Bits are numbered starting with the most significant bit of the first byte being bit 0, the least significant bit of the first byte being bit 7, the most significant bit of the second byte being bit 8, and so on.  A one bit encodes that the condition was detected, while a zero bit encodes that the condition was not detected. This object is useful for alerting an operator to specific warning or error conditions that may occur, especially those requiring human intervention."
            },
            new MibEntry
            {
                Name = "hrDiskStorageTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDiskStorageTable",
                OID = ".1.3.6.1.2.1.25.3.6",
                Type = "SEQUENCE OF HrDiskStorageEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of long-term storage devices contained by the host.  In particular, disk devices accessed remotely over a network are not included here. Note that this table is potentially sparse:a (conceptual) entry exists only if the correspondent value of the hrDeviceType object is `hrDeviceDiskStorage'."
            },
            new MibEntry
            {
                Name = "hrDiskStorageEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDiskStorageTable.hrDiskStorageEntry",
                OID = ".1.3.6.1.2.1.25.3.6.1",
                Type = "HrDiskStorageEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one long-term storage device contained by the host.  The hrDeviceIndex in the index represents the entry in the hrDeviceTable that corresponds to the hrDiskStorageEntry. As an example, an instance of the hrDiskStorageCapacity object might be named hrDiskStorageCapacity.3"
            },
            new MibEntry
            {
                Name = "hrDiskStorageAccess",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDiskStorageTable.hrDiskStorageEntry.hrDiskStorageAccess",
                OID = ".1.3.6.1.2.1.25.3.6.1.1",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"An indication if this long-term storage device is readable and writable or only readable.  This should reflect the media type, any write-protect mechanism, and any device configuration that affects the entire device."
            },
            new MibEntry
            {
                Name = "hrDiskStorageMedia",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDiskStorageTable.hrDiskStorageEntry.hrDiskStorageMedia",
                OID = ".1.3.6.1.2.1.25.3.6.1.2",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"An indication of the type of media used in this long- term storage device."
            },
            new MibEntry
            {
                Name = "hrDiskStorageRemoveble",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDiskStorageTable.hrDiskStorageEntry.hrDiskStorageRemoveble",
                OID = ".1.3.6.1.2.1.25.3.6.1.3",
                Type = "TruthValue",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"Denotes whether or not the disk media may be removed from the drive."
            },
            new MibEntry
            {
                Name = "hrDiskStorageCapacity",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrDiskStorageTable.hrDiskStorageEntry.hrDiskStorageCapacity",
                OID = ".1.3.6.1.2.1.25.3.6.1.4",
                Type = "Integer32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The total size for this long-term storage device. If the media is removable and is currently removed, this value should be zero."
            },
            new MibEntry
            {
                Name = "hrPartitionTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPartitionTable",
                OID = ".1.3.6.1.2.1.25.3.7",
                Type = "SEQUENCE OF HrPartitionEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of partitions for long-term storage devices contained by the host.  In particular, partitions accessed remotely over a network are not included here."
            },
            new MibEntry
            {
                Name = "hrPartitionEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPartitionTable.hrPartitionEntry",
                OID = ".1.3.6.1.2.1.25.3.7.1",
                Type = "HrPartitionEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one partition.  The hrDeviceIndex in the index represents the entry in the hrDeviceTable that corresponds to the hrPartitionEntry. As an example of how objects in this table are named, an instance of the hrPartitionSize object might be named hrPartitionSize.3.1"
            },
            new MibEntry
            {
                Name = "hrPartitionIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPartitionTable.hrPartitionEntry.hrPartitionIndex",
                OID = ".1.3.6.1.2.1.25.3.7.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A unique value for each partition on this long-term storage device.  The value for each long-term storage device must remain constant at least from one re- initialization of the agent to the next re- initialization."
            },
            new MibEntry
            {
                Name = "hrPartitionLabel",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPartitionTable.hrPartitionEntry.hrPartitionLabel",
                OID = ".1.3.6.1.2.1.25.3.7.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A textual description of this partition."
            },
            new MibEntry
            {
                Name = "hrPartitionID",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPartitionTable.hrPartitionEntry.hrPartitionID",
                OID = ".1.3.6.1.2.1.25.3.7.1.3",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A descriptor which uniquely represents this partition to the responsible operating system.  On some systems, this might take on a binary representation."
            },
            new MibEntry
            {
                Name = "hrPartitionSize",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPartitionTable.hrPartitionEntry.hrPartitionSize",
                OID = ".1.3.6.1.2.1.25.3.7.1.4",
                Type = "Integer32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The size of this partition."
            },
            new MibEntry
            {
                Name = "hrPartitionFSIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrPartitionTable.hrPartitionEntry.hrPartitionFSIndex",
                OID = ".1.3.6.1.2.1.25.3.7.1.5",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The index of the file system mounted on this partition.  If no file system is mounted on this partition, then this value shall be zero.  Note that multiple partitions may point to one file system, denoting that that file system resides on those partitions.  Multiple file systems may not reside on one partition."
            },
            new MibEntry
            {
                Name = "hrFSTypes",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTypes",
                OID = ".1.3.6.1.2.1.25.3.9",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrFSTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable",
                OID = ".1.3.6.1.2.1.25.3.8",
                Type = "SEQUENCE OF HrFSEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of file systems local to this host or remotely mounted from a file server.  File systems that are in only one user's environment on a multi-user system will not be included in this table."
            },
            new MibEntry
            {
                Name = "hrFSEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry",
                OID = ".1.3.6.1.2.1.25.3.8.1",
                Type = "HrFSEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one file system local to this host or remotely mounted from a file server. File systems that are in only one user's environment on a multi-user system will not be included in this table. As an example of how objects in this table are named, an instance of the hrFSMountPoint object might be named hrFSMountPoint.3"
            },
            new MibEntry
            {
                Name = "hrFSIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSIndex",
                OID = ".1.3.6.1.2.1.25.3.8.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A unique value for each file system local to this host.  The value for each file system must remain constant at least from one re-initialization of the agent to the next re-initialization."
            },
            new MibEntry
            {
                Name = "hrFSMountPoint",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSMountPoint",
                OID = ".1.3.6.1.2.1.25.3.8.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The path name of the root of this file system."
            },
            new MibEntry
            {
                Name = "hrFSRemoteMountPoint",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSRemoteMountPoint",
                OID = ".1.3.6.1.2.1.25.3.8.1.3",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A description of the name and/or address of the server that this file system is mounted from.  This may also include parameters such as the mount point on the remote file system.  If this is not a remote file system, this string should have a length of zero."
            },
            new MibEntry
            {
                Name = "hrFSType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSType",
                OID = ".1.3.6.1.2.1.25.3.8.1.4",
                Type = "AutonomousType",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The value of this object identifies the type of this file system."
            },
            new MibEntry
            {
                Name = "hrFSAccess",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSAccess",
                OID = ".1.3.6.1.2.1.25.3.8.1.5",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"An indication if this file system is logically configured by the operating system to be readable and writable or only readable.  This does not represent any local access-control policy, except one that is applied to the file system as a whole."
            },
            new MibEntry
            {
                Name = "hrFSBootable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSBootable",
                OID = ".1.3.6.1.2.1.25.3.8.1.6",
                Type = "TruthValue",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A flag indicating whether this file system is bootable."
            },
            new MibEntry
            {
                Name = "hrFSStorageIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSStorageIndex",
                OID = ".1.3.6.1.2.1.25.3.8.1.7",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The index of the hrStorageEntry that represents information about this file system.  If there is no such information available, then this value shall be zero.  The relevant storage entry will be useful in tracking the percent usage of this file system and diagnosing errors that may occur when it runs out of space."
            },
            new MibEntry
            {
                Name = "hrFSLastFullBackupDate",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSLastFullBackupDate",
                OID = ".1.3.6.1.2.1.25.3.8.1.8",
                Type = "DateAndTime",
                Access = AccessType.ReadWrite,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The last date at which this complete file system was copied to another storage device for backup.  This information is useful for ensuring that backups are being performed regularly. If this information is not known, then this variable shall have the value corresponding to January 1, year 0000, 00:00:00.0, which is encoded as (hex)'00 00 01 01 00 00 00 00'."
            },
            new MibEntry
            {
                Name = "hrFSLastPartialBackupDate",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrDevice.hrFSTable.hrFSEntry.hrFSLastPartialBackupDate",
                OID = ".1.3.6.1.2.1.25.3.8.1.9",
                Type = "DateAndTime",
                Access = AccessType.ReadWrite,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The last date at which a portion of this file system was copied to another storage device for backup.  This information is useful for ensuring that backups are being performed regularly. If this information is not known, then this variable shall have the value corresponding to January 1, year 0000, 00:00:00.0, which is encoded as (hex)'00 00 01 01 00 00 00 00'."
            },
            new MibEntry
            {
                Name = "hrSWRun",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun",
                OID = ".1.3.6.1.2.1.25.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrSWOSIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWOSIndex",
                OID = ".1.3.6.1.2.1.25.4.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The value of the hrSWRunIndex for the hrSWRunEntry that represents the primary operating system running on this host.  This object is useful for quickly and uniquely identifying that primary operating system."
            },
            new MibEntry
            {
                Name = "hrSWRunTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable",
                OID = ".1.3.6.1.2.1.25.4.2",
                Type = "SEQUENCE OF HrSWRunEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of software running on the host."
            },
            new MibEntry
            {
                Name = "hrSWRunEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry",
                OID = ".1.3.6.1.2.1.25.4.2.1",
                Type = "HrSWRunEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for one piece of software running on the host Note that because the installed software table only contains information for software stored locally on this host, not every piece of running software will be found in the installed software table.  This is true of software that was loaded and run from a non-local source, such as a network-mounted file system. As an example of how objects in this table are named, an instance of the hrSWRunName object might be named hrSWRunName.1287"
            },
            new MibEntry
            {
                Name = "hrSWRunIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry.hrSWRunIndex",
                OID = ".1.3.6.1.2.1.25.4.2.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A unique value for each piece of software running on the host.  Wherever possible, this should be the system's native, unique identification number."
            },
            new MibEntry
            {
                Name = "hrSWRunName",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry.hrSWRunName",
                OID = ".1.3.6.1.2.1.25.4.2.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A textual description of this running piece of software, including the manufacturer, revision,  and the name by which it is commonly known.  If this software was installed locally, this should be the same string as used in the corresponding hrSWInstalledName."
            },
            new MibEntry
            {
                Name = "hrSWRunID",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry.hrSWRunID",
                OID = ".1.3.6.1.2.1.25.4.2.1.3",
                Type = "OBJECT IDENTIFIER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The product ID of this running piece of software."
            },
            new MibEntry
            {
                Name = "hrSWRunPath",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry.hrSWRunPath",
                OID = ".1.3.6.1.2.1.25.4.2.1.4",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A description of the location on long-term storage (e.g. a disk drive) from which this software was loaded."
            },
            new MibEntry
            {
                Name = "hrSWRunParameters",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry.hrSWRunParameters",
                OID = ".1.3.6.1.2.1.25.4.2.1.5",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A description of the parameters supplied to this software when it was initially loaded."
            },
            new MibEntry
            {
                Name = "hrSWRunType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry.hrSWRunType",
                OID = ".1.3.6.1.2.1.25.4.2.1.6",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The type of this software."
            },
            new MibEntry
            {
                Name = "hrSWRunStatus",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRun.hrSWRunTable.hrSWRunEntry.hrSWRunStatus",
                OID = ".1.3.6.1.2.1.25.4.2.1.7",
                Type = "INTEGER",
                Access = AccessType.ReadWrite,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The status of this running piece of software. Setting this value to invalid(4) shall cause this software to stop running and to be unloaded. Sets to other values are not valid."
            },
            new MibEntry
            {
                Name = "hrSWRunPerf",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRunPerf",
                OID = ".1.3.6.1.2.1.25.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrSWRunPerfTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRunPerf.hrSWRunPerfTable",
                OID = ".1.3.6.1.2.1.25.5.1",
                Type = "SEQUENCE OF HrSWRunPerfEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of running software performance metrics."
            },
            new MibEntry
            {
                Name = "hrSWRunPerfEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRunPerf.hrSWRunPerfTable.hrSWRunPerfEntry",
                OID = ".1.3.6.1.2.1.25.5.1.1",
                Type = "HrSWRunPerfEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry containing software performance metrics.  As an example, an instance of the hrSWRunPerfCPU object might be named hrSWRunPerfCPU.1287"
            },
            new MibEntry
            {
                Name = "hrSWRunPerfCPU",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRunPerf.hrSWRunPerfTable.hrSWRunPerfEntry.hrSWRunPerfCPU",
                OID = ".1.3.6.1.2.1.25.5.1.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The number of centi-seconds of the total system's CPU resources consumed by this process.  Note that on a multi-processor system, this value may increment by more than one centi-second in one centi-second of real (wall clock) time."
            },
            new MibEntry
            {
                Name = "hrSWRunPerfMem",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWRunPerf.hrSWRunPerfTable.hrSWRunPerfEntry.hrSWRunPerfMem",
                OID = ".1.3.6.1.2.1.25.5.1.1.2",
                Type = "Integer32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The total amount of real system memory allocated to this process."
            },
            new MibEntry
            {
                Name = "hrSWInstalled",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled",
                OID = ".1.3.6.1.2.1.25.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrSWInstalledLastChange",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledLastChange",
                OID = ".1.3.6.1.2.1.25.6.1",
                Type = "TIMETICKS",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The value of sysUpTime when an entry in the hrSWInstalledTable was last added, renamed, or deleted.  Because this table is likely to contain many entries, polling of this object allows a management station to determine when re-downloading of the table might be useful."
            },
            new MibEntry
            {
                Name = "hrSWInstalledLastUpdateTime",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledLastUpdateTime",
                OID = ".1.3.6.1.2.1.25.6.2",
                Type = "TIMETICKS",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The value of sysUpTime when the hrSWInstalledTable was last completely updated.  Because caching of this data will be a popular implementation strategy, retrieval of this object allows a management station to obtain a guarantee that no data in this table is older than the indicated time."
            },
            new MibEntry
            {
                Name = "hrSWInstalledTable",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledTable",
                OID = ".1.3.6.1.2.1.25.6.3",
                Type = "SEQUENCE OF HrSWInstalledEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The (conceptual) table of software installed on this host."
            },
            new MibEntry
            {
                Name = "hrSWInstalledEntry",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledTable.hrSWInstalledEntry",
                OID = ".1.3.6.1.2.1.25.6.3.1",
                Type = "HrSWInstalledEntry",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A (conceptual) entry for a piece of software installed on this host. As an example of how objects in this table are named, an instance of the hrSWInstalledName object might be named hrSWInstalledName.96"
            },
            new MibEntry
            {
                Name = "hrSWInstalledIndex",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledTable.hrSWInstalledEntry.hrSWInstalledIndex",
                OID = ".1.3.6.1.2.1.25.6.3.1.1",
                Type = "INTEGER32",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A unique value for each piece of software installed on the host.  This value shall be in the range from 1 to the number of pieces of software installed on the host."
            },
            new MibEntry
            {
                Name = "hrSWInstalledName",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledTable.hrSWInstalledEntry.hrSWInstalledName",
                OID = ".1.3.6.1.2.1.25.6.3.1.2",
                Type = "OCTET STRING",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"A textual description of this installed piece of software, including the manufacturer, revision, the name by which it is commonly known, and optionally, its serial number."
            },
            new MibEntry
            {
                Name = "hrSWInstalledID",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledTable.hrSWInstalledEntry.hrSWInstalledID",
                OID = ".1.3.6.1.2.1.25.6.3.1.3",
                Type = "OBJECT IDENTIFIER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The product ID of this installed piece of software."
            },
            new MibEntry
            {
                Name = "hrSWInstalledType",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledTable.hrSWInstalledEntry.hrSWInstalledType",
                OID = ".1.3.6.1.2.1.25.6.3.1.4",
                Type = "INTEGER",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The type of this software."
            },
            new MibEntry
            {
                Name = "hrSWInstalledDate",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrSWInstalled.hrSWInstalledTable.hrSWInstalledEntry.hrSWInstalledDate",
                OID = ".1.3.6.1.2.1.25.6.3.1.5",
                Type = "DateAndTime",
                Access = AccessType.ReadOnly,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The last-modification date of this application as it would appear in a directory listing. If this information is not known, then this variable shall have the value corresponding to January 1, year 0000, 00:00:00.0, which is encoded as (hex)'00 00 01 01 00 00 00 00'."
            },
            new MibEntry
            {
                Name = "hrMIBAdminInfo",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo",
                OID = ".1.3.6.1.2.1.25.7",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hostResourcesMibModule",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hostResourcesMibModule",
                OID = ".1.3.6.1.2.1.25.7.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrMIBCompliances",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBCompliances",
                OID = ".1.3.6.1.2.1.25.7.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrMIBCompliance",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBCompliances.hrMIBCompliance",
                OID = ".1.3.6.1.2.1.25.7.2.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The requirements for conformance to the Host Resources MIB."
            },
            new MibEntry
            {
                Name = "hrMIBGroups",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBGroups",
                OID = ".1.3.6.1.2.1.25.7.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @""
            },
            new MibEntry
            {
                Name = "hrSystemGroup",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBGroups.hrSystemGroup",
                OID = ".1.3.6.1.2.1.25.7.3.1",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The Host Resources System Group."
            },
            new MibEntry
            {
                Name = "hrStorageGroup",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBGroups.hrStorageGroup",
                OID = ".1.3.6.1.2.1.25.7.3.2",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The Host Resources Storage Group."
            },
            new MibEntry
            {
                Name = "hrDeviceGroup",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBGroups.hrDeviceGroup",
                OID = ".1.3.6.1.2.1.25.7.3.3",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The Host Resources Device Group."
            },
            new MibEntry
            {
                Name = "hrSWRunGroup",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBGroups.hrSWRunGroup",
                OID = ".1.3.6.1.2.1.25.7.3.4",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The Host Resources Running Software Group."
            },
            new MibEntry
            {
                Name = "hrSWRunPerfGroup",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBGroups.hrSWRunPerfGroup",
                OID = ".1.3.6.1.2.1.25.7.3.5",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The Host Resources Running Software Performance Group."
            },
            new MibEntry
            {
                Name = "hrSWInstalledGroup",
                FullName = ".iso.org.dod.internet.mgmt.mib-2.host.hrMIBAdminInfo.hrMIBGroups.hrSWInstalledGroup",
                OID = ".1.3.6.1.2.1.25.7.3.6",
                Type = "",
                Access = AccessType.Unknown,
                MIBModule = "HOST-RESOURCES-MIB",
                Description = @"The Host Resources Installed Software Group."
            },
        };
    }
}