using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
       public  float movementspeed;
       public  float rotationspeed;
       public  TankTypes tankTypes;
       public Material color;

    }

    public List<Tank> Tanks;



    [SerializeField] 
    public  TankView  tankview;

    

    void Start()
    {
       CreateTank();

    }

    public void CreateTank()
    {
        TankModel tankmodel= new TankModel(Tanks[2].movementspeed, 
            Tanks[2].rotationspeed,
            Tanks[2].tankTypes,
            Tanks[2].color);
        TankController tankcontroller = new TankController(tankview, tankmodel);
        
    }

    
    
}
