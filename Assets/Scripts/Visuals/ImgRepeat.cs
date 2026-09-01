using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImgRepeat : MonoBehaviour
{
    private Renderer BGimg;

    public float animSpeed = 0.5f;

    private void Awake()
    {
        BGimg = GetComponent<Renderer>();

    }

    private void Update()
    {   
        BGimg.material.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);
        //BGimg.sharedMaterial.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);
    }
}
