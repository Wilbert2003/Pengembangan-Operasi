using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float speed1;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
        transform.position = new Vector3(1, 1, 1);
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        if (transform.position.x == 1)
        {
            speed = 1.5f;
        }
        if (transform.position.x == 55)
        {
            speed = 3;
        }
        if (transform.position.x == 110)
        {
            speed = 4;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            speed1 = 15;
            transform.Translate(0, speed1 * Time.deltaTime, 0);
        }
        if (transform.position.y > 1)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        else { y = 1; }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A ))
        {
            speed1 = 15;
            transform.Translate(-speed1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            speed1 = 15;
            transform.Translate(speed1 * Time.deltaTime, 0, 0);
        }
        
    }
}
