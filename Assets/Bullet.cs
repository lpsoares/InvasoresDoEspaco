using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.up * speed;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Alien")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    
}
