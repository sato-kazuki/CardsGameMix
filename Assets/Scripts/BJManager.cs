using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BJManager : SingletonBase<BJManager>
{
    protected override bool dontDestroyOnLoad { get { return false; } }
    //���̃V�[���̂݃V���O���g��


    //�Q�[��������
    private void GameReset()
    {
        Deck.Shuffle();
        BJRuleManager.SetPlayingFlag(true);
    }

    //�Q�[��������
    private void GameLoop()
    {
        GameReset();

        //�v���C���[�����R�C���̓ǂݎ��Ɣ��f

        //�f�b�L�V���b�t��
        //�J�[�h�z�z

        //�A�N�V�����{�^����t

        //�e�A�o�^�[�s��

        //�X�^���h��܂���Bust

        //�f�B�[���[�s��
        //���s����

        //�Q�[���I��

        //�X�R�A����

        //���[�v
    }
}
