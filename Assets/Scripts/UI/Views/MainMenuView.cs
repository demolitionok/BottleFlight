using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MainMenuView : View
{
    [Inject]
    private IViewManager _viewManager;
    
    private Button playButton;
    
    public override void Init()
    {
        playButton.onClick.AddListener(() => _viewManager.ShowView<HUDView>());
    }
}
