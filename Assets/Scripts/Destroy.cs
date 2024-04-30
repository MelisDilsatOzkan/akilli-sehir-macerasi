using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class Destroy : MonoBehaviour
{
    private int Trash = 0;

    public TextMeshProUGUI trashText;

   
    public int totalTrash = 17; // Toplam trash sayýsý

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            
            // Trash toplama iþlemleri
            Destroy(other.gameObject); // Trash'i yok et veya devredýþý yap
            Trash++;
            trashText.text = "Trash:" + Trash.ToString();
            Debug.Log(Trash);
            if (Trash >= totalTrash)
            {
                // Eðer toplam trash sayýsýna ulaþýldýysa yeni sahneye geç
                SceneManager.LoadScene("Game2");
            }
            }
    }
}