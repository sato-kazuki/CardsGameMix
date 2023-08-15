using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] Image coinIcon;
    [SerializeField] TextMeshProUGUI coinText;

    //�e�L�X�g�ύX���\�b�h
    public void WriteCoin(int coinNum)
    {
        coinText.text = coinNum.ToString();
    }
}
