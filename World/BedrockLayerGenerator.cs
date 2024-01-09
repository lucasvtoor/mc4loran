using System.Numerics;
using Blocks;
using Managers;
using Settings;

namespace World;

public class BedrockLayerGenerator(SettingsManager settingsManager, Vector3 bottomY) : Generator(settingsManager, bottomY)
{
    public static readonly int[] Chances = [100, 60, 40, 20];

    public override void Generate()
    {
        List<Location> locations = new();
     
        for (int y = 0; y < Chances.Length; y++)
        {
            for (int x = 0; x < settingsManager.ChunkSizeSetting.Value + 1; x++)
            {
                for (int z = 0; z < settingsManager.ChunkSizeSetting.Value + 1; z++)
                {
                    if (Random.Next(0, 100) <= Chances[y])
                    {
                        locations.Add(new Location(BlockType.Bedrock,
                            new(bottomY.X + x, bottomY.Y + y, bottomY.Z + z)));
                    }
                }
            }
        }

        Inner = locations.ToArray();
    }
}