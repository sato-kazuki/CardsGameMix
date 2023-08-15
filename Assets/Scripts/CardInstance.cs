using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;


public class CardInstance : SingletonBase<CardInstance>
{
    protected override bool dontDestroyOnLoad { get { return false; } }

    GameObject cardPrefab;
    List<GameObject> gameObjects = new List<GameObject>();
    private const string PATH = "Assets/Prefabs/Card.prefab";

    public void Start()
    {
        LoadCardprefab();
    }

    private async void LoadCardprefab()
    {
        cardPrefab = await Addressables.LoadAssetAsync<GameObject>(PATH).Task;
    }



    /// <summary>
    /// �J�[�h�̐���
    /// </summary>
    public void InstanstiateCard(int cardNum, string userName)
    {
        
        if(cardPrefab != null) {
            
            GameObject cardObject = Instantiate(cardPrefab, Vector3.zero, Quaternion.identity, transform);
            cardObject.name = userName + cardNum.ToString();
            cardObject.GetComponent<Cards>().TranpChange(cardNum);
            gameObjects.Add(cardObject);
        }
    }
    /// <summary>
    /// �J�[�h�̏���
    /// </summary>
    public void RemoveCards()
    {
        gameObjects.Clear();
    }
    
}
