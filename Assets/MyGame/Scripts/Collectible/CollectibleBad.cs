using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleBad : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent " + collision.gameObject.name);
        Destroy(gameObject);

        if (collision.gameObject.name == "Shark")
        {
            ScoreManager.localScore -= 20;
            Debug.Log(ScoreManager.localScore);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");
    }
}

