using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �R�D�̏��
/// </summary>
public static class Deck
{
    //�e�J�[�h���R�D���ێ����Ă��邩�ǂ���
    private static BitArray cardNumbers = new BitArray(54, false);


    /// <summary>
    /// �ď�����
    /// </summary>
    public static void ResetCards()
    {
        cardNumbers = cardNumbers.And(new BitArray(54, false));
    }

    /// <summary>
    /// �R�D����ꖇ�J�[�h������
    /// </summary>
    /// <returns></returns>
    public static int GetCardNum()
    {
        
        return GetCardNum();
    }


}
