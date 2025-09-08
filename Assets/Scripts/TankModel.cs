
public class TankModel
{
    private TankController tankController;
    public float movement;
    public float rotation;


    public TankModel( float movement,float rotation)

    {
        this.movement = movement;
        this.rotation = rotation;


    }

    public void SetTank(TankController controller)
    {

        tankController = controller;
    }

}
