using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameExit : MonoBehaviour
{
    //　ゲーム終了ボタンを押したら実行する
    public void EndGame()
    {
        Application.Quit();
    }
    public void OnClick()
    {
        Application.Quit();
    }
}