using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Energy : MonoBehaviour
{

    private float speed;
    private float radius;
    public GameObject energyaround;
    private float x;
    private float y;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        radius = 2.0f;
        energyaround = transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        x = radius * Mathf.Sin(Time.time * speed);
        y = radius * Mathf.Cos(Time.time * speed);
        y = y + energyaround.transform.position.y;
        x = x + energyaround.transform.position.x;
        z = energyaround.transform.position.z;

        transform.position = new Vector3(x, y, z);

    }
}
