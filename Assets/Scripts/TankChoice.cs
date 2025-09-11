using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankChoice:MonoBehaviour
{
    [SerializeField]
    private TankSpawner tankspawner;
    public void ChooseGreenTank()
    {

        tankspawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);

    }
    public void ChooseBlueTank()
    {
        tankspawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);

    }
    public void ChooseRedTank()
    {
        tankspawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);

    }

}


