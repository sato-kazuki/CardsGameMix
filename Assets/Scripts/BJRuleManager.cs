using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class BJRuleManager
{
    //�Q�[�������ǂ���
    public static bool isPlaying { get; private set; } = false;

    private const int BUSTLIMIT = 22;

    /// <summary>
    /// Bust����
    /// </summary>
    /// <param name="cardNum"></param>
    /// <returns></returns>
    public static bool IsBust(int cardNum)
    {
        //bust
        bool isBust = BUSTLIMIT <= cardNum;
        return isBust;
    }

    /// <summary>
    /// ���s����
    /// </summary>
    /// <param name="dealNum"></param>
    /// <param name="playerNum"></param>
    /// <returns></returns>
    public static (bool isWin, bool isDraw)PlayerIsWin(int dealerNum,int playerNum)
    {
        bool isWin_tmp = false;
        bool isDraw_tmp = false;

        if (BUSTLIMIT <= playerNum)
        {
            isWin_tmp = false;
        }
        else if (BUSTLIMIT <= dealerNum)
        {
            isWin_tmp = false;
        }
        else if (playerNum == dealerNum)
        {
            //������������
            isDraw_tmp = true;
        }
        else if (playerNum < dealerNum)
        {
            isWin_tmp = true;
        }


        return (isWin_tmp, isDraw_tmp);
    }


    public static void SetPlayingFlag(bool flag)
    {
        isPlaying = flag;
    }
    
    /// <summary>
    /// �J�[�h����L����e���č��v���l���擾
    /// 0�͗��ʁA-1��JOKER
    /// </summary>
    /// <param name="cardsNum"></param>
    /// <returns></returns>
    public static int CardSumTotal(List<int> cardsNum)
    {
        int total = 0; //�f�t�H���g�ŗ���
        for (int i = cardsNum.Count; 0 < i; i--)
        {
            if (cardsNum[i] <= 0){return 0;}
            if (4 <= cardsNum[i] / 13 && cardsNum[i] % 13 != 0){return -1;}


            if (cardsNum[i] % 13 == 0) {
                total += 13;
            }else{
                total += cardsNum[i] % 13;
            }
        }

        return total;
    }
}
