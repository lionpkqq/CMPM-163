using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.01f, this.transform.position.z);
        }

        if (Input.GetKeyDown("s"))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.01f, this.transform.position.z);
        }
    }
}
