using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TostartScript : MonoBehaviour
{
    // ボタンを押したらスタート画面へ戻る
    public void TostartButton()
    {
        Debug.Log("スタート画面へ 押された!");  // ログを出力

        SceneManager.LoadScene("lyn_TitleScecne");
    }

}
