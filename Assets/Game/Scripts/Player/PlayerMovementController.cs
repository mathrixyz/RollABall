using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private float _horizontalAxis, _verticalAxis;

    private void FixedUpdate()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        _verticalAxis = Input.GetAxis("Vertical");

        //Debug.Log("HORIZONTAL : " + _horizontalAxis);
        //Debug.Log("VERTICAL : " + _verticalAxis);
        Debug.Log(Time.fixedDeltaTime);
        transform.Translate(_horizontalAxis*Time.fixedDeltaTime*_movementSpeed, 0, _verticalAxis * Time.fixedDeltaTime*_movementSpeed);

    }
}
