using TMPro;
using UnityEngine;
using Zenject;

public class SnakeInstaller : MonoInstaller
{   
    public Transform startPoint;
    public GameObject snakePrefab;
    
    public override void InstallBindings()
    {
        BindSnake(); 
    }

    private void BindSnake()
    {
        SnakeHead snakeHead = Container.
        InstantiatePrefabForComponent<SnakeHead>(snakePrefab, startPoint.position, Quaternion.identity, null);
        Container.Bind<SnakeHead>().FromInstance(snakeHead).AsSingle().NonLazy();
    } 
}