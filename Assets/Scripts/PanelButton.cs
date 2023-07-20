using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI panelText;
    [SerializeField] TextMeshProUGUI yesText;
    [SerializeField] TextMeshProUGUI noText;

    public void ChangePanelText(string message){ panelText.text = message;}
    public void ChangeYesButton(string message){ yesText.text = message;}
    public void ChangeNoButton(string message) { noText.text = message;}
    

    public void OnButtonYes()
    {
        Debug.Log("Button_yes");
    }
    public void OnButtonNo()
    {
        Debug.Log("Button_no");
    }
}
