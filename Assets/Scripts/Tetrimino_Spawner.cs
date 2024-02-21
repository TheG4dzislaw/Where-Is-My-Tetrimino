using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetrimino_Spawner : MonoBehaviour
{
    public int nextTetriminoIndex;               
    public GameObject currentTetrimino;
    [SerializeField] GameObject[] Tetriminos;
    //SPAWN LOCATION MAY BE CHANGED IN FUTURE
    [SerializeField] Vector3 SpawnLocation = new Vector3 (0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        //Set both variables out of range to avoid errors
        nextTetriminoIndex = -1;
        currentTetrimino = null;
    }

    // Update is called once per frame
    void Update()
    {
        //Condition that if there is no tetrimino on stage create new one
        if(currentTetrimino == null)
        {
            ChooseNextTetrimino();
        }

        //TEST IF TETRIMINO WILL BE CHANGED AFTER PRESSING BUTTON!!!
        if(Input.GetKeyDown("n"))
        {
            Destroy(currentTetrimino);
            ChooseNextTetrimino();
        }
        //TEST IF TETRIMINO WILL BE CHANGED AFTER PRESSING BUTTON!!!
    }

    private void ChooseNextTetrimino()
    {
        //Generate random number assigned to specific Tetrimino Object in Array
        nextTetriminoIndex = Random.Range(0, Tetriminos.Length);
        SpawnTetrimino();
    } 

    private void SpawnTetrimino()
    {
        //Spawn Tetrimino depends of the index that was selected in variable nextTetriminoIndex, on location declarate in variable SpawnLocation
        currentTetrimino = Instantiate(Tetriminos[nextTetriminoIndex], SpawnLocation, Quaternion.identity) as GameObject;
    }
}