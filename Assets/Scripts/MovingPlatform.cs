using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] positions;
    private int targetPosIndex = 0;
    public float movementSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //verifica si esta suficientemente cerca del objeto
        Transform target = positions[targetPosIndex];
        if (Vector3.Distance(transform.position, target.position) < 0.01) {
            //cambio de direccion
            targetPosIndex = (targetPosIndex + 1) % positions.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
    }

    
}
