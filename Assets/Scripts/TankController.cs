
using UnityEngine;

public class TankController 
{
    private TankView tankView;
    private TankModel tankModel;
    
public TankController(TankView view, TankModel model)
    {
        this.tankView = view;
        this.tankModel = model;
        tankView.SetTank(this);
        tankModel.SetTank(this);
        GameObject.Instantiate(tankView);
    }

}
