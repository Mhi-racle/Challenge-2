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
         
         if (Input.GetKeyDown(KeyCode.Space))
        {
           yield return new WaitForSeconds(delayTime);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
