namespace Settings;

public class PortSetting(string value) : Setting<int>(value, "port");