using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private float _maxTime = 1.5f;

    [SerializeField]
    private float _HighRange = 0.45f;

    [SerializeField]
    private GameObject _pipePrefab;


    private void Start() => spawnPipe();

    private float timer;
    private void Update()
    {
       if(timer > _maxTime)
       {
            spawnPipe();
            timer = 0;
       }

       timer += Time.deltaTime;
    }


    private void spawnPipe()
    {
        Vector3 spawnPos = transform.position 
            + new Vector3(0, Random.Range(-_HighRange, +_HighRange));

        GameObject newPipe = Instantiate(_pipePrefab, spawnPos, Quaternion.identity);

        Destroy(newPipe, 10f);
    }
}
