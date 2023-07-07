using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BJManager : SingletonBase<BJManager>
{
    protected override bool dontDestroyOnLoad { get { return false; } }
    int cardNum = 0;

    public void Start()
    {
        GameReset();

    }

    //ゲーム初期化
    private void GameReset()
    {
        BJRuleManager.SetPlayingFlag(true);
        Deck.Shuffle();
    }
    private void GameEnd()
    {
        BJRuleManager.SetPlayingFlag(false);
    }


    private void GameLoop()
    {
        //ゲーム初期化
        GameReset();

        //ベットする額を選択し、所持コインから減らす。
        PlayerAvater.Instance.GetCoins(-10);
        int bets = 10;

        //一枚目のカードが配布される。
        distributionCard();

        //HitまたはStandの2つから選択する。
        //入力待機

        //Hitを選択した場合、カードを一枚追加して再度選択に戻る。数値合計が22以上の場合、Bustとして敗北扱いにし、ディーラーの行動に移る。
        distributionCard();

        //BJRuleManager.CardSumTotalでの例外処理取得を未実装(0以下の時不正状態)
        if(BJRuleManager.IsBust(BJRuleManager.CardSumTotal(PlayerAvater.Instance.ReadCards())))
        {
            //bust処理

            //ディーラーの行動に移る
        }


        //Standを選択した場合、即ディーラーの行動に移る。


        //ディーラーがカードを引く。17以上になるまで引き続ける。22以上の場合、Bustとして敗北扱いにし、勝敗判定に移る。
        do
        {
            int dCardNum = 0;
            do
            {
                dCardNum = Deck.GetCardNum();
            } while (52 < dCardNum);

            CardInstance.Instance.InstanstiateCard(dCardNum, "dealercard");

            //ディーラークラスでカードの数値を保持する必要がある(未実装
            Dealer.Instance.AddCardNum(dCardNum);
        } while (BJRuleManager.CardSumTotal(Dealer.Instance.ReadCards()) < 17);

        if (BJRuleManager.IsBust(BJRuleManager.CardSumTotal(Dealer.Instance.ReadCards())))
        {
            //Bustとして次へ
        }



        //プレイヤーとディーラーの数値合計を比較し、勝敗判定を行う。
        //引き分けの場合、ベットしたコインを払い戻す。勝利した場合はベット額の倍額を所持コインに加算する。
        if (BJRuleManager.PlayerIsWin(0, BJRuleManager.CardSumTotal(PlayerAvater.Instance.ReadCards())).isWin)
        {
            //勝利時処理
            PlayerAvater.Instance.GetCoins(bets*2);

        }
        else if(!BJRuleManager.PlayerIsWin(0, BJRuleManager.CardSumTotal(PlayerAvater.Instance.ReadCards())).isWin)
        {
            //引き分け時処理(コイン払い戻し
            PlayerAvater.Instance.GetCoins(bets);
        }
        else
        {
            //敗北時処理
            PlayerAvater.Instance.GetCoins(0);
        }


        //ゲームの継続を選択する。継続する場合はベット額の選択に戻り、継続しない場合はタイトルに戻る。


    }

    private void distributionCard()
    {
        do
        {
            cardNum = Deck.GetCardNum();
        } while (52 < cardNum);

        CardInstance.Instance.InstanstiateCard(cardNum, "playercard");
        PlayerAvater.Instance.AddCardNum(cardNum);
    }
}
