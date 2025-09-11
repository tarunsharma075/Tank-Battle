using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController

{

    

    private BulletView bulletview;
   public  BulletController(BulletView bulletView)
    {

        this.bulletview = bulletView;
    }   
    

    public void Fire(Rigidbody rb, Transform pos)
    {
      rb.velocity = pos.forward*30;

    }
}
