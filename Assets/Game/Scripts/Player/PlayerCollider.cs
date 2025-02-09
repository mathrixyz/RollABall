using UnityEngine;
using static UnityEngine.ParticleSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private PlayerEffectController _playerEffect;
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.CompareTag("Gold"))
        {           
            Destroy(other.gameObject); 
            
            GoldController.Instance.IncreaseGold();
            //_playerEffect.PLayGoldParticleEffect(other.transform.position);
            _playerEffect.CreateParticleEffect(other.transform.position);
            GoldCreator.instance.DecreaseGoldCount();
            
        }

       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            GoldController.Instance.DecreasedGold();
            //UiManager.Instance.OpenFailedLevelPanel();
            UiManager.Instance.OpenPanel(UiManager.Instance.failedLevelPanel);
        }
    }

}
