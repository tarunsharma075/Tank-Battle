using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{ private TankController tankController;

    private  float movement;
    private float rotation;
    [SerializeField]
    private Rigidbody rb;
    public MeshRenderer[] childs;
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(this.transform);
        cam.transform.localPosition = new Vector3(0f, 3f, -8.45f);

    }

  
    void Update()
    {
        MoveMent();
        if(movement!= 0)
        {
            tankController.MoveTank(movement, tankController.GetTankModel().movement);
        }

        if(rotation != 0)
        {
            tankController.RotateTank(rotation, tankController.GetTankModel().rotation);
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

   public void changeColor(Material color)
    {
        foreach (var child in childs)
        {
            child.material = color;
        }
    }
}

