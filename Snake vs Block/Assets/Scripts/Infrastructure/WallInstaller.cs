using UnityEngine;
using Zenject;

public class WallInstaller : MonoInstaller
{
    public WallSpawnPoint[] wallSpawnPoint;
    public Wall wallPrefab;
    public override void InstallBindings()
    {
        Container.Bind<Wall>().FromInstance(wallPrefab).AsSingle().NonLazy();
    }
}