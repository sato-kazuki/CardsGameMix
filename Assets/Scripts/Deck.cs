using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 山札の状態
/// </summary>
public static class Deck
{
    //各カードを山札が保持しているかどうか
    private static BitArray cardNumbers = new BitArray(54, false);


    /// <summary>
    /// 再初期化
    /// </summary>
    public static void ResetCards()
    {
        cardNumbers = cardNumbers.And(new BitArray(54, false));
    }

    /// <summary>
    /// 山札から一枚カードを引く
    /// </summary>
    /// <returns></returns>
    public static int GetCardNum()
    {
        
        return GetCardNum();
    }


}
