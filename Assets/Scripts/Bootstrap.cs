using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private ScreenController _screenController;
    //[SerializeField] private BaseScreenButton _playButton;
    //[SerializeField] private BaseScreenButton _settings;
    [SerializeField] private List<BaseScreenButton> _screenButtons;

    private void Awake()
    {
        //_playButton.Init(_screenController);
        //_settings.Init(_screenController);

        foreach (var button in _screenButtons) 
        {
            button.Init(_screenController);
        }
    }
}
