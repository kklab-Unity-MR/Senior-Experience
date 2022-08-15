using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class collar : MonoBehaviour
{
    public MeshRenderer rend;
    public Material[] mats;
    public int cur;

    // Start is called before the first frame update
    void Start()
    {
        if (rend == null)
        {
            rend = GetComponent<MeshRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Increment()
    {
        if (mats != null && mats.Length > 0)
        {
            cur = (cur + 1) % mats.Length;
            if (rend != null)
            {
                rend.material = mats[cur];
            }
        }
    }

    /// <summary>
    /// Decrements to the previous material in the input list of materials and applies it to the renderer.
    /// </summary>
    public void Decrement()
    {
        if (mats != null && mats.Length > 0)
        {
            cur = (cur - 1 + mats.Length) % mats.Length;
            if (rend != null)
            {
                rend.material = mats[cur];
            }
        }
    }

    /// <summary>
    /// Sets a random color on the renderer's material.
    /// </summary>
    public void RandomColor()
    {
        rend.material.color = UnityEngine.Random.ColorHSV();
    }



    public void Z_CollarChange()
    {
        GetComponent<Renderer>().material.color = Color.red;

        /*
       System.Random r1 = new System.Random();
       num = r1.Next(0, 4);

        switch (num)
        {
            case 0:
                GetComponent<Renderer>().material.color = Color.white;
                break;
            case 1:
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }
        */
    }
}
