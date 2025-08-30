using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{ private TankController tankController;

    private float movement;
    private float rotation;

    [SerializeField]
    private Rigidbody rb;
    void Start()
    {
        
    }

  
    void Update()
    {
        MoveMent();
        if(movement!= 0)
        {
            tankController.MoveTank(movement, 30f);
        }

        if(rotation != 0)
        {
            tankController.RotateTank(rotation, 100f);
        }

    }

    public void SetTank(TankController controller)
    {

        tankController = controller;
    }

    private void MoveMent()
    {
        movement = Input.GetAxis("Vertical");
        rotation= Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

}

