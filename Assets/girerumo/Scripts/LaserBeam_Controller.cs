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
    private GameObject parentVec;

    private float offsetparent_x;
    private float offsetparent_y_0;
    private float offsetparent_y_1;

    // Start is called before the first frame update
    void Start()
    {
        Laser_lineRenderer = GetComponent<LineRenderer>();
        width_of_laser = Laser_lineRenderer.endWidth;
        origin = Laser_lineRenderer.GetPosition(0);
        direction = transform.up;
        parentVec = transform.root.gameObject;
        offsetparent_x = parentVec.transform.position.x;
        offsetparent_y_0 = -parentVec.transform.position.y + origin.y;
        offsetparent_y_1 = -parentVec.transform.position.y + Laser_lineRenderer.GetPosition(1).y;
    }

    // Update is called once per frame
    void Update()
    {
        Laser_on_off();
        currentHitObjects.Clear();
        currentHitDistance = maxDistance;
        origin = Laser_lineRenderer.GetPosition(0);
        RaycastHit[] all_hit=Physics.SphereCastAll(origin,width_of_laser/2,transform.up,maxDistance);
        foreach(RaycastHit hit_test in all_hit)
        {
            currentHitObjects.Add(hit_test.transform.gameObject);
            currentHitDistance = hit_test.distance;
        }
        change_laser_position();
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

    void change_laser_position()
    {
        float x = parentVec.transform.position.x + offsetparent_x;
        float y0 = parentVec.transform.position.y + offsetparent_y_0;
        float y1 = parentVec.transform.position.y + offsetparent_y_1;



        Laser_lineRenderer.SetPosition(0, (new Vector3(x, y0, 0)));
        Laser_lineRenderer.SetPosition(1, (new Vector3(x, y1, 0)));
        Laser_lineRenderer.SetPosition(2, (new Vector3(x, 100, 0)));
    }

    private void OnDrawGizmosSelected()/*デバッグ用*/
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(origin + direction * currentHitDistance, width_of_laser/2);
    }

}
