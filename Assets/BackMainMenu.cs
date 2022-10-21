using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMainMenu : MonoBehaviour
{
    public void BackGame (string MainMenu) {
    SceneManager.LoadScene (MainMenu);
    Debug.Log("Scene Main Menu Aktif" + MainMenu);
    }    
 }

