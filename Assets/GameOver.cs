using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Update()
    {
        // Eðer tüm trash objeleri toplandýysa, yeni sahneye geç
        if (AllTrashCollected())
        {
            SceneManager.LoadScene("GameOver"); // Yeni sahne adý
        }
    }

    bool AllTrashCollected()
    {

        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("Trash");
        foreach (GameObject trash in trashObjects)
        {
            if (trash.activeSelf) // Eðer bir çöp aktifse, henüz toplanmadý demektir
                return false;
        }
        return true; // Eðer hiçbir çöp aktif deðilse, tüm çöpler toplandý demektir
    }

}
