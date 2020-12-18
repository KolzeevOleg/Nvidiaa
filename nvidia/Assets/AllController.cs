using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllController : MonoBehaviour
{
    public GameObject buttonsMenu1;
    public GameObject buttonsMenu2;
    public GameObject buttonsMenu3;
    public GameObject buttonsMenu4;
    public GameObject buttonsMenu5;
    public GameObject buttonsMenu6;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 

    }

    public void ShowMenu2()
    {
        buttonsMenu1.SetActive(false);
        buttonsMenu2.SetActive(true);
        buttonsMenu3.SetActive(false);
        buttonsMenu4.SetActive(false);
        buttonsMenu5.SetActive(false);
        buttonsMenu6.SetActive(false);

    }

    public void ShowMenu3()
    {
        buttonsMenu2.SetActive(false);
        buttonsMenu3.SetActive(true);
        buttonsMenu1.SetActive(false);
        buttonsMenu4.SetActive(false);
        buttonsMenu5.SetActive(false);
        buttonsMenu6.SetActive(false);

    }

    public void ShowMenu4()
    {
        buttonsMenu3.SetActive(false);
        buttonsMenu4.SetActive(true);
        buttonsMenu1.SetActive(false);
        buttonsMenu2.SetActive(false);
        buttonsMenu5.SetActive(false);
        buttonsMenu6.SetActive(false);

    }

    public void ShowMenu5()
    {
        buttonsMenu4.SetActive(false);
        buttonsMenu5.SetActive(true);
        buttonsMenu1.SetActive(false);
        buttonsMenu2.SetActive(false);
        buttonsMenu3.SetActive(false);
        buttonsMenu4.SetActive(false);

    }

    public void ShowMenu6()
    {
        buttonsMenu5.SetActive(false);
        buttonsMenu6.SetActive(true);
        buttonsMenu1.SetActive(false);
        buttonsMenu2.SetActive(false);
        buttonsMenu3.SetActive(false);
        buttonsMenu4.SetActive(false);

    }

    public void BackInMenu1()
    {
        buttonsMenu2.SetActive(true);
        buttonsMenu6.SetActive(false);
        buttonsMenu1.SetActive(false);
        buttonsMenu3.SetActive(false);
        buttonsMenu4.SetActive(false);
        buttonsMenu5.SetActive(false);

    }

    public void ExitApp()
    {
        Application.Quit();
    }
}