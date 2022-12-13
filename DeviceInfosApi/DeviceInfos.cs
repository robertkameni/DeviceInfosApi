namespace DeviceInfosApi
{
    public class DeviceInfos
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Boolean Failsafe { get; set; }
        public string? DeviceTypeId { get; set; }
        public int TempMin { get; set; }
        public int TempMax { get; set; }
        public string? InstallationPosition { get; set; }
        public Boolean InsertInto19InchCabinet { get; set; }
        public Boolean TerminalElement { get; set; }
        public Boolean AdvancedEnvironmentConditions { get; set; }
    }
}
