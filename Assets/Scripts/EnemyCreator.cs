using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject enemy;

    public int genTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Create", genTime, genTime);
        //InvokeRepeating("RandomType", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Create()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
    /*void RandomType()
    {
        genTime = Random.Range(1, 10);
    }*/
}
