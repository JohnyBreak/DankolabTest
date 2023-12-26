using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class BaseScreenButton : MonoBehaviour
{
    [SerializeField] protected Button _button;

    protected ScreenController _screenController;

    public void Init(ScreenController screenController)
    {
        _screenController = screenController;
        _button.onClick.AddListener(OnClick);
    }

    private void OnValidate()
    {
        //if (_button == null) 
            _button = GetComponent<Button>();
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    protected abstract void OnClick();
}
