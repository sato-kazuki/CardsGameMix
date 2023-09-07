using System;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class BJRule
{
    //ゲーム中かどうか
    public static bool isPlaying { get; private set; } = false;

    private const int BUSTLIMIT = 22;

    public static void SetPlayingFlag(bool flag)
    {
        isPlaying = flag;
        Debug.Log("playflagset");
    }

    /// <summary>
    /// Bust判定
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
    /// 勝敗判定
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
            //引き分け処理
            isDraw_tmp = true;
        }
        else if (playerNum < dealerNum)
        {
            isWin_tmp = true;
        }


        return (isWin_tmp, isDraw_tmp);
    }

    /// <summary>
    /// カードの点数計算
    /// </summary>
    /// <param name="flag"></param>
    private static int PointSum(List<int> ints)
    {
        int sum = 0;
        ints.Sort();

        foreach (int i in ints)
        {        
            if(21 < sum + i && 10 < i)
            {
                sum = i - 10;
            }
            else { sum += i; }
        }

        return sum;
    }


    
    /// <summary>
    /// カードから記号を弾いて合計数値を取得
    /// 0は裏面、-1はJOKER
    /// </summary>
    /// <param name="cardsNum"></param>
    /// <returns></returns>
    public static int CardSumTotal(List<int> cardsNum)
    {
        List<int> Num = new List<int>(); ; //デフォルトで裏面
        int total = 0;

        for (int i = cardsNum.Count - 1; 0 < i; i--)
        {
            if (cardsNum[i] <= 0){
                Debug.Log("return 0");
                //return 0;
            }
            else if (4 <= cardsNum[i] / 13 && cardsNum[i] % 13 != 0){
                //return -1;
                Debug.Log("return -1");
            }

            else if (cardsNum[i] % 13 == 0) {
                Num.Add(13);
            }else{
                Num.Add(cardsNum[i] % 13);
            }
        }
        total = PointSum(Num);

        return total;
    }
}
