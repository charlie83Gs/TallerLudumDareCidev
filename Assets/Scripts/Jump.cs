using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//obliga a tener un componente rigid body en el game object
[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    public KeyCode jumpButton;
    [Range(5f,40)]
    public float jumpForce = 30;
    [Range(2f, 20f)]
    public float fallSpeed = 2;
    //bandera para verificar si puede saltar
    private bool canjunmp = true;//se puede usar un int para contar los saltos y permitir multiples saltos

    //Rigid body encargado de la fisica del objeto
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void FixedUpdate()
    {
        if (canjunmp && Input.GetKeyDown(jumpButton)) {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.y);
            canjunmp = false;

        } else if (!canjunmp && !Input.GetKey(jumpButton)) {
            rb.velocity = new Vector3(rb.velocity.x, -fallSpeed, rb.velocity.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor") {
            canjunmp = true;

        }
    }

}
