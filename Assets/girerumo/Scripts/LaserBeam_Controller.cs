using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam_Controller : MonoBehaviour
{
    private bool Laser_bool = true;
    LineRenderer Laser_lineRenderer;
    float maxDistance = 100;
    float width_of_laser;
    public List<GameObject> currentHitObjects = new List<GameObject>();
    private float currentHitDistance;
    private Vector3 origin;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        Laser_lineRenderer = GetComponent<LineRenderer>();
        width_of_laser = Laser_lineRenderer.endWidth;
        origin = Laser_lineRenderer.GetPosition(0);
        direction = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        Laser_on_off();
        currentHitObjects.Clear();
        currentHitDistance = maxDistance;
        RaycastHit[] all_hit=Physics.SphereCastAll(origin,width_of_laser,transform.up,maxDistance);
        foreach(RaycastHit hit_test in all_hit)
        {
            currentHitObjects.Add(hit_test.transform.gameObject);
            currentHitDistance = hit_test.distance;
        }

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

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(origin + direction * currentHitDistance, width_of_laser);
    }

}
