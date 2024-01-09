using System.Numerics;
using Blocks;
using Managers;
using Settings;

namespace World;

public class NormalOakTreeGenerator(SettingsManager settingsManager, Vector3 spawnPoint)
    : OakTreeGenerator(settingsManager, spawnPoint)
{
    public override void Generate()
    {
        List<Location> locations = new();

        for (var i = 1; i <= 5; i++)
        {
            locations.Add(new Location(BlockType.OakLog,
                spawnPoint with { Y = spawnPoint.Y + i }));
        }

        //Top Layer
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 6, X = 0 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 6, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 6, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 6, Z = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 6, Z = -1 }));


        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 5, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 5, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 5, Z = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 5, Z = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 5, X = 1, Z = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 5, X = 1, Z = 1 }));


        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 1, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 1, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 2, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 2, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -1, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -1, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -2, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -2, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 1, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 1, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 2, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = 2, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -1, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -1, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -2, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 4, Z = -2, X = -2 }));

        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 1, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 1, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 2, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 2, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -1, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -1, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -2, X = 1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -2, X = 2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 1, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 1, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 2, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = 2, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -1, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -1, X = -2 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -2, X = -1 }));
        locations.Add(new Location(BlockType.OakLeaves, spawnPoint with { Y = 3, Z = -2, X = -2 }));


        Inner = locations.ToArray();
    }
}