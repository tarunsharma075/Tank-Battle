using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] 
    public  TankView  tankview;

    void Start()
    {
       CreateTank();

    }

    public void CreateTank()
    {
        TankModel tankmodel= new TankModel();
        TankController tankcontroller = new TankController(tankview, tankmodel);
        
    }

    
    
}
