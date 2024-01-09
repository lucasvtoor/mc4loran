using System.Numerics;
using Managers;
using Settings;

namespace World;

public abstract class OakTreeGenerator(SettingsManager settingsManager, Vector3 spawnPoint): TreeGenerator(settingsManager,spawnPoint);