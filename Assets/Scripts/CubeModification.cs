using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModification : MonoBehaviour
{
    public float rotationValue = 0.5f;
    public float colorChangeDuration = 1.5f;
    public Color firstColor = Color.red;
    public Color secondColor = Color.green;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.position, rotationValue);

        float lerp = Mathf.PingPong(Time.time, colorChangeDuration) / colorChangeDuration;
        rend.material.color = Color.Lerp(firstColor, secondColor, lerp);
    }
}
