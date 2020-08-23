using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject redblock = this.gameObject;
        var colorRender = redblock.GetComponent<Renderer>();
        colorRender.material.SetColor("_Color", Color.blue);
    }
}
