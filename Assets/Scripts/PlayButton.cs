using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �A�N�V�������N�����{�^�������������̋N��
/// </summary>
public class PlayButton : MonoBehaviour
{

    private void Start()
    {
        //���u��
        Deck.Shuffle();
    }
    public void OnClickHit(){
        int cardNum = Deck.GetCardNum();
        Debug.Log(cardNum);
    }

    public void OnClickStand() { 
        
    }
}
