using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoControllerRigidbody : MonoBehaviour
{
    public Vector3 Direction;
    public float Speed;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horVal = Input.GetAxis("Horizontal");

        // Position d'arrivé = position de départ + deplacement
        Vector3 pos = transform.position + (Direction * Speed * Time.deltaTime * horVal);
        rb.MovePosition(pos);
    }
}
