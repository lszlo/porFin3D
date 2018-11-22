using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzCasa : MonoBehaviour {
    Light luz;
    // Use this for initialization
    void Start () {
        luz = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
		if (diaNoche.noche = true)
        {
            luz.intensity = 0f;
        }
        else
        {
            luz.intensity = 1f;
        }
	}
}
