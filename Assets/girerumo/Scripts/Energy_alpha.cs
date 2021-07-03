using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_alpha : MonoBehaviour
{
    private GameObject rootObject;
    Color color;
    public Material Energy_100;
    private Material less_then100;
    // Start is called before the first frame update
    void Start()
    {
        rootObject = transform.root.gameObject;
        color = this.GetComponent<Renderer>().material.color;
        less_then100 = this.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Player_Energy player = rootObject.GetComponent<Player_Energy>();
        int a = player.getEnergy();
        if (a > 100)
        {
            a = 100;
        }
        setAlpha(a * 0.01f);
    }

    void setAlpha(float alpha)
    {
        if (alpha == 1)
        {
            this.gameObject.GetComponent<Renderer>().material = Energy_100;
        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material = less_then100;
            color.a = alpha;
            this.gameObject.GetComponent<Renderer>().material.color = color;
        }
    }

    
}
