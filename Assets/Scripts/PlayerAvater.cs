using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//�V���O���g���Ƃ��ăv���C���[�I�u�W�F�N�g�ɃA�^�b�`
public class PlayerAvater : SingletonBase<PlayerAvater>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    //�ۗL�J�[�h�̃��X�g
    private List<GameObject> haveCards;
    //�ۗL�R�C����
    private int coins;


    private void Start()
    {
        haveCards = new List<GameObject>();
        coins = 0;
    }

    /// <summary>
    /// ���������\�b�h
    /// </summary>
    public void Reset()
    {
        haveCards.Clear();
    }


    /// <summary>
    /// �J�[�h�̒ǉ�
    /// </summary>
    /// <param name="card"></param>
    public void setCards(GameObject card)
    {
        haveCards.Add(card);
    }

    /// <summary>
    /// �J�[�h�ԍ��̃��X�g��Ԃ�
    /// </summary>
    /// <returns></returns>
    public List<int> readCards()
    {
        List<int> list = new List<int>();

        if(haveCards.Count > 0)
        {
            for (int i = 0; i < haveCards.Count; i++)
            {
                list.Add(haveCards[i].GetComponent<Cards>().tranpNum);
            }
        }
        else
        {
            Debug.Log("card list undefine");
        }
        
        return list;
    }

    /// <summary>
    /// �R�C���̊l��
    /// </summary>
    /// <param name="coins"></param>
    public void setCoins(int coin)
    {
        coins += coin;
    }

}
