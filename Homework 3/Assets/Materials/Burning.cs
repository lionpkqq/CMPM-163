using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burning : MonoBehaviour
{
    private ParticleSystem fire;
    private float size;

    // Start is called before the first frame update
    void Start()
    {
        this.fire = this.GetComponent<ParticleSystem>();
        this.fire.Play();
        this.size = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.size <= 10)
        {
            this.size *= 1.01f;
        }
        var main = this.fire.main;
        main.startSize = this.size;
    }
}
