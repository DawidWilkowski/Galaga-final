using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    GameObject[] projectiles;
    Vector3 respawn = new Vector3(0, -4 ,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            DestroyAll();
            collision.gameObject.transform.position = respawn;
            GameManager.lives--;
            GameManager.playGame = false;
        }
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(enemyProjectile);
        }

    }

    void DestroyAll()
    {
        Destroy(enemyProjectile);
        projectiles = GameObject.FindGameObjectsWithTag("EnemyProjectile");
        for (var i = 0; i < projectiles.Length; i++)
        {
            Destroy(projectiles[i]);
        }
    }
    
    

}
