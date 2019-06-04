using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _bronxWaveManager : MonoBehaviour
{
    public enum SpawnState { Spawning, Waiting, Counting};

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] _waves;

    public Transform[] spawnPoints;

    private int nextWave = 0;

    public float _otroTimer = 3f;
    public float timeBetweenWaves = 2f;
    public float waveCountDown;
    private float searchCountdown = 1f;

    public bool Jugando;
    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;

        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
            return true;
    }

    private SpawnState state = SpawnState.Counting;

    private void Start()
    {
        waveCountDown = timeBetweenWaves;

    }

    private void Update()
    {
        if (Jugando == true)
        {
            if (state == SpawnState.Waiting)
            {
                if (!EnemyIsAlive())
                {
                    waveCompleted();
                    return;
                }
                else
                {
                    return;
                }
            }

            if (waveCountDown <= 0)
            {
                if (state != SpawnState.Spawning)
                {
                    StartCoroutine(SpawnWave(_waves[nextWave]));
                }
            }
            else
            {
                waveCountDown -= Time.deltaTime;
            }
        }

        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            _otroTimer = 5;
            Jugando = true;
        }

    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave.name);
        state = SpawnState.Spawning;

        for(int i =0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.Waiting;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        Debug.Log("Spawning enemy" + _enemy.name);
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];

        Instantiate(_enemy, _sp.position, _sp.rotation);
    }

    void waveCompleted()
    {
        state = SpawnState.Counting;

        waveCountDown = timeBetweenWaves;

        if (nextWave + 1> _waves.Length - 1)
        {
            nextWave = 0;
        }
        else
        {
            nextWave++;
        }
    }
}
