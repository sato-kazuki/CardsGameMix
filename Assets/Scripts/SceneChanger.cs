using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    /// <summary>
    /// ��x���V�[���ւ̑J��
    /// </summary>
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
