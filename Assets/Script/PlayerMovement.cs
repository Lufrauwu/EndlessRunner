using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _playerRigidBody = default;
    [SerializeField] private float _moveSpeed = default;
    [SerializeField] private float _leftRightSpeed = default;

    void Update()
    {
        _playerRigidBody.velocity = transform.forward * _moveSpeed;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundry._leftSide)
            {
                transform.Translate(Vector3.left  * _leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundry._rightSide)
            {
                transform.Translate(Vector3.left * _leftRightSpeed * -1);

            }
        }
    }
}
