using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float bullet_speed;
    void Update() {
           transform.Translate (0, bullet_speed, 0);
           
           if (transform.position.y > 10) {
                   Destroy (gameObject);
           }
    }
  
    private void OnTriggerEnter2D(Collider2D collision) {
       
           Destroy (collision.gameObject);

           Destroy (gameObject);
    }
}
