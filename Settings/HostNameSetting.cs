namespace Settings;

public class HostNameSetting(string value) : Setting<string>(value, "hostname");