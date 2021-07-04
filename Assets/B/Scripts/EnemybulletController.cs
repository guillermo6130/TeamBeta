using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemybulletController : MonoBehaviour
{
    
    void Update(){
           
          transform.Translate (0, -0.1f, 0);
        
          if (transform.position.y < -7f) {
                
                Destroy (gameObject);

          }
    }
}
