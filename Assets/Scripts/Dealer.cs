using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealer : SingletonBase<Dealer>
{
    protected override bool dontDestroyOnLoad { get { return false; } }

        //保有カードのリスト
        private List<int> haveCardNums;


        private void Start()
        {
            haveCardNums = new List<int>();
        }

        /// <summary>
        /// 初期化メソッド
        /// </summary>
        public void ResetIns()
        {
            haveCardNums.Clear();
        }

        /// <summary>
        /// カードの追加
        /// </summary>
        /// <param name="card"></param>
        public void AddCardNum(int card)
        {
            Debug.Log("Add" + card);
            haveCardNums.Add(card);
        }

        /// <summary>
        /// カード番号のリストを返す
        /// </summary>
        /// <returns></returns>
        public List<int> ReadCards()
        {
            return haveCardNums;
        }


}
