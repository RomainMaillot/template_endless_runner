using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoController : MonoBehaviour
{

    public Vector3 Direction;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horVal = Input.GetAxis("Horizontal");
        transform.Translate(Direction * Speed * Time.deltaTime * horVal);
    }
}
