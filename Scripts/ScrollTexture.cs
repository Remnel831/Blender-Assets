using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour {
    
    public float ScrollX = 0.5f;
    public float ScrollY = 0.5f;
    public float RimScrollX = 0.5f;
    public float RimScrollY = 0.5f;
    void Update()
    {
        float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;
        float RimOffsetX = Time.time * RimScrollX;
        float RimOffsetY = Time.time * RimScrollY;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
        GetComponent<Renderer>().material.SetTextureOffset("_rimtexture", new Vector2(RimOffsetX, RimOffsetY));
    }
}
