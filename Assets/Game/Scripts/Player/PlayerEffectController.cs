using UnityEngine;

public class PlayerEffectController : MonoBehaviour
{
    [SerializeField] private GameObject _goldParticlePrefab;
    [SerializeField] private ParticleSystem _goldParticleEffect;
    public void PLayGoldParticleEffect(Vector3 position)
    {
        _goldParticleEffect.transform.position = position;
        _goldParticleEffect.Play();
    }

    public void CreateParticleEffect(Vector3 position)
    {
        GameObject particle = Instantiate(_goldParticlePrefab,position,Quaternion.identity);
        
        particle.GetComponent<ParticleSystem>().Play();
        
    }
}
