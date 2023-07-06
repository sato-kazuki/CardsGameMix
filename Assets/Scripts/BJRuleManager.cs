using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BJRuleManager
{
    //�Q�[�������ǂ���
    private static bool IsPlaying = true;

    public static bool PlayerIsBust(int cardNum)
    {
        //bust
        bool isBust = 22 <= cardNum;
        return isBust;
    }
    /// <summary>
    /// ���s����
    /// </summary>
    /// <param name="dealNum"></param>
    /// <param name="playerNum"></param>
    /// <returns></returns>
    public static bool PlayerIsWin(int dealNum,int playerNum)
    {
        bool isWin = false;

        //���s����@������
        //�f�B�[���[�ƃv���C���[��Bust�̎��͔s�k || �v���C���[�̂�bust�͔s�k(�f�B�[���[�̂�bust�͏���)
        //�v���C���[���f�B�[���[���傫����Δs�k
        //�����łȂ��Ȃ珟��
        //���͈����������������荞�ށi�X�R�A�N���X�̕ʃ��\�b�h
        if (21 < dealNum) {
            return isWin = true;
        }
        else if(dealNum <= 21 && playerNum <= dealNum)
        {
            return isWin = false;
        }
        else
        {
        }
        return isWin;
    }
    public static void SetPlayingFlag(bool flag)
    {
        IsPlaying = flag;
    }
    

}
