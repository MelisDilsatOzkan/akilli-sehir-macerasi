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

   
    public int totalTrash = 17; // Toplam coin say�s�

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            
            // Trash toplama i�lemleri
            Destroy(other.gameObject); // Trash'i yok edin veya devre d��� b�rak�n
            Trash++;
            trashText.text = "Trash:" + Trash.ToString();
            Debug.Log(Trash);
            if (Trash >= totalTrash)
            {
                // E�er toplam coin say�s�na ula��ld�ysa yeni sahneye ge�
                SceneManager.LoadScene("Game2");
            }
            }
    }
}