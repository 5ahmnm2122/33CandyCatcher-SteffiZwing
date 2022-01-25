using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad1 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ColliderBottom")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Bear")
        {
            Destroy(gameObject);
        }
    }
}

