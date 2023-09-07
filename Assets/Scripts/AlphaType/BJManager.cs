using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BJManager : SingletonBase<BJManager>
{
    protected override bool dontDestroyOnLoad { get { return false; } }
    int cardNum = 0;
    public bool hitFlag = false;
    public bool standFlag = false;

    public void Start()
    {
        GameLoop();
    }

    //ゲーム初期化
    private void GameReset()
    {
        BJRule.SetPlayingFlag(true);
        Deck.Shuffle();
    }
    private void GameEnd()
    {
        BJRule.SetPlayingFlag(false);
    }


    public void GameLoop()
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
        Debug.Log("waiting");



        Debug.Log("waited");





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
        } while (BJRule.CardSumTotal(Dealer.Instance.ReadCards()) < 17);

        if (BJRule.IsBust(BJRule.CardSumTotal(Dealer.Instance.ReadCards())))
        {
            //Bustとして次へ
        }



        //プレイヤーとディーラーの数値合計を比較し、勝敗判定を行う。
        //引き分けの場合、ベットしたコインを払い戻す。勝利した場合はベット額の倍額を所持コインに加算する。
        if (BJRule.PlayerIsWin(0, BJRule.CardSumTotal(PlayerAvater.Instance.ReadCards())).isWin)
        {
            //勝利時処理
            PlayerAvater.Instance.GetCoins(bets*2);

        }
        else if(!BJRule.PlayerIsWin(0, BJRule.CardSumTotal(PlayerAvater.Instance.ReadCards())).isWin)
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

        Debug.Log("GameEnd");
    }


    /// <summary>
    /// 入力待機
    /// </summary>
    /// <returns></returns>
    IEnumerator InputWaiting()
    {
        while (true)
        {
            yield return new WaitUntil(() => hitFlag || standFlag);

            if (hitFlag)
            {
                Debug.Log("hitbutton");
                hitFlag = false;
                //Hitを選択した場合、カードを一枚追加して再度選択に戻る。数値合計が22以上の場合、Bustとして敗北扱いにし、ディーラーの行動に移る。
                distributionCard();

                //BJRuleManager.CardSumTotalでの例外処理取得を未実装(0以下の時不正状態)
                if (BJRule.IsBust(BJRule.CardSumTotal(PlayerAvater.Instance.ReadCards())))
                {
                    //bust処理

                    //ディーラーの行動に移る
                    break;
                }
            }
            else if (standFlag)
            {
                Debug.Log("standbutton");
                standFlag = false;
                //Standを選択した場合、即ディーラーの行動に移る。
                break;
            }
            Debug.Log("one game end");
        }
    }


    /// <summary>
    /// カードの分配
    /// </summary>
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



//隔離
//ボタン入力待機

//yield return new WaitUntil(() => hitFlag || standFlag);
//if (hitFlag)
//{
//    Debug.Log("hitbutton");
//    hitFlag = false;
//    //Hitを選択した場合、カードを一枚追加して再度選択に戻る。数値合計が22以上の場合、Bustとして敗北扱いにし、ディーラーの行動に移る。
//    distributionCard();

//    //BJRuleManager.CardSumTotalでの例外処理取得を未実装(0以下の時不正状態)
//    if (BJRuleManager.IsBust(BJRuleManager.CardSumTotal(PlayerAvater.Instance.ReadCards())))
//    {
//        //bust処理

//        //ディーラーの行動に移る
//        yield break;
//    }
//}
//else if (standFlag)
//{
//    Debug.Log("standbutton");
//    standFlag = false;
//    //Standを選択した場合、即ディーラーの行動に移る。
//    yield break;
//}