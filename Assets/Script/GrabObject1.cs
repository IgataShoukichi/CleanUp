using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject1 : MonoBehaviour
{
    BoxCollider BoxCol;

    void Start()
    {
        BoxCol = GetComponent<BoxCollider>();
    }

    void OnMouseDrag()
    {
        if (gameObject.tag != "Box")
        {
            BoxCol.enabled = false;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.position = new Vector3(hit.point.x, (float)((hit.point.y) + 1.5), hit.point.z);
                GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }

    void OnMouseUp()
    {
        if (gameObject.tag != "Box")
        {
            BoxCol.enabled = true;
        }
    }
}