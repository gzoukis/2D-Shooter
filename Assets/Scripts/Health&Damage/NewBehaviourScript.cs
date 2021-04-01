using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private GameObject enemyToKill;

    // Start is called before the first frame update
    void Start()
    {
        enemyToKill = GameObject.FindGameObjectWithTag("Boss");
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyToKill == null)
        {
            GameManager.instance.LevelCleared();
        }
    }
}
