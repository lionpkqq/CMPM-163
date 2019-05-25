using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingFire : MonoBehaviour
{
    private ParticleSystem fire;

    // Start is called before the first frame update
    void Start()
    {
        this.fire = this.GetComponent<ParticleSystem>();
        this.fire.Play();

        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(onOnbeatDetected);
        processor.onSpectrum.AddListener(onSpectrum);
    }

    private void onSpectrum(float[] arg0)
    {
        //this.fire.Emit(1);
    }

    private void onOnbeatDetected()
    {
        this.fire.Emit(1);
    }

    // Update is called once per frame
    void Update()
    {
        //int numPartitions = 1;
        //float[] aveMag = new float[numPartitions];
        //float partitionIndx = 0;
        //int numDisplayedBins = 512 / 2;

        //for (int i = 0; i < numDisplayedBins; i++)
        //{
        //    if (i < numDisplayedBins * (partitionIndx + 1) / numPartitions)
        //    {
        //        aveMag[(int)partitionIndx] += AudioPeer.spectrumData[i] / (512 / numPartitions);
        //    }
        //    else
        //    {
        //        partitionIndx++;
        //        i--;
        //    }
        //}

        //for (int i = 0; i < numPartitions; i++)
        //{
        //    aveMag[i] = (float)0.5 + aveMag[i] * 100;
        //    if (aveMag[i] > 100)
        //    {
        //        aveMag[i] = 100;
        //    }
        //}

        //float mag = aveMag[0];

        //// if mag is greater than some threshold(0.6)
        //// emit particle using emit function
        //if (mag >= 0.6)
        //{
        //    this.fire.Emit(1);
        //}
    }
}
