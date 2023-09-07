using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �V�[����؂�ւ���{�^�����������Ƃ��̐؂�ւ�����
/// </summary>
public class SceneChanger : MonoBehaviour
{
    public void changeSceneJPUno()
    {
        SceneManager.LoadScene("JPUnoScene");
    }
    public void changeSceneBlackJack()
    {
        SceneManager.LoadScene("BlackJack");
    }
    public void changeScenesolitaire()
    {
        SceneManager.LoadScene("solitaireScene");
    }
    public void changeSceneTitle()
    {
        SceneManager.LoadScene("TitleScene");
        PlayerAvater.Instance.ResetIns();
    }
}
