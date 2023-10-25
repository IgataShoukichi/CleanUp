using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] Transform follow;
    [SerializeField] float mouseSensitivity = 1;
    float yaw, pitch;

    private void Start()
    {
        transform.eulerAngles = new Vector3(20, -45, 0);
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.position = follow.position;
            yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
            pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;

            yaw = Mathf.Clamp(yaw, -90, 0);
            pitch = Mathf.Clamp(pitch, -45, 90);

            transform.eulerAngles = new Vector3(pitch, yaw, 0);
        }
    }
}
