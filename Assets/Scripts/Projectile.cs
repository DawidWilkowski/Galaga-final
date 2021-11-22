using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Projectile : MonoBehaviour
{
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));    //wystrzelony pocisk leci w kierunku N
    }

    private void OnCollisionEnter2D(Collision2D collision)    //kolizje z enemy's
    {
        if(collision.gameObject.tag == "Enemy")    //tag do enemy
        {
            Enemy.isDestroyed = true;
            Destroy(collision.gameObject);  //niszcz enemy poddane kolizji
            Destroy(projectile);            //niszcz pocisk
            GameManager.playGame = true;
        }
        if(collision.gameObject.tag == "Finish")     //kolizje ze ścianą
        {
            Destroy(projectile);                     //niszcz pocisk
        }

    }
}
