using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealer : SingletonBase<Dealer>
{
    protected override bool dontDestroyOnLoad { get { return false; } }
    //仮置きの数値リスト
    private List<int> haveCardNums;
    //ディーラーアニメーションのコントロール

    //playerAvatar同様の処理を追加

    public void AddCardNum(int cardNum)
    {

    }
    public List<int> ReadCards()
    {
        return haveCardNums;
    }
}
