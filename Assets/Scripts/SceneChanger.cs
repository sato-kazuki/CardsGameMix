using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーンを切り替えるボタンを押したときの切り替え処理
/// </summary>
public class SceneChanger : MonoBehaviour
{
    public void changeSceneJPUno()
    {
        SceneManager.LoadScene("JPUnoScene");
    }
    public void changeSceneBlackJack()
    {
        SceneManager.LoadScene("BlackJackScene");
    }
    public void changeScenesolitaire()
    {
        SceneManager.LoadScene("solitaireScene");
    }
}
