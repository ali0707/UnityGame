using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FollowTarget : MonoBehaviour
{
    private int yHeight;
    private int zDistance ;

    private void follow()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + yHeight, transform.position.z - zDistance);
    }
} 