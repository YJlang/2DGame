using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // ������ ������
    public float spawnInterval = 1f; // ���� ���� (��)
    public float minX = -5f; // ���� ������ �ּ� X ��ǥ
    public float maxX = 5f; // ���� ������ �ִ� X ��ǥ
    public float minY = -5f; // ���� ������ �ּ� Y ��ǥ
    public float maxY = 5f; // ���� ������ �ִ� Y ��ǥ

    private void Start()
    {
        // ���� �������� SpawnObject �Լ� ȣ��
        InvokeRepeating("SpawnObject", 2f, spawnInterval);
    }

    private void SpawnObject()
    {
        // ������ ��ǥ ����
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        // ������ ���� ����
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}