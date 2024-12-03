namespace PrintWizard.Processes.SNMP
{
    public enum AccessType
    {
        ReadOnly,
        ReadWrite,
        Unknown
    }

    public class MibEntry
    {
        public MibEntry(string oid, string name = "", string fullName = "",  string type = "", AccessType access = AccessType.Unknown, string mIBModule = "", string description = "")
        {
            Name = name;
            FullName = fullName;
            OID = oid;
            Type = type;
            Access = access;
            MIBModule = mIBModule;
            Description = description;
        }

        public MibEntry() { }

        public string Name { get; set; }
        public string FullName { get; set; }
        public string OID { get; set; }
        public string Type { get; set; }
        public AccessType Access { get; set; }
        public string MIBModule { get; set; }
        public string Description { get; set; }


    }

}