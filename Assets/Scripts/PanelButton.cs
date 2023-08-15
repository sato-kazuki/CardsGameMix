using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PanelButton : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI panelText;
    //[SerializeField] TextMeshProUGUI yesText;
    //[SerializeField] TextMeshProUGUI noText;


    //public void ChangePanelText(string message){ panelText.text = message;}
    //public void ChangeYesButton(string message){ yesText.text = message;}
    //public void ChangeNoButton(string message) { noText.text = message;}

    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] GameObject betPanel;


    public void OnButtonYes()
    {
        Debug.Log("Button_yes_" + dropdown.captionText.text);
        
        MainThread.GameStart(int.Parse(dropdown.captionText.text) * -1);
        betPanel.SetActive(false);
    }
    public void OnButtonNo()
    {
        Debug.Log("Button_no");
    }
}
