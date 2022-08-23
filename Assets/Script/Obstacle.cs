using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject _player = default;

    private void Awake()
    {
        _player = GameObject.Find("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(_player);
        }
    }
}
