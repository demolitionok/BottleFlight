using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleObstacle : Obstacle
{
    private void EndGame()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    private void Awake()
    {
        OnObstacleCollision.AddListener((a, b) => EndGame());
    }
}
