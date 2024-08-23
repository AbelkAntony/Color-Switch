using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
