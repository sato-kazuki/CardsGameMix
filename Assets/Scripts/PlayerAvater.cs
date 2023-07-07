using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//シングルトンとしてプレイヤーオブジェクトにアタッチ
public class PlayerAvater : SingletonBase<PlayerAvater>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    //保有カードのリスト
    private List<int> haveCardNums;
    //保有コイン数
    private int coins;

    [SerializeField] CoinUI coinUI;


    private void Start()
    {
        haveCardNums = new List<int>();
        coins = 0;
    }

    /// <summary>
    /// 初期化メソッド
    /// </summary>
    public void Reset()
    {
        haveCardNums.Clear();
    }

    /// <summary>
    /// カードの追加
    /// </summary>
    /// <param name="card"></param>
    public void AddCardNum(int card)
    {
        haveCardNums.Add(card);
    }

    /// <summary>
    /// カード番号のリストを返す
    /// </summary>
    /// <returns></returns>
    public List<int> ReadCards()
    {
        return haveCardNums;
    }

    /// <summary>
    /// コインの獲得
    /// </summary>
    /// <param name="coins"></param>
    public void GetCoins(int coin)
    {
        coins += coin;
        coinUI.AddCoin(coins);

    }

}
