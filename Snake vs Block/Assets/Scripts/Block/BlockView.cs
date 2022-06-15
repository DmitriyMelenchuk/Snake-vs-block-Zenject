using TMPro;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(Block))]
public class BlockView : MonoBehaviour
{
    private Block _block;
    [SerializeField] private TMP_Text _view;


    private void Awake()
    {
        _block = GetComponent<Block>();
    }

    private void OnEnable()
    {
        _block.FillingUpdated += OnFillingUpdate;
    }

    private void OnDisable()
    {
        _block.FillingUpdated -= OnFillingUpdate;
    }

    private void OnFillingUpdate(int leftToFill)
    {
        _view.text = leftToFill.ToString();
    }
}
