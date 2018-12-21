using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnButtonClick : MonoBehaviour {
    
    public GameObject menuPanel;
    public GameObject settingsPanel;
  
    
    private bool check = false;
    


    public void restartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayButton()
    {
      
        
    }
    public void SettingsButton()
    {
        if (check == false)
        {
            settingsPanel.SetActive(true);
            check = true;
        }
        else
        {
            settingsPanel.SetActive(false);
            check = false;
        }
        
        
    }
    
    
}
