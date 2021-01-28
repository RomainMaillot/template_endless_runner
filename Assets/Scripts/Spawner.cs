using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Debug.Log("Spawn");

        GameObject copy = Instantiate(ObjectPrefab);

        copy.transform.position = new Vector3(2, 2 ,2);

        Renderer r = copy.GetComponent<Renderer>();
        r.material.color = new Color(1.0f, 0.0f, 1.0f);

        Rigidbody rb = copy.AddComponent<Rigidbody>();

        Destroy(copy, 2);
    }
}
