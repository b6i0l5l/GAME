using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour {

	public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
