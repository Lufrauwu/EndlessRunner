
using UnityEngine;

public class LevelBoundry : MonoBehaviour
{
    public static float _leftSide = -3.5f;
    public static float _rightSide = 3.5f;
    [SerializeField] private float _internalLeft = default;
    [SerializeField] private float _internalRight = default;
    void Update()
    {
        _internalLeft = _leftSide;
        _internalRight = _rightSide;
    }
}
