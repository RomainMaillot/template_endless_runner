using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float RotateSpeed = 1;
    public Vector3 Axe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(Axe, RotateSpeed * Time.deltaTime);
    }
}
