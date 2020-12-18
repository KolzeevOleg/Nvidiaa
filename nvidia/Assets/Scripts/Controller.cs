using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject startMenu;
    public GameObject k3090;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show1()
    {
        n1.SetActive(true);
        n2.SetActive(false);
        n3.SetActive(false);
        n4.SetActive(false);
        startMenu.SetActive(false);
        k3090.SetActive(true);

    }

    public void Show2()
    {
        n1.SetActive(false);
        n2.SetActive(true);
        n3.SetActive(false);
        n4.SetActive(false);
        startMenu.SetActive(false);
        k3090.SetActive(true);

    }

    public void Show3()
    {
        n1.SetActive(false);
        n2.SetActive(false);
        n3.SetActive(true);
        n4.SetActive(false);
        startMenu.SetActive(false);
        k3090.SetActive(true);

    }

    public void Show4()
    {
        n1.SetActive(false);
        n2.SetActive(false);
        n3.SetActive(false);
        n4.SetActive(true);
        startMenu.SetActive(false);
        k3090.SetActive(true);

    }

    public void BackInStartMenu()
    {
        n1.SetActive(false);
        n2.SetActive(false);
        n3.SetActive(false);
        n4.SetActive(false);
        startMenu.SetActive(true);
        k3090.SetActive(false);

    }


    public void SceneLoad(int index)
    {
        SceneManager.LoadScene(index);
    }
}
