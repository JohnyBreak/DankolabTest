using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ScrollElement : MonoBehaviour
{
    [SerializeField] private Button _button;
    private ScrollScreen _screen;

    public void Init(ScrollScreen screen) 
    {
        _screen = screen;

        if(_button == null) _button = GetComponent<Button>();

        _button.onClick.AddListener(OnClick);
    }

    

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick() 
    {
        _screen.OnElementClick(this);
    }
}
