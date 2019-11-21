using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Cube_collision : MonoBehaviour
    {
    #region Variables
    //public
    public GameObject restartbtn;
    public GameObject homebtn;
    public GameObject scoreText;
    public GameObject left;
    public GameObject rigth;


    //private

    [SerializeField]
    private UIfonctions uiFunctions;


        #endregion

        void start()
    {
        uiFunctions = GameObject.FindGameObjectWithTag("GameManager").GetComponent<UIfonctions>();
    }
    void Update()
    {

    }
        private void OnCollisionEnter(Collision col)
        {
       

                if (col.gameObject.tag == "Platform")
                {

            this.gameObject.SetActive(false);

        }
        

        if (col.gameObject.tag == "Player")
            {
            uiFunctions.GameEnded();
        }

    }
  


}

