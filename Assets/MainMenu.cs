using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
   }
   public void Exit()
   {
   Application.Quit();
   }   
   List<int> widths = new List<int>() {1280, 1920};
    List<int> heights = new List<int>() {800, 1080};
    
    public void SetScreenSize (int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen); 
    }
    public void SetFullScreen (bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;  
    }
}

