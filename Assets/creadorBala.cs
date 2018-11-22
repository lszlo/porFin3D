using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creadorBala : MonoBehaviour {
    public GameObject bala;
    public Transform entrega;
    public float fuerza = 15f;
    Rigidbody rb;
    public string numero = "1";
    float disparo1;
    bool disparo = false;
    float proximoDisparo;
    public float cadenciaDisparo = 1;
   
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        disparo1 = Input.GetAxis("Fire" + numero);
        if (disparo1 > 0 && proximoDisparo<Time.time)
        {
            disparo = true;
            proximoDisparo = Time.time + cadenciaDisparo;
        }
            
    }

    void FixedUpdate ()
    {


        if (disparo)
        {
            dispararBala();
            disparo = false;
        }
      
    }

    void dispararBala()
    {
       
        GameObject balaNueva;
        Rigidbody rbBalaNueva;
        
        balaNueva = Instantiate(bala, entrega.position, entrega.rotation);
        rbBalaNueva = balaNueva.GetComponent<Rigidbody>();
        rbBalaNueva.AddForce(balaNueva.transform.forward * fuerza);

    }
}
