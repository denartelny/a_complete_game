using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pause;
   

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.activeSelf.Equals(false) && Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            Time.timeScale = 0;
        } else if (pause.activeSelf.Equals(true) && Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    
}
