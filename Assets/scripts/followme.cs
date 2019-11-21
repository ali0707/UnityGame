using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followme : MonoBehaviour
{

    public Transform Cible;
    public float vitesseRotation;
    public float vitesseZoom;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void UpdateOld()
    {
        float verticalRotation = Input.GetAxis("Vertical") * vitesseRotation * Time.deltaTime;
        transform.LookAt(Cible.position);
        Vector3 axe = transform.TransformVector(transform.right);
        transform.RotateAround(Cible.position, axe, verticalRotation);
        float zoom = vitesseZoom * Time.deltaTime;
        if (Input.GetKey(KeyCode.O))
        {

            transform.Translate(zoom * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.P))
        {

            transform.Translate(zoom * (-Vector3.forward));
        }
    }
    void Update()
    {
        float verticalRotation = Input.GetAxis("Vertical") * vitesseRotation * Time.deltaTime;
        transform.LookAt(Cible.position);
        Vector3 axe = transform.TransformVector(transform.right);
        transform.RotateAround(Cible.position, axe, verticalRotation);
        //float zoom = vitesseZoom*Time.deltaTime;
        float zoom = vitesseZoom * Time.deltaTime * Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(zoom * Vector3.forward);
    }
}
