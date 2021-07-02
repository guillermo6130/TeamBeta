using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           //追加
using UnityEngine.EventSystems; //追加

public class button_select_src : MonoBehaviour
{
    [SerializeField] EventSystem eventSystem;　//イベントシステムをセット
    bool select_f = false;                    //ボタンが選択されたら true
    public GameObject yajirusi;               //対応する矢印のイメージをセット
    GameObject selected0bj;



    // Update is called once per frame
    void Update()
    {
        if (select_f == false)
        {
            try
            {
                selected0bj = eventSystem.currentSelectedGameObject.gameObject;
                //もしボタンが選択されていたら
                if (this.gameObject == selected0bj)
                {
                    //矢印表示
                    yajirusi.SetActive(true);
                    select_f = true;
                }
            }
            catch
            {
                //何も選択されていない
            }
        }
        else
        {
            try
            {
                selected0bj = eventSystem.currentSelectedGameObject.gameObject;
                //もしボタンが選択から外れたら
                if (this.gameObject != eventSystem.currentSelectedGameObject.gameObject)
                {
                    //矢印を非表示
                    yajirusi.SetActive(false);
                    select_f = false;
                }
            }
            catch
            {
                // なにも選択されていない場合なにもしない
            }
        }
    }
}
