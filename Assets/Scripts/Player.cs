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

    private Vector3 position;

    void Start(){
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
     
        position += Vector3.right * Input.GetAxis("Horizontal") * speed;

        if(Input.GetAxis("Mouse X") != 0) {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.x = worldPosition.x;
        }

        if (position.x < -bound) {            
            position.x = -bound;
        }
        else if (position.x > bound) {            
            position.x = bound;
        }

        transform.position = position;

        timer += Time.deltaTime;
        if (timer > wait && Input.GetButton("Fire1"))
        {
            timer = 0;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }

    }
}
