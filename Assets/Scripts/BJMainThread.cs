using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class BJMainThread
{
    

    public static void Initialization()
    {
        Deck.Shuffle();
        PlayerAvater.Instance.ResetIns();
    }

    public static void BlackJackGameStart(int betCoin) {
        PlayerAvater.Instance.GetCoins(betCoin);
        Deck.Shuffle();
        BJRule.SetPlayingFlag(true);
        PlayerAvater.Instance.AddCardNum(Deck.GetCardNum());
        Debug.Log("dealer_card_" + Deck.GetCardNum().ToString());

        if (BJRule.IsBust(BJRule.CardSumTotal(PlayerAvater.Instance.ReadCards()))){
            StandAction();
        }
    
    }

    public static void HitAction()
    {
        Debug.Log("Hit");
        PlayerAvater.Instance.AddCardNum(Deck.GetCardNum());
    }
    public static void StandAction()
    {
        Debug.Log("Stand");
        dealerTurnPhase();
        judgePhase();
    }

    private static void dealerTurnPhase()
    {
        //ŽŸ‚±‚±‚©‚ç
    }
    private static void judgePhase()
    {

    }
}
