using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tire : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ColliderBottom")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "shark")
        {
            Destroy(gameObject);
        }
    }
}

