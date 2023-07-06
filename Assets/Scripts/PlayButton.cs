using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// アクションを起こすボタンを押した時の起爆
/// </summary>
public class PlayButton : MonoBehaviour
{

    private void Start()
    {
        //仮置き
        Deck.Shuffle();
    }
    public void OnClickHit(){
        int cardNum = Deck.GetCardNum();
        Debug.Log(cardNum);
    }

    public void OnClickStand() { 
        
    }
}
