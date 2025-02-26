using UnityEngine;

public class MyForce : MonoBehaviour
{
public float force;
    void Update()
    {
        
        if ( Input.GetKeyDown ( KeyCode.Space ))
        {
            GetComponent< Rigidbody >().AddForce(force, 0,0);
        }
 
        if ( Input.GetMouseButtonDown (1) )
        {
            GetComponent<Rigidbody>().AddForce(force * force, 0, 0);
        }
 
 
    }// Update
}//ทำซ้ำตลอด
