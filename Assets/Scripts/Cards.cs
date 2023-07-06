using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
//using UnityEngine.UIElements;


/// <summary>
/// �g�����v�ꖇ���Ƃ�AddComponent�����
/// </summary>
public class Cards : MonoBehaviour
{
    /// <summary>
    /// �I�u�W�F�N�g���ێ����Ă���J�[�h�ԍ�
    ///get��set�͂��ꂼ�ꃁ�\�b�h���g�p����
    /// </summary>
    public int tranpNum { get; protected set; }
    private Image tranpImg;

    private const string HEADERPATH = "Assets/texture/torannpu-illust";
    private const string FOOTERPATH = ".png";


    private void Start()
    {
        tranpNum = 0;
        tranpImg = this.GetComponent<Image>();
    }

    /// <summary>
    /// �G���̕ύX
    /// </summary>
    public async void TranpChange(int num)
    {
        string path = HEADERPATH + num.ToString() + FOOTERPATH;
        Texture2D tranpPng = await Addressables.LoadAssetAsync<Texture2D>(path).Task;
        if (tranpPng != null)
        {
            tranpImg.sprite = Sprite.Create(tranpPng, new Rect(0, 0, tranpPng.width, tranpPng.height), Vector2.zero);
        }
        else
        {
            Debug.LogError("Failed to load texture: " + path);
        }

        tranpNum = num;
    }

}
