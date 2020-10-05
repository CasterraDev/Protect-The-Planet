using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public GameObject gameOverScreen;
    public AudioClip explosionNoise;
    [HideInInspector]
    public bool gamePlaying = true;

    private Spawner spawner;
    protected GameMaster() { }
    public static GameMaster instance = null;

    private AudioSource bgMusic;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        bgMusic = GetComponent<AudioSource>();
        TurnOffGameOverScreen();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            TurnOffGameOverScreen();
        }
    }

    public void PlayExplosionNoise()
    {
        AudioSource Aso = gameObject.AddComponent<AudioSource>();
        Aso.clip = explosionNoise;
        Aso.Play();
        if (!Aso.isPlaying)
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        gamePlaying = false;
        gameOverScreen.SetActive(true);
    }

    public void TurnOffGameOverScreen()
    {
        gameOverScreen.SetActive(false);
        gamePlaying = true;
    }
}
