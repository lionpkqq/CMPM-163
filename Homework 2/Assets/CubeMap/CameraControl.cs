using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Update is called once per frame
    void Update()
    {
        this.yaw += 5.0f * Input.GetAxis("Mouse X");
        this.pitch -= 5.0f * Input.GetAxis("Mouse Y");

        this.transform.eulerAngles = new Vector3(this.pitch, this.yaw, 0.0f);
    }
}
