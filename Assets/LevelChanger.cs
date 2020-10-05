using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameMaster>().GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gm.TurnOffGameOverScreen();
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
        gm.TurnOffGameOverScreen();
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName(scene).buildIndex);
        gm.TurnOffGameOverScreen();
    }

    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/CasterraDev");
    }
}
