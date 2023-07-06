using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 山札の状態
/// </summary>
public static class Deck
{
    //山札が保持しているカード枚数(JOKER含む
    private static int numberOfDecks = 54;

    static List<int> cards;

    /// <summary>
    /// デッキの初期化とシャッフル
    /// </summary>
    public static void Shuffle()
    {
        if (cards == null)
        {
            cards = new List<int>();
        }
        else
        {
            cards.Clear();
        }

        for (int i = 0; i < numberOfDecks; i++)
        
        {
            cards.Add(i);
        }

        int n = cards.Count; 
        while (n > 1)
        {
            n--;
            int k = UnityEngine.Random.Range(0, n + 1);
            int tmp = cards[k];
            cards[k] = cards[n];
            cards[n] = tmp;
        }
    }

    /// <summary>
    /// 山札から一枚カードを引く
    /// </summary>
    /// <returns></returns>
    public static int GetCardNum()
    {
        int cardNum = 0;
        if (0 < numberOfDecks)
        {
            numberOfDecks -= 1;
            cardNum = cards[numberOfDecks];
            return cardNum;
        }
        else
        {
            return cardNum;
        }
    }
}
