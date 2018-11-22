using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diaNoche : MonoBehaviour {
    public float velocidadTiempo = 1f;
    public static bool noche = false;
    Light luz;
    float angulo;
	// Use this for initialization
	void Start ()
    {
        luz = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(velocidadTiempo, 0f, 0f);
        angulo = Mathf.Round(transform.eulerAngles.x);
        if (angulo > 10 && angulo < 100)
        {
            noche = false;
            luz.intensity = 1f;
        }
        else 
        {
            noche = true;
            luz.intensity = 0f;

        }

	}
}
