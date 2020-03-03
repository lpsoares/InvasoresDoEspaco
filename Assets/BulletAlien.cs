using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAlien : MonoBehaviour
{

    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.down * speed;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.tag);
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        else if (collision.tag == "Base")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    
}
