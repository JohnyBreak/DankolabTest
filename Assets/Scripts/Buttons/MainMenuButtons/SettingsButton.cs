
public class SettingsButton : BaseMainMenuButton
{
    protected override void OnClick()
    {
        _screenController.ShowSettingsScreen();
    }
}
