using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Texts : MonoBehaviour
{

    private int Trash = 0;

    public TextMeshProUGUI trashText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Trash")
        {
            Trash++;
            trashText.text = "Trash:" + Trash.ToString();
            Debug.Log(Trash);
        }
    }
}