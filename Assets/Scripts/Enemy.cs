using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;  //czas DO poruszenia się
    int numOfMovements = 0;
    float speed = 0.25f;

    public GameObject enemy;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;
    public static bool isDestroyed = false;
    public AudioSource destroy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDestroyed == true) {
            destroy.Play();
            isDestroyed = false;
        }
        if (GameManager.playGame)  //jeśli gra trwa
        {
        if(numOfMovements == 14)     //zderzenie ze ścianą
        {
            transform.Translate(new Vector3(0, -1, 0));  //enemy's poruszają się stopniowo w jednostajnym kroku i czasie
            numOfMovements = -1;
            speed = -speed;
            timer = 0;
        }

        timer += Time.deltaTime;

            if (timer > timeToMove && numOfMovements <  14)  //wykonuje aż do momentu zderzenia ze ścianą
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numOfMovements++;
        }

        fireEnemyProjectile();   //w międzyczasie enemy's strzelają w nas
        }
    }

    void fireEnemyProjectile()   //enemy's strzelają w sposób random'owy
    {
        if(Random.Range(0f, 1000f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.4f, 0), enemy.transform.rotation) as GameObject;
        }
    }
}
