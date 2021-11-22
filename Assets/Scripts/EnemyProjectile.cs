using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    GameObject[] projectiles;   //tablica z pociskami/duża ich ilość
    Vector3 respawn = new Vector3(0, -4 ,0);  //respawn w domyślnej pozycji
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
            Player.isDestroyed = true;
            DestroyAll(); //enemy's niszczą nas(not only)
            collision.gameObject.transform.position = respawn; //ustawianie pozycji na nowo

            GameManager.lives--;  //życie mniej
            GameManager.playGame = false;  //info o zupełnej przegranej
        }
        if(collision.gameObject.tag == "Finish")  //kolizja ze ścianą
        {
            Destroy(enemyProjectile);    //i samozniszczenie pocisku
        }

    }

    void DestroyAll()    //na końcu niszczymy wszystko
    {
        Destroy(enemyProjectile);
        projectiles = GameObject.FindGameObjectsWithTag("EnemyProjectile");
        for (var i = 0; i < projectiles.Length; i++)
        {
            Destroy(projectiles[i]);
        }
    }



}
