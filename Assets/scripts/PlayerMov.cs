using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMov : MonoBehaviour
{
    #region Variables
    //public

    //private
    [SerializeField]
    private float movementSpeed = 0.0f;
    private Rigidbody myRB; 
    #endregion
    
    #region unityFunctions
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        
    }
    #endregion
    private void Move()
    {
        if(CrossPlatformInputManager.GetAxis("Horizontal")!=0)
            {
            float haxis = CrossPlatformInputManager.GetAxis("Horizontal");
            Vector3 moveDir = new Vector3(haxis, 0, 0);
            myRB.velocity = moveDir * movementSpeed * Time.fixedDeltaTime;
        }
    }
}
