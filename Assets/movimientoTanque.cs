using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoTanque : MonoBehaviour {

    Rigidbody rb;
    public string numero = "1";
    float ejeHorizontal;
    float ejeVertical;
    public float velocidad;
    public float velocidadRotacion = 30f;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ejeHorizontal = Input.GetAxis("Horizontal" + numero);
        ejeVertical = Input.GetAxis("Vertical" + numero);
        Debug.Log("Vertical:" + ejeVertical + "Horizontal:" + ejeHorizontal);
    }

    private void FixedUpdate()
    {
        Mover();
        Rotar();

    }

    void Rotar()
    {
        float giro = ejeHorizontal * velocidadRotacion * Time.deltaTime;
        Quaternion rotacion = Quaternion.Euler(0f, giro, 0f);
        rb.MoveRotation(transform.rotation * rotacion);
    }

    void Mover()
    {
        Vector3 posicionMovimiento = transform.forward * velocidad * ejeVertical * Time.deltaTime;
        rb.MovePosition(transform.position + posicionMovimiento);
    }

}
