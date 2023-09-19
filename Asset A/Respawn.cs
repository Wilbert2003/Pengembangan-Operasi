using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall")
        {
            transform.position = new Vector3(1, 1, 1);
        }
        if (other.gameObject.tag == "checkpoint")
        {
            transform.position = new Vector3(1, 1, 27.5f);
        }
        if (other.gameObject.tag == "victory")
        {
            transform.position = new Vector3(55, 1, 1);
        }

        if (other.gameObject.tag == "wall1")
        {
            transform.position = new Vector3(55, 1, 1);
        }
        if (other.gameObject.tag == "checkpoint1")
        {
            transform.position = new Vector3(55, 5, 44);
        }
        if (other.gameObject.tag == "victory1")
        {
            transform.position = new Vector3(110, 1, 1);
        }

        if (other.gameObject.tag == "wall2")
        {
            transform.position = new Vector3(110, 1, 1);
        }
        if (other.gameObject.tag == "checkpoint2")
        {
            transform.position = new Vector3(113, 3, 44);
        }
    }
    
    
}
