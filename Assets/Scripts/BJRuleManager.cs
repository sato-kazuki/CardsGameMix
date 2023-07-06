using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BJRuleManager
{
    //ゲーム中かどうか
    private static bool IsPlaying = true;

    public static bool PlayerIsBust(int cardNum)
    {
        //bust
        bool isBust = 22 <= cardNum;
        return isBust;
    }
    /// <summary>
    /// 勝敗判定
    /// </summary>
    /// <param name="dealNum"></param>
    /// <param name="playerNum"></param>
    /// <returns></returns>
    public static bool PlayerIsWin(int dealNum,int playerNum)
    {
        bool isWin = false;

        //勝敗判定　未完成
        //ディーラーとプレイヤーがBustの時は敗北 || プレイヤーのみbustは敗北(ディーラーのみbustは勝利)
        //プレイヤーよりディーラーが大きければ敗北
        //同数でないなら勝利
        //他は引き分け処理を割り込む（スコアクラスの別メソッド
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
