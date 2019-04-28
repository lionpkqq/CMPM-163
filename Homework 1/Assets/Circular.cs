using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circular : MonoBehaviour
{
    public float time = 0;
    private float radius = 2.0f;
    public GameObject center;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        float x = Mathf.Cos(this.time) * this.radius + this.center.transform.position.x;
        float y = this.center.transform.position.y;
        float z = Mathf.Sin(this.time) * this.radius + this.center.transform.position.z;

        this.transform.position = new Vector3(x, y, z);
    }
}
