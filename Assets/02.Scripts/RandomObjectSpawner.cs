using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // 생성할 프리팹
    public float spawnInterval = 1f; // 생성 간격 (초)
    public float minX = -5f; // 생성 영역의 최소 X 좌표
    public float maxX = 5f; // 생성 영역의 최대 X 좌표
    public float minY = -5f; // 생성 영역의 최소 Y 좌표
    public float maxY = 5f; // 생성 영역의 최대 Y 좌표

    private void Start()
    {
        // 일정 간격으로 SpawnObject 함수 호출
        InvokeRepeating("SpawnObject", 2f, spawnInterval);
    }

    private void SpawnObject()
    {
        // 무작위 좌표 생성
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        // 프리팹 복제 생성
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}