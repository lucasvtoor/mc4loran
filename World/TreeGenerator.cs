using System.Numerics;
using Managers;
using Settings;

namespace World;

public abstract class TreeGenerator : Generator
{
    public TreeGenerator(SettingsManager settingsManager, Vector3 spawnPoint) : base(settingsManager, spawnPoint)
    {
    }
}