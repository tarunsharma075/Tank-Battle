using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankChoice : MonoBehaviour
{

    public TankSpawner tankSpawner;
    public void ChooseGreenTank()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        gameObject.SetActive(false);
    }
    public void ChooseBlueTank()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        gameObject.SetActive(false);

    }
    public void ChooseRedTank()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        gameObject.SetActive(false);

    }
}
