using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam_Controller : MonoBehaviour
{
    private bool Laser_bool = true;
    LineRenderer Laser_lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Laser_lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Laser_on_off();   
    }
    void Laser_on_off()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Laser_bool = true;
        }
        else
        {
            Laser_bool = false;
        }
        Laser_lineRenderer.enabled = Laser_bool;
    }
}
