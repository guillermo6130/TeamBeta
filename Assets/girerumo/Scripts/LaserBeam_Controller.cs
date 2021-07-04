using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam_Controller : MonoBehaviour
{
    private bool Laser_bool = false;
    LineRenderer Laser_lineRenderer;
    float maxDistance = 100;
    float width_of_laser;
    public List<GameObject> currentHitObjects = new List<GameObject>();
    private float currentHitDistance;
    private Vector3 origin;
    private Vector3 direction;
    private GameObject parentVec;
    [SerializeField] private float view_width;
    [SerializeField] private AnimationCurve curveoflaser;
    private float offsetparent_x;
    private float offsetparent_y_0;
    private float offsetparent_y_1;
    private GameObject score;

    public CameraShake shake;

    // Start is called before the first frame update
    void Start()
    {
        view_width = 18f;

        Laser_lineRenderer = GetComponent<LineRenderer>();
        /*width_of_laser = Laser_lineRenderer.endWidth;*/
        width_of_laser = 0;
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
        width_of_laser=calLaser_width();
        origin = Laser_lineRenderer.GetPosition(0);
        RaycastHit[] all_hit=Physics.SphereCastAll(origin,width_of_laser/2,transform.up,maxDistance);
        foreach(RaycastHit hit_test in all_hit)
        {
            currentHitObjects.Add(hit_test.transform.gameObject);
            currentHitDistance = hit_test.distance;
        }
        change_laser_position();
        /*Laser_stop();*/
        
    }

    void Laser_on_off()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Laser_lineRenderer.widthCurve = curveoflaser;
            Laser_lineRenderer.widthMultiplier=calLaser_width();
            Laser_bool = true;
            shake.Shake(0.2f, 0.1f);
            Invoke("Laser_stop1", 0.2f);
            Invoke("Delete_Object", 0f);
        }
        
        
        
        Laser_lineRenderer.enabled = Laser_bool;
    }

    void Laser_stop()
    {
        if (Input.GetKeyUp(KeyCode.Space) && Laser_bool == false)
        {
            setPlayer_amountzero();
            ScoreManager player = parentVec.GetComponent<ScoreManager>();
            Player_Energy playerE = parentVec.GetComponent<Player_Energy>();

            player.beamed(playerE.getEnergy());

        }
        changeLaser_width();
    }

    void Laser_stop1()
    {
        
         setPlayer_amountzero();
         ScoreManager player = parentVec.GetComponent<ScoreManager>();
        Player_Energy playerE = parentVec.GetComponent<Player_Energy>();
        player.beamed(playerE.getEnergy());
        Laser_bool = false;



        changeLaser_width();
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

    void changeLaser_width()
    {
        Player_Energy player = parentVec.GetComponent<Player_Energy>();
        Laser_lineRenderer.startWidth=0;
        Laser_lineRenderer.endWidth = player.getEnergy() * 0.01f * view_width;
        width_of_laser= player.getEnergy() * 0.01f * view_width; 
        /*Debug.Log(player.getEnergy() * 0.01f * view_width);*/
    }

    private void OnDrawGizmosSelected()/*デバッグ用*/
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(origin + direction * currentHitDistance, width_of_laser/2);
    }

    float calLaser_width()
    {
        Player_Energy player = parentVec.GetComponent<Player_Energy>();
       
        return player.getEnergy() * 0.01f * view_width;
        
    }

    void setPlayer_amountzero()
    {
        Player_Energy player = parentVec.GetComponent<Player_Energy>();

        player.setEnergy(0);
    }

    int getPlayer_amount()
    {
        Player_Energy player = parentVec.GetComponent<Player_Energy>();
        return player.getEnergy();
    }

    void Delete_Object()
    {
        if (getPlayer_amount() != 0 && Laser_bool == true)
        {
            foreach (GameObject hitObject in currentHitObjects)
            {
                if (hitObject.tag != "Player")
                {
                    

                    //Debug.Log(hitObject.tag);
                    if (hitObject.tag == "Energy")
                    {
                        ScoreManager player = parentVec.GetComponent<ScoreManager>();
                        player.energy_destroyed(currentHitObjects.Count);
                        SE_Destroyed se = hitObject.GetComponent<SE_Destroyed>();
                        if (se != null)
                        {
                            se.playSound_destroyed();

                        }
                    }
                    if (hitObject.tag == "Enemy")
                    {
                        SE_Destroyed se = hitObject.GetComponent<SE_Destroyed>();
                        if (se != null)
                        {
                            se.playSound_destroyed();

                        }
                        ScoreManager player = parentVec.GetComponent<ScoreManager>();
                        player.enemy_destroyed(currentHitObjects.Count);
                    }
                    Destroy(hitObject, 0.3f);
                }
                
                
            }
        }
    }


    
    
    
}
