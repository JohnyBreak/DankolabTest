
public class PlayButton : BaseMainMenuButton
{
    protected override void OnClick()
    {
        _screenController.ShowPlayScreen();
    }
}
