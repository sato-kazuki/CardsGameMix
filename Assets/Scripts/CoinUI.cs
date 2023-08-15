using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] Image coinIcon;
    [SerializeField] TextMeshProUGUI coinText;

    //テキスト変更メソッド
    public void WriteCoin(int coinNum)
    {
        coinText.text = coinNum.ToString();
    }
}
