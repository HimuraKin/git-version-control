using UnityEngine;

public class MyTrigger : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        other.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
