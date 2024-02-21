using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetrimino_Movement : MonoBehaviour
{
    public double counter;
    [SerializeField] float gridSize = 1;
    //THIS VARIABLE SHOULD BE CHANGE IN NEXT UPDATE - TIME SHOULD BE DECLARETED DEPENDS OF LEVEL NO.
    [SerializeField] double dropTime = 2.0;

    // Start is called before the first frame update
    void Start()
    {
        //Set time needed to drop Tetrimino
        counter = dropTime;
    }

    // Update is called once per frame
    void Update()
    {
        // ___PLAYER INPUTS___
            //Right Movemnet
        if(Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            transform.position += new Vector3(gridSize, 0, 0);
        }
            //Left Movement
        if(Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            transform.position -= new Vector3(gridSize, 0, 0);
        }
            //Rotation
            //InstantDrop
        // ___PLAYER INPUTS___

        //Condition responsible to countdown
        if(counter > 0)
        {
            counter -= Time.deltaTime;
        } 
        else 
        {
            //Execute droping of Tetrimino after specific time
            DropTetrimino();
            //Set new timer to loop this condition - SHOULD BE CHANGED IN FUTURE
            counter = dropTime;
        }

    }

    void DropTetrimino()
    {
        transform.position -= new Vector3(0, gridSize, 0);
    }
}
