using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �R�D�̏��
/// </summary>
public static class Deck
{
    //�R�D���ێ����Ă���J�[�h����(JOKER�܂�
    private static int numberOfDecks = 54;

    static List<int> cards;

    /// <summary>
    /// �f�b�L�̏������ƃV���b�t��
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
    /// �R�D����ꖇ�J�[�h������
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
