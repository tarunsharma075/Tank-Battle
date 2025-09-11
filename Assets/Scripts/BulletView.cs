using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    [SerializeField]
   
    BulletController bulletController;
    [SerializeField]
    GameObject bulletprefab;
    float firerate = 0f;
    float firecooldown = 0.5f;

    void Start()
    {
        bulletController= new BulletController(this);
    }

    
    void Update()
    {
        
        firerate += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space)&& firerate>firecooldown)
        {
            Debug.Log("space pressed");
            firerate = 0f;
            var Bullet = Instantiate(bulletprefab, this.transform.position, this.transform.rotation);
            Rigidbody rb = Bullet.GetComponent<Rigidbody>();
            Transform pos= Bullet.GetComponent<Transform>();
            bulletController.Fire(rb, pos);
            Destroy(Bullet, 5f);


        }

    }
}
