using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BJManager : SingletonBase<BJManager>
{
    protected override bool dontDestroyOnLoad { get { return false; } }
    int cardNum = 0;
    public bool hitFlag = false;
    public bool standFlag = false;

    public void Start()
    {
        GameLoop();
    }

    //�Q�[��������
    private void GameReset()
    {
        BJRule.SetPlayingFlag(true);
        Deck.Shuffle();
    }
    private void GameEnd()
    {
        BJRule.SetPlayingFlag(false);
    }


    public void GameLoop()
    {
        //�Q�[��������
        GameReset();

        //�x�b�g����z��I�����A�����R�C�����猸�炷�B
        PlayerAvater.Instance.GetCoins(-10);
        int bets = 10;

        //�ꖇ�ڂ̃J�[�h���z�z�����B
        distributionCard();

        //Hit�܂���Stand��2����I������B
        //���͑ҋ@
        Debug.Log("waiting");



        Debug.Log("waited");





        //�f�B�[���[���J�[�h�������B17�ȏ�ɂȂ�܂ň���������B22�ȏ�̏ꍇ�ABust�Ƃ��Ĕs�k�����ɂ��A���s����Ɉڂ�B
        do
        {
            int dCardNum = 0;
            do
            {
                dCardNum = Deck.GetCardNum();
            } while (52 < dCardNum);

            CardInstance.Instance.InstanstiateCard(dCardNum, "dealercard");

            //�f�B�[���[�N���X�ŃJ�[�h�̐��l��ێ�����K�v������(������
            Dealer.Instance.AddCardNum(dCardNum);
        } while (BJRule.CardSumTotal(Dealer.Instance.ReadCards()) < 17);

        if (BJRule.IsBust(BJRule.CardSumTotal(Dealer.Instance.ReadCards())))
        {
            //Bust�Ƃ��Ď���
        }



        //�v���C���[�ƃf�B�[���[�̐��l���v���r���A���s������s���B
        //���������̏ꍇ�A�x�b�g�����R�C���𕥂��߂��B���������ꍇ�̓x�b�g�z�̔{�z�������R�C���ɉ��Z����B
        if (BJRule.PlayerIsWin(0, BJRule.CardSumTotal(PlayerAvater.Instance.ReadCards())).isWin)
        {
            //����������
            PlayerAvater.Instance.GetCoins(bets*2);

        }
        else if(!BJRule.PlayerIsWin(0, BJRule.CardSumTotal(PlayerAvater.Instance.ReadCards())).isWin)
        {
            //��������������(�R�C�������߂�
            PlayerAvater.Instance.GetCoins(bets);
        }
        else
        {
            //�s�k������
            PlayerAvater.Instance.GetCoins(0);
        }


        //�Q�[���̌p����I������B�p������ꍇ�̓x�b�g�z�̑I���ɖ߂�A�p�����Ȃ��ꍇ�̓^�C�g���ɖ߂�B

        Debug.Log("GameEnd");
    }


    /// <summary>
    /// ���͑ҋ@
    /// </summary>
    /// <returns></returns>
    IEnumerator InputWaiting()
    {
        while (true)
        {
            yield return new WaitUntil(() => hitFlag || standFlag);

            if (hitFlag)
            {
                Debug.Log("hitbutton");
                hitFlag = false;
                //Hit��I�������ꍇ�A�J�[�h���ꖇ�ǉ����čēx�I���ɖ߂�B���l���v��22�ȏ�̏ꍇ�ABust�Ƃ��Ĕs�k�����ɂ��A�f�B�[���[�̍s���Ɉڂ�B
                distributionCard();

                //BJRuleManager.CardSumTotal�ł̗�O�����擾�𖢎���(0�ȉ��̎��s�����)
                if (BJRule.IsBust(BJRule.CardSumTotal(PlayerAvater.Instance.ReadCards())))
                {
                    //bust����

                    //�f�B�[���[�̍s���Ɉڂ�
                    break;
                }
            }
            else if (standFlag)
            {
                Debug.Log("standbutton");
                standFlag = false;
                //Stand��I�������ꍇ�A���f�B�[���[�̍s���Ɉڂ�B
                break;
            }
            Debug.Log("one game end");
        }
    }


    /// <summary>
    /// �J�[�h�̕��z
    /// </summary>
    private void distributionCard()
    {
        do
        {
            cardNum = Deck.GetCardNum();
        } while (52 < cardNum);

        CardInstance.Instance.InstanstiateCard(cardNum, "playercard");
        PlayerAvater.Instance.AddCardNum(cardNum);
    }
}



//�u��
//�{�^�����͑ҋ@

//yield return new WaitUntil(() => hitFlag || standFlag);
//if (hitFlag)
//{
//    Debug.Log("hitbutton");
//    hitFlag = false;
//    //Hit��I�������ꍇ�A�J�[�h���ꖇ�ǉ����čēx�I���ɖ߂�B���l���v��22�ȏ�̏ꍇ�ABust�Ƃ��Ĕs�k�����ɂ��A�f�B�[���[�̍s���Ɉڂ�B
//    distributionCard();

//    //BJRuleManager.CardSumTotal�ł̗�O�����擾�𖢎���(0�ȉ��̎��s�����)
//    if (BJRuleManager.IsBust(BJRuleManager.CardSumTotal(PlayerAvater.Instance.ReadCards())))
//    {
//        //bust����

//        //�f�B�[���[�̍s���Ɉڂ�
//        yield break;
//    }
//}
//else if (standFlag)
//{
//    Debug.Log("standbutton");
//    standFlag = false;
//    //Stand��I�������ꍇ�A���f�B�[���[�̍s���Ɉڂ�B
//    yield break;
//}