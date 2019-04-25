using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//obliga a tener un componente rigid body en el game object
[RequireComponent(typeof(Rigidbody))]
public class Motion : MonoBehaviour
{
    //permite configurar botones de movimiento
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode rigth;

    //limita los posibles valores de la variable, crea slider en la interfaz
    [Range(0.1f,200f)]
    public float movementSpeed = 2;
    //Rigid body encargado de la fisica del objeto
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // llamada antes de dibujar, tiempo variable
    void Update()
    {
       
    }

    //lamada antes de simulacion fisica, tiempo costante
    private void FixedUpdate()
    {
        Vector3 newMotion = rb.velocity;
        if (Input.GetKey(up))
        {
            newMotion.z = movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            newMotion.z = -movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(rigth))
        {
            newMotion.x = movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            newMotion.x = -movementSpeed * Time.deltaTime;
        }

        rb.velocity = newMotion;
    }
}
