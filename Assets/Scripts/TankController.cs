
using UnityEngine;

public class TankController 
{
    private TankView tankView;
    private TankModel tankModel;
    private Rigidbody rb;
    
public TankController(TankView view, TankModel model)
    {
        this.tankView = GameObject.Instantiate<TankView>(view);
        this.tankModel = model;
        rb= tankView.GetRigidbody();
        tankView.SetTank(this);
        tankModel.SetTank(this);
        //GameObject.Instantiate(tankView);
    }

   public void MoveTank(float movement,float movementspeed)
    {
        rb.velocity= tankView.transform.forward * movement * movementspeed;

    }

    public  void RotateTank(float rotation,float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f, rotation * rotationSpeed , 0f);
        Quaternion deltarotation = Quaternion.Euler(vector*Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltarotation);
    }   

    public TankModel GetTankModel()
    {
        return tankModel;
    }

}
