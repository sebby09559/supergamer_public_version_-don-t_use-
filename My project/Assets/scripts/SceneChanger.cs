using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void mainmenu()
    {
        SceneManager.LoadScene("menuscene");
    }
    public void options()
    {
        SceneManager.LoadScene("optionsmenu");
    }
    public void testlevel()
    {
        SceneManager.LoadScene("testlevel");
    }
}