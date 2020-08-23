using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRed : MonoBehaviour
{
    void Start()
    {
        GameObject redblock = this.gameObject;
        var colorRender = redblock.GetComponent<Renderer>();
        colorRender.material.SetColor("_Color", Color.red);
    }
}
