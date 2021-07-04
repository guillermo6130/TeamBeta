using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScript : MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        Debug.Log("スタート 押された!");  // ログを出力

        SceneManager.LoadScene("Creating"); // メイン画面へ飛ぶ
    }
}
