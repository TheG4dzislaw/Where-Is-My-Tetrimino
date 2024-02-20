using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetrimino_Spawner : MonoBehaviour
{
    public int nextTetriminoIndex;               
    public GameObject currentTetrimino;         //Variable to store the current block gameobject
    [SerializeField] GameObject[] Tetriminos;
    [SerializeField] Vector3 SpawnLocation = new Vector3 (0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        nextTetriminoIndex = -1;
        currentTetrimino = null;

    }

    // Update is called once per frame
    void Update()
    {
        if(currentTetrimino == null)
        {
            ChooseNextTetrimino();
        }
    }

    private void ChooseNextTetrimino()
    {
        nextTetriminoIndex = Random.Range(0, Tetriminos.Length);
        SpawnTetrimino();
    } 

    private void SpawnTetrimino()
    {
        //Spawn Tetrimino depends of the index that was selected in variable nextTetriminoIndex, on location declarate in variable SpawnLocation
        currentTetrimino = Instantiate(Tetriminos[nextTetriminoIndex], SpawnLocation, Quaternion.identity) as GameObject;

    }
}