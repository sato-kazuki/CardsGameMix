using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �A�N�V�������N�����{�^�������������̋N��
/// </summary>
public class PlayButton : MonoBehaviour
{
    public void OnClickHit(){
        //BJManager.Instance.hitFlag = true;
        MainThread.HitAction();
    }

    public void OnClickStand() { 
        //BJManager.Instance.standFlag = true;
        MainThread.StandAction();
     
    }
}
