using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    { 
        var rotate = this.gameObject;
        transform.RotateAround(rotate.transform.position, Vector3.forward, 20 * Time.deltaTime);
    }
}
