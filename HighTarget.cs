using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighTarget : MonoBehaviour {

    public Transform flyspeed;
    // Update is called once per frame
    void Update()
    {
        flyspeed.Translate(Vector3.up * 0.1f);
        if (transform.position.y > 5.5)
        {
            Destroy(gameObject);
        }
    }
}
