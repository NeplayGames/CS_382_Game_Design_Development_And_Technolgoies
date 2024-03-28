using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private bool isClicked = false;
    void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("Apple")){
            Destroy(collision.gameObject);
        }
    }

    void Update(){
       
        DetermineIfMousePress();
        DetermineIfMouseClickReleased();
        if(isClicked)
            transform.position = new Vector3(DetermineBasketXPosition(), transform.position.y, transform.position.z);
    }

    private void DetermineIfMouseClickReleased()
    {
        if(Input.GetMouseButtonUp(0)){
            isClicked = false;
        }
    }

    private void DetermineIfMousePress()
    {
       if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit)){
                if(hit.transform.CompareTag("Basket")){
                    isClicked = true;
                }
            }
       }
    }

    private float DetermineBasketXPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
       // mousePosition.z -= Camera.main.transform.position.z - transform.position.z;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        return worldMousePosition.x;
    }
}
