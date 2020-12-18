using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject panel;
    public GameObject text;
    public GameObject buttonClose;
    public GameObject buttonOpen;
    public GameObject uRL;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HidePanel()
    {
        panel.SetActive(true);
        text.SetActive(true);
        buttonClose.SetActive(true);
        buttonOpen.SetActive(false);
        uRL.SetActive(true);
    }

    public void Open()
    {
        panel.SetActive(false);
        text.SetActive(false);
        buttonClose.SetActive(false);
        buttonOpen.SetActive(true);
        uRL.SetActive(false);
    }
}