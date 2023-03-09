using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModification : MonoBehaviour
{
    public float rotationValue;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.position, rotationValue);
    }
}
