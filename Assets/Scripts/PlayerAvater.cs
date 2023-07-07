using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//�V���O���g���Ƃ��ăv���C���[�I�u�W�F�N�g�ɃA�^�b�`
public class PlayerAvater : SingletonBase<PlayerAvater>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    //�ۗL�J�[�h�̃��X�g
    private List<int> haveCardNums;
    //�ۗL�R�C����
    private int coins;

    [SerializeField] CoinUI coinUI;


    private void Start()
    {
        haveCardNums = new List<int>();
        coins = 0;
    }

    /// <summary>
    /// ���������\�b�h
    /// </summary>
    public void Reset()
    {
        haveCardNums.Clear();
    }

    /// <summary>
    /// �J�[�h�̒ǉ�
    /// </summary>
    /// <param name="card"></param>
    public void AddCardNum(int card)
    {
        haveCardNums.Add(card);
    }

    /// <summary>
    /// �J�[�h�ԍ��̃��X�g��Ԃ�
    /// </summary>
    /// <returns></returns>
    public List<int> ReadCards()
    {
        return haveCardNums;
    }

    /// <summary>
    /// �R�C���̊l��
    /// </summary>
    /// <param name="coins"></param>
    public void GetCoins(int coin)
    {
        coins += coin;
        coinUI.AddCoin(coins);

    }

}
