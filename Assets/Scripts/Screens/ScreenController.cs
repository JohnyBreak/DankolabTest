using UnityEngine;

public class ScreenController : MonoBehaviour
{
    [SerializeField] private BaseScreen _settings;
    [SerializeField] private BaseScreen _playScreen;
    
    private BaseScreen _activeScreen;

    public void ShowSettingsScreen()
    {
        ShowScreen(_settings);
    }

    public void ShowPlayScreen()
    {
        ShowScreen(_playScreen);
    }

    private void ShowScreen(BaseScreen screenToShow) 
    {
        if(_activeScreen != null) _activeScreen.Hide();
        _activeScreen = screenToShow;
        _activeScreen.Show();
    }

    public void CloseScreen() 
    {
        if (_activeScreen != null) _activeScreen.Hide();

        _activeScreen = null;
    }
}
