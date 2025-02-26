using UnityEngine;

public class MyCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }
         private void OnCollisionEnter(Collision collision)
    {
        GetComponent< Renderer >().material.color = Color.yellow;

        collision.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
    }
    // Update is called once per frame
    void Update()
    {
   
    }
}
