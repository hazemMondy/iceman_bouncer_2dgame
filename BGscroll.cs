using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll : MonoBehaviour
{
    public float scrollSpeed =0.3f;
    private MeshRenderer meshrender;
    // Start is called before the first frame update
    void Awake()
    {
        meshrender = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
    }
    void scroll()
    {
        Vector2 offset = meshrender.sharedMaterial.GetTextureOffset("_MainTex");
            offset.y +=Time.deltaTime*scrollSpeed;

        meshrender.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}