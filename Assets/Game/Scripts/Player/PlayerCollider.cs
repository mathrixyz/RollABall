using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int _goldPoint=0, _sumPoint=0;
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.CompareTag("Gold"))
        {
            _goldPoint += 1;
            _sumPoint += _goldPoint;
            Destroy(other.gameObject);
            Debug.Log("Kazanılan Puan :" + _goldPoint + "  Toplam Puan :" + _sumPoint);                            
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{ 
    //    if (collision.collider.CompareTag("Gold"))
    //    {
    //        Debug.Log("Temas Gerçekleşti");
    //    }
    //}
}
