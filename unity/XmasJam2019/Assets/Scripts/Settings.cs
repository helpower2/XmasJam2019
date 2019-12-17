using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Settings : MonoBehaviour
{
    // Start is called before the first frame update
    public void MainMenu()

    {

        SceneManager.LoadScene(2);
        
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
