using System.Numerics;
using Managers;
using Settings;
using Util;

namespace World;

public abstract class Generator
{
    protected readonly SettingsManager SettingsManager;
    protected readonly Vector3 SpawnPoint;
    public Random Random;
    public Location[] Inner;

    public Generator(SettingsManager settingsManager, Vector3 spawnPoint)
    {
        SettingsManager = settingsManager;
        SpawnPoint = spawnPoint;
        var seed = $"{settingsManager.SeedSetting.Value}{spawnPoint.X}X{spawnPoint.Y}Y{spawnPoint.Z}Z";
        Random = new Random(seed.ToSeed());
    }

    public abstract void Generate();
}