using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameController gameController;

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        gameController.GameOver();
    }
}
