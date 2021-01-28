using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 Direction;

    GlobalSpeed Global;
    
    // Start is called before the first frame update
    void Start()
    {
        Global = GameObject.FindObjectOfType<GlobalSpeed>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * Global.Speed * Time.deltaTime);
    }
}
