using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UIfonctions : MonoBehaviour
{
    #region varibales
    public bool gameStareted = false;
    //private
    [SerializeField]
    public int score;
    [SerializeField]
    public Text scoreText;
   // [SerializeField]
    //public bool gamestarted = false;
    [SerializeField]
    public Button taptoplay;
    [SerializeField]
    public Button settings;
    [SerializeField]
    public Button leaderboard;
    [SerializeField]
    public Button facebook;
    [SerializeField]
    public Button ggl;
    [SerializeField]
    public Text title;
    [SerializeField]
    public Button play;
    [SerializeField]
    public Button restart;
    [SerializeField]
    public Button home;
    [SerializeField]
    public Button left;
    [SerializeField]
    public Button right;
    [SerializeField]
    public UIfonctions uiFunctions;
    [SerializeField]
    public Text scoreaffiche;
    [SerializeField]
    public Text boutt;


    [SerializeField]
    public Text bestscore;
    [SerializeField]
    public Text GameOver;
    [SerializeField]
    public Button easy;
    [SerializeField]
    public Button hard;
    [SerializeField]
    public Button mid;
    [SerializeField]
    public Image menu;
    [SerializeField]
    public Button backkk;



    #endregion
    #region UnityFonctions




    string subject = "Subject text";
    string body = "Actual text (Link)";

#if UNITY_IPHONE
	
	//[DllImport("__Internal")]
	private static extern void sampleMethod (string iosPath, string message);
	
	//[DllImport("__Internal")]
	private static extern void sampleTextMethod (string message);
	
#endif

    public void OnAndroidTextSharingClick()
    {

        StartCoroutine(ShareAndroidText());

    }
    IEnumerator ShareAndroidText()
    {
        yield return new WaitForEndOfFrame();
        //execute the below lines if being run on a Android device
#if UNITY_ANDROID
        //Reference of AndroidJavaClass class for intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //Reference of AndroidJavaObject class for intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        //call setAction method of the Intent object created
        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        //set the type of sharing that is happening
        intentObject.Call<AndroidJavaObject>("setType", "text/plain");
        //add data to be passed to the other activity i.e., the data to be sent
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TITLE"), "Text Sharing ");
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
        //get the current activity
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //start the activity by sending the intent data
        AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Share Via");
        currentActivity.Call("startActivity", jChooser);
#endif
    }


    public void OniOSTextSharingClick()
    {

#if UNITY_IPHONE || UNITY_IPAD
		string shareMessage = "Wow I Just Share Text ";
		sampleTextMethod (shareMessage);
		
#endif
    }
    public void RateUs()
    {
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=YOUR_ID");
#elif UNITY_IPHONE
		Application.OpenURL("itms-apps://itunes.apple.com/app/idYOUR_ID");
#endif
    }


    void Start()
    {
      

        uiFunctions = GameObject.FindGameObjectWithTag("GameManager").GetComponent<UIfonctions>();

        restart.gameObject.SetActive(false);
        home.gameObject.SetActive(false);

        InvokeRepeating("updatscore", 1.0f, 1.0f);

    }


    public void navFB()
    {

        Application.OpenURL("www.facebook.com");
    }

    public void bout_game ()
    {
        facebook.gameObject.SetActive(false);
        ggl.gameObject.SetActive(false);
        leaderboard.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
        taptoplay.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
        home.gameObject.SetActive(false);
        gameStareted = false;
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(false);

        menu.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        easy.gameObject.SetActive(false);
        mid.gameObject.SetActive(false);
        backkk.gameObject.SetActive(true);
        boutt.gameObject.SetActive(true);


    }

    public void Settings()
    {
        facebook.gameObject.SetActive(false);
        ggl.gameObject.SetActive(false);
        leaderboard.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
        taptoplay.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
        home.gameObject.SetActive(false);
        gameStareted = false;
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(false);
       
        menu.gameObject.SetActive(true);
        hard.gameObject.SetActive(true);
        easy.gameObject.SetActive(true);
        mid.gameObject.SetActive(true);
        backkk.gameObject.SetActive(true);
    }
    

    
   public void  hardd( )
    {
        SceneManager.LoadScene("hard");

    }

    public void esy()
    {
        SceneManager.LoadScene("esy");

    }

    public void midd()
    {
        SceneManager.LoadScene("mid");
    }


   
    public void back_paly()
    {
        facebook.gameObject.SetActive(true);
        ggl.gameObject.SetActive(true);
        leaderboard.gameObject.SetActive(true);
        settings.gameObject.SetActive(true);
        taptoplay.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
        play.gameObject.SetActive(true);
        title.gameObject.SetActive(true);
        home.gameObject.SetActive(false);
        gameStareted = false;
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(false);

        menu.gameObject.SetActive(false);
        hard.gameObject.SetActive(false);
        easy.gameObject.SetActive(false);
        mid.gameObject.SetActive(false);
        backkk.gameObject.SetActive(false);
        boutt.gameObject.SetActive(false);

    }
    public void leaderbord()
    {

    }

    public void PlayGame()
    {
        facebook.gameObject.SetActive(false);
        ggl.gameObject.SetActive(false);
        leaderboard.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
        taptoplay.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        play.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
        home.gameObject.SetActive(false);

               left.gameObject.SetActive(true);
        right.gameObject.SetActive(true);
        gameStareted = true; 
    }


    void Update()
    {
        updatscore();
     
    }
    #endregion
    void updatscore()
    {
        if(gameStareted == true )
        score++;
        scoreText.text = " " + score;
    }

    public void updatscorex()
    {
        if (gameStareted == true)
            score=score+100;
        scoreText.text = " " + score;
    }


    public void delscore()
    {
        if (gameStareted == true)
            score = score + 500;
        scoreText.text = " " + score;
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene("gameOV");

    }


    public void Restarthard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       // SceneManager.LoadScene("gameOV");

    }

    public void Homepage()
    {
        SceneManager.LoadScene("game");
    }

   

    public  void GameEnded()
    {

        if (PlayerPrefs.GetInt("Score") < score )
        {
            PlayerPrefs.SetInt("Score", score);
        }
        scoreaffiche.text = "Score:         " + score;
        bestscore.text = "Best Score:   " + PlayerPrefs.GetInt("Score");
        GameOver.gameObject.SetActive(true);
        bestscore.gameObject.SetActive(true);
        scoreaffiche.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
        restart.gameObject.SetActive(true);
        home.gameObject.SetActive(true);
        left.gameObject.SetActive(true);
        right.gameObject.SetActive(true);
        gameStareted = false;
        PlayerPrefs.Save();

        //restartbtn.SetActive(true);
        //scoreText.SetActive(true);
        //homebtn.SetActive(true);
        //left.SetActive(false);
        //rigth.SetActive(false);
        //uiFunctions.gameStareted = false;

    }
}
