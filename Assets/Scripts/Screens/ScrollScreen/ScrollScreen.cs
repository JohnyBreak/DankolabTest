using System.Collections.Generic;
using UnityEngine;

public class ScrollScreen : BaseScreen
{
    [SerializeField] private Transform _spawnParent;
    [SerializeField] private ScrollElementFabric _fabric;
    [SerializeField] private int _elementSpawnAmount;

    private List<ScrollElement> _elements;

    private void OnEnable()
    {
        _elements = new List<ScrollElement>(_elementSpawnAmount);
        Spawn();
    }

    private void OnDisable()
    {
        Clear();
    }

    public void Spawn()
    {
        for (int i = 0; i < _elementSpawnAmount; i++)
        {
           var element = _fabric.GetWithParent(_spawnParent);

            element.Init(this);

            _elements.Add(element);
        }
    }

    private void Clear() 
    {
        foreach (var element in _elements) 
        {
            Destroy(element.gameObject);
        }
        _elements.Clear();
    }

    public void OnElementClick(ScrollElement element)
    {
        _elements.Remove(element);
        Destroy(element.gameObject);
    }
}
