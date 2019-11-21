using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class test : MonoBehaviour
{
    #region varibales
    public bool gameStareted = false;
    //private
    [SerializeField]
    public int score;
    [SerializeField]
    public Text scoreText;
    // [SerializeField]
   
    [SerializeField]
    public Button restart;
    [SerializeField]
    public Button home;
    [SerializeField]
    public Button left;
    [SerializeField]
    public Button right;
  
    // Start is called before the first frame update
    void Start()
    {


        gameStareted = true;

        restart.gameObject.SetActive(false);
        home.gameObject.SetActive(false);
        left.gameObject.SetActive(true);

        InvokeRepeating("updatscore", 1.0f, 1.0f);
    }

    // Update is called once per frame
   




    #endregion
    #region UnityFonctions


    public void Settings()
    {

    }
    public void leaderbord()
    {

    }

    


    void Update()
    {
        updatscore();
        left.gameObject.SetActive(true);
        right.gameObject.SetActive(true);
    }
    #endregion
    void updatscore()
    {
        if (gameStareted == true)
            score++;
        scoreText.text = " " + score;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("gameOV");

    }


    public void Homepage()
    {
        SceneManager.LoadScene("game");
    }
    public void GameEnded()
    {
        scoreText.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);
        home.gameObject.SetActive(true);
        left.gameObject.SetActive(true);
        right.gameObject.SetActive(true);
        gameStareted = false;


    }
}


