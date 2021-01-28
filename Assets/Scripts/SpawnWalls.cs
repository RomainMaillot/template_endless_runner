using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
    public GameObject[] ObjectPrefab;
    public float SpawnInterval = 1;

    private float AccumulateurTemps = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AccumulateurTemps += Time.deltaTime;
        if(AccumulateurTemps > SpawnInterval) {
            Spawn();
            AccumulateurTemps = 0;
        }
    }

    public void Spawn()
    {
        int index = Random.Range(0, ObjectPrefab.Length);
        GameObject copy = Instantiate(ObjectPrefab[index]);

        Vector3 pos = transform.position;

        pos.x = pos.x + Random.Range(-1, 2);

        copy.transform.position = pos;
    }
}
