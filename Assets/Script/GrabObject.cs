using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    SphereCollider sphereCol;

    void Start()
    {
        sphereCol = GetComponent<SphereCollider>();
    }

    void OnMouseDrag()
    {
        sphereCol.enabled = false;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            transform.position = new Vector3(hit.point.x, (float)((hit.point.y) + 0.8), hit.point.z);
        }
    }

    void OnMouseUp()
    {
        sphereCol.enabled = true;
    }
}