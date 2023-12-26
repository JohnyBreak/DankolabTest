using UnityEngine;

public abstract class BaseScreen : MonoBehaviour
{
    public void Show()
    {
        ToggleScreen(true);
    }

    public void Hide()
    {
        ToggleScreen(false);
    }

    private void ToggleScreen(bool active) 
    {
        this.gameObject.SetActive(active);
    }
}
