using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

public class MainMenuView : View
{
    [SerializeField]
    private Button playButton;
    
    public override void Init()
    {
        playButton.onClick.AddListener(
        () => {
                SceneManager.LoadScene("Scenes/GameScene");
            }
        );
    }
}
