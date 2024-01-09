namespace Settings;

public class LogLevelSetting(string value) : Setting<int>(value, "loglevel");