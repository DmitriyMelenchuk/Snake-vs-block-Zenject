using TMPro;
using UnityEngine;
using Zenject;

public class BlockInstaller : MonoInstaller
{
    public Block blockPrefab;
    public BlockSpawnPoint[] blockSpawnPoint;
    public Color[] color;
   
    public override void InstallBindings()
    {
        Container.Bind<Block>().FromInstance(blockPrefab).AsSingle().NonLazy();
    }        
}
