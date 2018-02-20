using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{

    public Vector2 offset;
    public float smooth;
    public MeshRenderer meshRenderer;


    //public Material mat;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += Time.deltaTime * smooth;

        MaterialPropertyBlock block = new MaterialPropertyBlock();

        meshRenderer.GetPropertyBlock(block);

        block.SetVector("_MainTex_ST", new Vector4(1f, 1f, offset.x, offset.y));

        meshRenderer.SetPropertyBlock(block);
    }
}
