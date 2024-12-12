using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    public bool isDead= false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)

        {

            SceneManager.LoadScene(2);

        }
    }
    
    private void OnCollisionEnter2D (Collision2D collison)
    {
        if(collison.gameObject.CompareTag("Player"))

        {

            isDead = true;

        }

     }
    
}

