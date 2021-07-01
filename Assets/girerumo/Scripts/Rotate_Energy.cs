using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Energy : MonoBehaviour
{

    private float speed;
    public float radius_x;
    public float radius_y;
    public GameObject energyaround;
    private float x;
    private float y;
    private float z;
    


    // Start is called before the first frame update
    void Start()
    {
        speed = Random.value*10.0f;
        radius_x = Random.value;
        radius_y = Random.value;
        energyaround = transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        x = radius_x * Mathf.Sin(Time.time * speed);
        y = radius_y * Mathf.Cos(Time.time * speed);
        y = y + energyaround.transform.position.y;
        x = x + energyaround.transform.position.x;
        z = energyaround.transform.position.z;

        transform.position = new Vector3(x, y, z);
        Rotate();

    }

    void Rotate()
    {
        float xd = radius_x * Mathf.Sin(Time.time * speed);
        float yd = radius_y * Mathf.Cos(Time.time * speed);
        
        transform.Rotate(new Vector3(xd, yd, 0));
    }
}
