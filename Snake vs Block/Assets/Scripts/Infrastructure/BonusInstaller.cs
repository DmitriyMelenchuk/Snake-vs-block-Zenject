using UnityEngine;
using Zenject;

public class BonusInstaller : MonoInstaller
{
    public BonusSpawnPoint[] startSpawnBonus;
    public Bonus bonusPrefab;
    public override void InstallBindings()
    {
        Container.Bind<Bonus>().FromInstance(bonusPrefab).AsSingle().NonLazy();
    }
}