using TMPro;
using UnityEngine;

[RequireComponent(typeof(Snake))]
public class SnakeSizeView : MonoBehaviour
{
    [SerializeField] private TMP_Text _view;

    private Snake _snake;

    private void Awake()
    {
        _snake = GetComponent<Snake>();
    }

    private void OnEnable()
    {
        _snake.SizeUpdate += OnSizeUpdate;
    }

    private void OnDestroy()
    {
        _snake.SizeUpdate -= OnSizeUpdate;
    }

    private void OnSizeUpdate(int size)
    {
        _view.text = size.ToString();
    }
}
