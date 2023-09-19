using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource win;
    public GameObject UiObject;

    void Start()
    {
        UiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        win.Play();
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
    }
}
