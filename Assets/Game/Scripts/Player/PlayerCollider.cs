using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.CompareTag("Gold"))
        {           
            Destroy(other.gameObject);                       
            GoldController.Instance.IncreaseGold();           
        }

       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            GoldController.Instance.DecreasedGold();
        }
    }

}
