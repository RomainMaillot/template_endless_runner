using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeTextureOffset : MonoBehaviour
{
    public float Multiplicateur = 1;
    Renderer rend;
    GlobalSpeed Global;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        Global = GameObject.FindObjectOfType<GlobalSpeed>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = rend.material.GetTextureOffset("_MainTex");
        offset.y += Global.Speed * Time.deltaTime;
        rend.material.SetTextureOffset("_MainTex", offset);
    }
}
