using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void loadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void loadSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void loadGameOverScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void loadGameOpenningScene()
    {
        SceneManager.LoadScene("GameOpenningScene");
    }
}
