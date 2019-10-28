using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public GameObject menu;
    bool menuIsActive = false;
    // Start is called before the first frame update

    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (menuIsActive == false)
            {
                menu.SetActive(true);
                menuIsActive = true;
                Time.timeScale = 0;
            }
            else if (menuIsActive == true)
            {
                menu.SetActive(false);
                menuIsActive = false;
                Time.timeScale = 1;
            }
        }


    }
      
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

    public void ReturnToGame()
    {
        menu.SetActive(false);
        menuIsActive = false;
        Time.timeScale = 1;
    }
}
