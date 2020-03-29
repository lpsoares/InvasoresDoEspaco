using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 0.5f;
    private float bound = 9;
    public GameObject bullet;

    public float wait = 0.3f;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        float dh = Input.GetAxis("Horizontal");
        if (( gameObject.transform.position.x > -bound || dh > 0) &&
            ( gameObject.transform.position.x <  bound || dh < 0))
        {
            gameObject.transform.position += Vector3.right * dh * speed;
        }

        timer += Time.deltaTime;
        if (timer > wait && Input.GetButton("Fire1"))
        {
            timer = 0;
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        }

    }
}
