using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//シングルトンとしてプレイヤーオブジェクトにアタッチ
public class PlayerAvater : SingletonBase<PlayerAvater>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    //保有カードのリスト
    private List<GameObject> haveCards;
    //保有コイン数
    private int coins;


    private void Start()
    {
        haveCards = new List<GameObject>();
        coins = 0;
    }

    /// <summary>
    /// 初期化メソッド
    /// </summary>
    public void Reset()
    {
        haveCards.Clear();
    }


    /// <summary>
    /// カードの追加
    /// </summary>
    /// <param name="card"></param>
    public void setCards(GameObject card)
    {
        haveCards.Add(card);
    }

    /// <summary>
    /// カード番号のリストを返す
    /// </summary>
    /// <returns></returns>
    public List<int> readCards()
    {
        List<int> list = new List<int>();

        if(haveCards.Count > 0)
        {
            for (int i = 0; i < haveCards.Count; i++)
            {
                list.Add(haveCards[i].GetComponent<Cards>().tranpNum);
            }
        }
        else
        {
            Debug.Log("card list undefine");
        }
        
        return list;
    }

    /// <summary>
    /// コインの獲得
    /// </summary>
    /// <param name="coins"></param>
    public void setCoins(int coin)
    {
        coins += coin;
    }

}
