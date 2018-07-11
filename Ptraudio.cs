using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ptraudio : MonoBehaviour
{
    public AudioSource ptraudio;
    void Update()
    {
        if((Input.GetMouseButtonDown(0)))
        {
            Debug.Log("GG");
            ptraudio.Play();
        }

    }
}