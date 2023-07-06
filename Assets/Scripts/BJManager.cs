using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BJManager : SingletonBase<BJManager>
{
    protected override bool dontDestroyOnLoad { get { return false; } }
    //このシーンのみシングルトン


    //ゲーム初期化
    private void GameReset()
    {
        Deck.Shuffle();
        BJRuleManager.SetPlayingFlag(true);
    }

    //ゲーム初期化
    private void GameLoop()
    {
        GameReset();

        //プレイヤー所持コインの読み取りと反映

        //デッキシャッフル
        //カード配布

        //アクションボタン受付

        //各アバター行動

        //スタンド後またはBust

        //ディーラー行動
        //勝敗判定

        //ゲーム終了

        //スコア処理

        //ループ
    }
}
