using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPanelController : MonoBehaviour
{
    [Header("Panel")]
    [SerializeField] private GameObject[] _tutPanel;

    [Header("UI Components")]
    [SerializeField] private GameObject btnPullForward;
    [SerializeField] private GameObject btnGreetCustomer;
    [SerializeField] private GameObject btnStartOver;
    [SerializeField] private GameObject btnAskSandwichType;
    [SerializeField] private GameObject btnAskDrinkType;
    [SerializeField] private GameObject btnClarifyOrder;
    [SerializeField] private GameObject orderPanel;
    [SerializeField] private GameObject btnProcessPayment;
    [SerializeField] private GameObject btnReopenPOS;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject btnNextOrder;

    [Header("Timer Components")]
    [SerializeField] private TextMeshProUGUI txtTimer;
    private float timer = 0f;
    private bool isTimerOn = false;


    void Awake()
    {
        for(int i = 0; i < _tutPanel.Length; i++)
        {
            _tutPanel[i].SetActive(false);
        }

        _tutPanel[0].SetActive(true);

        btnProcessPayment.transform.GetComponent<Button>().interactable = false;
    }

    public void Reset()
    {
        
    }

    public void OnClickPanel(int index)
    {
        for (int i = 0; i < _tutPanel.Length; i++)
        {
            _tutPanel[i].SetActive(false);
        }

        _tutPanel[index].SetActive(true);
    }
}
