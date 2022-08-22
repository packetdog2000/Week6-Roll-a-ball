using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{

    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Collectible").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void Pickup()
    {
        counter--;
        if(counter == 0)
                
        Debug.Log("Pickup received");
    }


}
