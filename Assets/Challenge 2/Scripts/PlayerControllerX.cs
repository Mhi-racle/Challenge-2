using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delayTime = .5f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
       StartCoroutine(instantiateDog());
    }

    IEnumerator instantiateDog(){
         yield return new WaitForSeconds(delayTime);
         if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
