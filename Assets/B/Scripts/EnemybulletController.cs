using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemybulletController : MonoBehaviour
{
    public float bullet_speed;
    void Update(){
           
          transform.Translate (0, -bullet_speed, 0);
        
          if (transform.position.y < -7f) {
                
                Destroy (gameObject);

          }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Invoke("ChangeSceneToEnd", 0.5f);
            
        }
    }

    void ChangeSceneToEnd()
    {
        
        SceneManager.LoadScene("lyn_EndScecne");
    }
}
