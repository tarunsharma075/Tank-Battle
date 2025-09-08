
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movement;
    public float rotation;
    public TankTypes TankType;
    public Material color;


    public TankModel( float movement,
        float rotation,
        TankTypes TankType,
         Material color)

    {
        this.movement = movement;
        this.rotation = rotation;
        this.TankType = TankType;
        this.color = color;


    }

    public void SetTank(TankController controller)
    {

        tankController = controller;
    }

}
