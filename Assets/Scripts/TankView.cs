using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankView : MonoBehaviour
{ private TankController tankController;

    private  float movement;
    private float rotation;
    [SerializeField]
    private Rigidbody rb;
    public MeshRenderer[] child;
    [SerializeField]
    
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(this.transform);
        cam.transform.localPosition = new Vector3(0f, 3f, -8.45f);
       

    }

  
    void Update()
    {
        MoveMent();

        if (movement!= 0)
        {
            tankController.MoveTank(movement, tankController.GetTankModel().movement);
            Debug.Log("movement is called");
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

    public void ChangeColor(Material color)
    {
        for (int i = 0; i < child.Length; i++)
        {
            child[i].material = color;

        }
    }


   
}

