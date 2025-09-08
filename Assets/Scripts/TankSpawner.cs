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
      

    }

    public void CreateTank(TankTypes tanktype)
    {
        if (tanktype == TankTypes.GreenTank)
        {
            TankModel tankmodel = new TankModel(
                Tanks[0].movementspeed,
                Tanks[0].rotationspeed,
                Tanks[0].tankTypes,
                Tanks[0].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);
        }
        else if (tanktype == TankTypes.BlueTank)
        {
            TankModel tankmodel = new TankModel(
               Tanks[1].movementspeed,
               Tanks[1].rotationspeed,
               Tanks[1].tankTypes,
               Tanks[1].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);

        }
        else if(tanktype == TankTypes.RedTank)
        {
            TankModel tankmodel = new TankModel(
                Tanks[2].movementspeed,
                Tanks[2].rotationspeed,
                Tanks[2].tankTypes,
                Tanks[2].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);


        }

    }
    
}
