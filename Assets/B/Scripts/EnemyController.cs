using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

public GameObject Enemy_1_Bullet;
    public float bullet_rate;
    public float moveSpeed;
    public float rotSpeed;

    // Start is called before the first frame update
    void Start() {
          this.moveSpeed = 0.05f + 0.07f * Random.value;
          this.rotSpeed = 4f + 3f * Random.value;
          InvokeRepeating ("EnemyShot", bullet_rate, bullet_rate);
        
    }

    // Update is called once per frame
    void Update() {

          transform.Translate( moveSpeed, 0, 0, Space.World);

          transform.Rotate(0, rotSpeed, 0 );
          
          if ((transform.position.x > 8f) || (transform.position.x < -8f)) {
                 
                 this.moveSpeed = -moveSpeed;
          }
    }
    
    void EnemyShot () {

           Instantiate (Enemy_1_Bullet, transform.position, Quaternion.identity);
    }
}
