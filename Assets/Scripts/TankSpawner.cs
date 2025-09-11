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
       CreateTank();

    }

    public void CreateTank()
    {
       TankModel tankmodel= new TankModel(
           tanks[1].movement,
           tanks[1].rotation,
           tanks[1].color);
        TankController tankcontroller = new TankController(tankview, tankmodel);
        
    }

    
    
}
