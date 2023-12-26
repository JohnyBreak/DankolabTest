using UnityEngine;

[CreateAssetMenu(fileName = "ScrollElementFabric", menuName = "Fabrics/ScrollElementFabric")]
public class ScrollElementFabric : ScriptableObject
{
    [SerializeField] private ScrollElement _elementPrefab;

    public ScrollElement Get() 
    {
        return Instantiate(_elementPrefab);
    }

    public ScrollElement GetWithParent(Transform parent)
    {
        return Instantiate(_elementPrefab, parent);
    }
}
