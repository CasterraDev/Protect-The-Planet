using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public int score;

    private float timer;
    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GetComponent<Text>();
        score = 0;
        scoreTxt.text = "Score: " + score;
        gm = FindObjectOfType<GameMaster>().GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= .5f && gm.gamePlaying)
        {
            timer = 0;
            score++;
            scoreTxt.text = "Score: " + score;
        }
    }
}
