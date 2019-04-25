using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMotion : MonoBehaviour
{
    public Vector3 motionSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //se multilica por el tiempo asi si varia el framerate nop varia la velocidad
        transform.position += motionSpeed * Time.deltaTime;
    }
}
