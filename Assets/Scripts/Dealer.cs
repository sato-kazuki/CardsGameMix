using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealer : SingletonBase<Dealer>
{
    protected override bool dontDestroyOnLoad { get { return false; } }
    //���u���̐��l���X�g
    private List<int> haveCardNums;
    //�f�B�[���[�A�j���[�V�����̃R���g���[��

    //playerAvatar���l�̏�����ǉ�

    public void AddCardNum(int cardNum)
    {

    }
    public List<int> ReadCards()
    {
        return haveCardNums;
    }
}
