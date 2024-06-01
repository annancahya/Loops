using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowtoProgram5 : MonoBehaviour
{
    private void Start()
    {

        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log("Restart atau tidak: " + i);
        //}   

        // Cara lain untuk looping
        int i = 0;
        while (i < 5)
        {
            Debug.Log("The value of i: " + i);
            i++;
        }
        
    }

}
