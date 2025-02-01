using UnityEngine;

public class GoldRotator : MonoBehaviour
{
    [SerializeField] private float _xVector;
    [SerializeField] private float _yVector;
    [SerializeField] private float _zVector;

    private void Start()
    {
        _xVector = Random.Range(0f, 180f);
        _yVector = Random.Range(0f, 180f);
        _zVector = Random.Range(0f, 180f);
    }
    void Update()
    {
        transform.Rotate(new Vector3(_xVector,_yVector,_zVector)*Time.deltaTime);
    }
}
