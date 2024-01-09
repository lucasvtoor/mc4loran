namespace Settings;

public class ChunkSizeSetting(string value) : Setting<int>(value, "chunksize");
