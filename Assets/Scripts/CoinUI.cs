using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] Image coinIcon;
    [SerializeField] TextMeshProUGUI coinNum;

    private int haveCoins = 0;

    //テキスト変更メソッド
    public void AddCoin(int addNum)
    {
        haveCoins += addNum;
        coinNum.text = haveCoins.ToString();
    }
}
