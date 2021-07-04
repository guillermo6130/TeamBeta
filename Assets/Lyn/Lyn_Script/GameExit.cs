using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    //　ゲーム終了ボタンを押したら実行する
    public void EndGame()
    {
        Application.Quit();
    }
}