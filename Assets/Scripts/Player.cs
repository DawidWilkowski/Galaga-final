using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject projectile;  //wartość prefab'u
    public GameObject projectileClone;  //multikopie tego samego
    public AudioSource shoot;
    public AudioSource destroy;
    public static bool isDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(isDestroyed == true)
        {
            destroy.Play();
            isDestroyed = false;
        }
        if (GameManager.lives > 0)  //jeśli zginiemy, nie możemy dalej grać
        {
            movement();  //funkcja poruszania player'em
            fireProjectile();  //funkcja wystrzeliwująca
        }
    }

        void movement()  // poruszanie się player'em prawo/lewo
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
    }

    void fireProjectile()   //strzelamy
    {
        if (Input.GetKeyDown(KeyCode.Space) && projectileClone == null)  //strzelamy przecież większą ilością pocisków niż 1
        {
            shoot.Play();
            projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y + 0.6f, 0), player.transform.rotation) as GameObject;


        }
           }

}
