using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// アクションを起こすボタンを押した時の起爆
/// </summary>
public class PlayButton : MonoBehaviour
{
    public void OnClickHit(){
        //BJManager.Instance.hitFlag = true;
        BJMainThread.HitAction();
    }

    public void OnClickStand() { 
        //BJManager.Instance.standFlag = true;
        BJMainThread.StandAction();
     
    }
}
