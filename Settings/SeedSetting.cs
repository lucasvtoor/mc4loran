namespace Settings;

public class SeedSetting(string value) : Setting<int>(value, "seed");
