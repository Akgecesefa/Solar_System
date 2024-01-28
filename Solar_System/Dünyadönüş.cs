using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dünyadönüş : MonoBehaviour
{
    private Vector3 vect3;
    public Vector3 hiz;
    void Start()
    {
        vect3 = new Vector3(0, 23.4f, 23.4f);
        hiz = new Vector3(0, -0.34f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(hiz);
    }
}
