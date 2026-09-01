using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class BGRepeat : MonoBehaviour
{
    private Renderer BGimg;
    private MeshRenderer bgMesh;
    public float animSpeed = 0.5f;

    private void Awake()
    {
        bgMesh = GetComponent<MeshRenderer>();
        BGimg = GetComponent<Renderer>();

    }

    private void Update()
    {
        
        bgMesh.material.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);
        BGimg.sharedMaterial.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);;
    }

}
