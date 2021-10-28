using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Obstacle : MonoBehaviour
{
    private UnityEvent<ObstacleInteractor, Obstacle> OnObstacleCollision;
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent(out ObstacleInteractor obstacleInteractor))
            OnObstacleCollision.Invoke(obstacleInteractor,this);
    }
}
