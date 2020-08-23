using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 place;
    private Vector3 space;

    void OnMouseDown()
    {
        place = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        space = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(place.x, Input.mousePosition.y, place.z));
    }

    void OnMouseDrag()
    {
        Vector3 cursor = new Vector3(place.x, Input.mousePosition.y, place.z);
        Vector3 cursorPlace = Camera.main.ScreenToWorldPoint(cursor) + space;
        transform.position = cursorPlace;
    }
}
