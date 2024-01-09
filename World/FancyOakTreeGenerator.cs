using System.Numerics;
using Blocks;
using Managers;
using Settings;

namespace World;

public class FancyOakTreeGenerator(SettingsManager settingsManager, Vector3 spawnPoint)
    : OakTreeGenerator(settingsManager, spawnPoint)
{
    public override void Generate()
    {
        List<Location> locations = new();

        for (var i = 1; i <= 6; i++)
        {
            locations.Add(new Location(BlockType.Bedrock,
                spawnPoint with { Y = spawnPoint.Y + i }));
        }


        Inner = locations.ToArray();
    }
}