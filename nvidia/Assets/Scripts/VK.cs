using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VK : MonoBehaviour
{
    public string d = "https://vk.com/im?peers=545171931_c34_c33_c36_-39408465&sel=375505156";

    void Start()
    {
        Application.OpenURL(d);
    }


}
