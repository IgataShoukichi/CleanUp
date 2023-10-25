using UnityEngine;

public class GetClickedGameObject : MonoBehaviour
{
    GameObject clickObject;
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickObject = null;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit) && !hit.collider.gameObject.CompareTag("room"))
            {
                clickObject = hit.collider.gameObject;
            }
        }
    }
}