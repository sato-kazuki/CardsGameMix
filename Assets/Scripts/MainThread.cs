using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class MainThread
{
    

    public static void Initialization()
    {
        Deck.Shuffle();
        PlayerAvater.Instance.Reset();
    }

    public static void GameStart(int betCoin) {
        PlayerAvater.Instance.GetCoins(betCoin);
        Deck.Shuffle();
        BJRuleManager.SetPlayingFlag(true);
        PlayerAvater.Instance.AddCardNum(Deck.GetCardNum());
        Debug.Log("dealer_card_" + Deck.GetCardNum().ToString());
    
    }

    public static void HitAction()
    {
        Debug.Log("Hit");
        PlayerAvater.Instance.AddCardNum(Deck.GetCardNum());
    }
    public static void StandAction()
    {
        Debug.Log("Stand");
    }
}
