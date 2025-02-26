using UnityEngine;

public class MyTorque : MonoBehaviour
{
   public float force , torque;

     private void OnCollisionEnter(Collision collision)
    {
        GetComponent< Renderer >().material.color = Color.yellow;

        collision.gameObject.GetComponent<Renderer>().material.color = Color.green;

        GetComponent< Rigidbody >().AddForce(0, force, 0);

        GetComponent< Rigidbody >().AddTorque(0, torque, 0);
        Destroy( gameObject , 5 );
    }

}///
