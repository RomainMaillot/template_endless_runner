using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Variable valide durant la durée de vie de l'élèment dans le jeux
    public int Counter;
    public float DecimalValue = 0.6f;
    public string TextValue = "Hello World";
    public bool BoolValue = true;

    // Start is called before the first frame update
    void Start()
    {
        // variable valide que dans la fonction
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("La valeur est: " + Counter);
        Counter++;
    }
}
