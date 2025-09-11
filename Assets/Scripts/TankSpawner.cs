using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{

    [System.Serializable]

    public class Tank
    {
        public float movement;
        public float rotation;
       public TankTypes TankTypes;
        public Material color;


    }
   public  List<Tank> Tanks;

    [SerializeField] 
    public  TankView  tankview;

    void Start()
    {
       

    }

    public void CreateTank(TankTypes type)
    {
        if (type == TankTypes.GreenTank)
        {
            TankModel tankmodel = new TankModel(Tanks[0].movement,
                Tanks[0].rotation,
                Tanks[0].TankTypes,
                Tanks[0].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);
        } else if (type == TankTypes.BlueTank)
        {

            TankModel tankmodel = new TankModel(Tanks[1].movement,
               Tanks[1].rotation,
               Tanks[1].TankTypes,
               Tanks[1].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);

        }else if(type == TankTypes.RedTank)
        {

            TankModel tankmodel = new TankModel(Tanks[2].movement,
               Tanks[2].rotation,
               Tanks[2].TankTypes,
               Tanks[2].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);
        }
    }

    
    
}
