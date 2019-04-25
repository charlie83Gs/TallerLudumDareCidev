using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//transfiere el movimiento de una plataforma
public class CarryAlongMovingPlatform : MonoBehaviour
{
    private GameObject target = null;
    private Vector3 offset;

    private void OnTriggerStay(Collider other)
    {

            target = other.gameObject;
            offset = target.transform.position - transform.position;

    }

    private void OnTriggerExit(Collider other)
    {
            target = null;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            target.transform.position = transform.position + offset;
        }
    }
}
