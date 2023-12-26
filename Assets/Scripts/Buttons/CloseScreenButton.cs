
using UnityEngine;

public class CloseScreenButton : BaseScreenButton
{
    protected override void OnClick()
    {
        _screenController.CloseScreen();
    }
}
