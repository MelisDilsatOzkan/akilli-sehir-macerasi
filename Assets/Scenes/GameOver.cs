using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Update()
    {
        // E�er t�m trash objeleri topland�ysa, yeni sahneye ge�
        if (AllTrashCollected())
        {
            SceneManager.LoadScene("GameOver"); // Yeni sahne ad�
        }
    }

    bool AllTrashCollected()
    {

        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("Trash");
        foreach (GameObject trash in trashObjects)
        {
            if (trash.activeSelf) // E�er bir ��p aktifse, hen�z toplanmad� demektir
                return false;
        }
        return true; // E�er hi�bir ��p aktif de�ilse, t�m ��pler topland� demektir
    }

}
