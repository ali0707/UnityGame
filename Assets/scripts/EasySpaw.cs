using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class EasySpaw : MonoBehaviour
{
    #region Variables

    [SerializeField]
    private float minX = 0.0f;
    [SerializeField]
    private float maxX = 0.0f;
    [SerializeField]
    private int minHazardtospawn = 1;
    [SerializeField]
    private int maxHazardtospawn = 6;
    [SerializeField]
    private GameObject[] hazards;
    [SerializeField]
    private float timeBetweenSpawns = 0.0f;
    [SerializeField]
    private bool canSpawn = false;
    [SerializeField]
    private int amountOfHazardstoSpawn = 0;
    [SerializeField]
    private int hazardToSpawn = 0;
    [SerializeField]
    private int hazardSpawnCap = 8;
    [SerializeField]
    public UIfonctions uiFunctions;


    #endregion

    #region UnityFunctions
    public void Start()
    {


        uiFunctions = GameObject.FindGameObjectWithTag("GameManager").GetComponent<UIfonctions>();
        canSpawn = true;


    }

    void Update()
    {
        if (canSpawn == true && uiFunctions.gameStareted == true)
        {
            StartCoroutine("GenerateHazard");
        }
    }
    #endregion

    private IEnumerator GenerateHazard()
    {
        canSpawn = false;

       
        timeBetweenSpawns = Random.Range(0.6f, 2.0f);
        amountOfHazardstoSpawn = Random.Range(minHazardtospawn, maxHazardtospawn);

        for (int i = 0; i < amountOfHazardstoSpawn; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(8.5f, 10.0f), 0.0f);
            Instantiate(hazards[hazardToSpawn], spawnPos, Quaternion.identity);
        }

        yield return new WaitForSeconds(timeBetweenSpawns);
        canSpawn = true;
    }
}

