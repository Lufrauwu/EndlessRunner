using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _platformPrefab = default;
    [SerializeField] private GameObject _obstaclePrefab = default;
    [SerializeField] private GameObject _spawnPoit = default;
    [SerializeField] private GameObject _spawn1 = default;
    [SerializeField] private GameObject _spawn2 = default;
    [SerializeField] private GameObject _spawn3 = default;
    private int _randomNumber = default;

    private void OnTriggerEnter(Collider other)
    {
        SpawnPlatform();
        SpawnObstacles();
    }

    private void SpawnPlatform()
    {
        Instantiate(_platformPrefab, _spawnPoit.transform.position, Quaternion.identity);
        _randomNumber = Random.Range(1, 6);
        Destroy(_platformPrefab, 5f);
    }

    private void SpawnObstacles()
    {
        switch (_randomNumber)
        {
            case 1:
                Instantiate(_obstaclePrefab, _spawn1.transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(_obstaclePrefab, _spawn1.transform.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(_obstaclePrefab, _spawn2.transform.position, Quaternion.identity);
                break;
            case 4:
                Instantiate(_obstaclePrefab, _spawn2.transform.position, Quaternion.identity);
                break;
            case 5:
                Instantiate(_obstaclePrefab, _spawn3.transform.position, Quaternion.identity);
                break;
            case 6:
                Instantiate(_obstaclePrefab, _spawn3.transform.position, Quaternion.identity);
                break;
            default:
                return;
        }
    }
    
}
