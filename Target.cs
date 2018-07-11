using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Target : MonoBehaviour {

    public Transform flyspeed;
    public float speed = 0.08f;
    
    // Update is called once per frame
    void Start()
    {
        
    }
    void Update ()
    {
        flyspeed.Translate(Vector3.up * speed);
        if(transform.position.y>5.5)
        {
            Destroy(gameObject);
           
        }
        
    }
    
}
