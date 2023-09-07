using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealer : SingletonBase<Dealer>
{
    protected override bool dontDestroyOnLoad { get { return false; } }

        //�ۗL�J�[�h�̃��X�g
        private List<int> haveCardNums;


        private void Start()
        {
            haveCardNums = new List<int>();
        }

        /// <summary>
        /// ���������\�b�h
        /// </summary>
        public void ResetIns()
        {
            haveCardNums.Clear();
        }

        /// <summary>
        /// �J�[�h�̒ǉ�
        /// </summary>
        /// <param name="card"></param>
        public void AddCardNum(int card)
        {
            Debug.Log("Add" + card);
            haveCardNums.Add(card);
        }

        /// <summary>
        /// �J�[�h�ԍ��̃��X�g��Ԃ�
        /// </summary>
        /// <returns></returns>
        public List<int> ReadCards()
        {
            return haveCardNums;
        }


}
