using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TostarScript : MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        Debug.Log("操作方法 押された!");  // ログを出力

        SceneManager.LoadScene("lyn_TitleScecne"); // スタート画面へ飛ぶ
    }
}
