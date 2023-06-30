using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    /// <summary>
    /// ‘å•x‹ƒV[ƒ“‚Ö‚Ì‘JˆÚ
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
