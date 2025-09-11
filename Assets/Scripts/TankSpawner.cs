using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] 
    public  TankView  tankview;

    [System.Serializable]

    public class Tank
    {
        public float movement;
        public float rotation;
        public Material color;
        public TankTypes TankType;

    }

    public List<Tank> tanks;

    void Start()
    {
       

    }

    public void CreateTank(TankTypes tanktype)
    {


        if (tanktype == TankTypes.GreenTank)
        {

            TankModel tankmodel = new TankModel(
                tanks[0].movement,
                tanks[0].rotation,
                tanks[0].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);
        }else if(tanktype == TankTypes.BlueTank)
        {


            TankModel tankmodel = new TankModel(
                tanks[1].movement,
                tanks[1].rotation,
                tanks[1].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);

        }
        else if(tanktype == TankTypes.RedTank)
        {

            TankModel tankmodel = new TankModel(
                tanks[2].movement,
                tanks[2].rotation,
                tanks[2].color);
            TankController tankcontroller = new TankController(tankview, tankmodel);

        }
        
    }

    
    
}
