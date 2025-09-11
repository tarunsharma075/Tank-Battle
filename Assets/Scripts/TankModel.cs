
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movement;
    public float rotation;
    public Material color;

    public TankModel(
        float movement,
        float rotation,
        Material color
       )

    {
        this.movement = movement;
        this.rotation = rotation;
        this.color = color;
       

    }

    public void SetTank(TankController controller)
    {

        tankController = controller;
    }

}
