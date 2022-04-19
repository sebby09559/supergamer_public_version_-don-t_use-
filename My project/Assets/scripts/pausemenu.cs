using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public GameObject pausemenu;

    public bool isPaused;


    // Start is called before the first frame update
    void Start()
    {
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(keycode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pausemenu.SetActive(false);
        Time.TimeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame()
    {
        pausemenu.SetActive(true);
        Time.TimeScale = 1f;
        isPaused = false;
    }
}
