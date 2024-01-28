using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class eksen : MonoBehaviour
{
    public Transform Sun;
    public float rotationSpeed = 7.2f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(Sun.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
