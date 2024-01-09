using System.Numerics;
using Blocks;
using Managers;
using Settings;

namespace World;

public class FlatGrassGenerator:Generator
{
    public FlatGrassGenerator(SettingsManager settingsManager, Vector3 spawnPoint) : base(settingsManager, spawnPoint)
    {
    }

    public override void Generate()
    {
        List<Location> locations = new();
        var chunkSize = SettingsManager.ChunkSizeSetting.Value;

        for (int x = 0; x < chunkSize; x++)
        {
            for (int z = 0; z < chunkSize; z++)
            {
                locations.Add(new Location(BlockType.Bedrock,new(x,0,z)));
                locations.Add(new Location(BlockType.Stone,new(x,1,z)));
                locations.Add(new Location(BlockType.Stone,new(x,2,z)));
                locations.Add(new Location(BlockType.Stone,new(x,3,z)));
                locations.Add(new Location(BlockType.Dirt,new(x,4,z)));
                locations.Add(new Location(BlockType.PlainsGrass,new(x,5,z)));
            }
        }

        Inner = locations.ToArray();
    }
}