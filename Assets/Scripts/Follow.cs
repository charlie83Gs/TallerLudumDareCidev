using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode] //nos permite mirar la ejecucion de un script cuando no esta en modo edicion
public class Follow : MonoBehaviour
{
    public Transform target;
    private Vector3 originalPos;
    private Vector3 originalDifference;
    public bool followX = false;
    public bool followY = false;
    public bool followZ = false;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        originalDifference =  target.transform.position - originalPos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.transform.position;
        Vector3 newPosition = new Vector3(originalPos.x,originalPos.y,originalPos.z);
        if (followX) newPosition.x = targetPos.x - originalDifference.x;
        if (followY) newPosition.y = targetPos.y - originalDifference.y;
        if (followZ) newPosition.z = targetPos.z - originalDifference.z;

        transform.position = newPosition;
    }
}
