using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerWithTrigger : MonoBehaviour
{
    public GameObject[] ObjectPrefab;
    public int Min = -1;
    public int Max = 2;

    public void Spawn()
    {
        int index = Random.Range(0, ObjectPrefab.Length);
        GameObject copy = Instantiate(ObjectPrefab[index]);

        Vector3 pos = transform.position;

        pos.x = pos.x + Random.Range(Min, Max);

        copy.transform.position = pos;
    }
}
