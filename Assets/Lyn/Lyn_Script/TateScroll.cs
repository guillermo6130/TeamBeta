using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TateScroll : MonoBehaviour
{
    //スクロールスピード
    [SerializeField] float speed = 1;

    void Update()
    {
        //下方向にスクロール
        transform.position -= new Vector3(0, Time.deltaTime * speed);

        //Yが-12.9まで来れば、25.86まで移動する
        if (transform.position.y <= -12.9f)
        {
            transform.position = new Vector2(0,25.86f);
        }
    }
}