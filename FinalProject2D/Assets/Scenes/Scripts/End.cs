using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public bool isDead= false; 
    // Start is called before the first frame update
    void Start()
    {
         if (isDead)

        {

            SceneManager.LoadScene(3);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter2D (Collision2D collison)
    {
        if(collison.gameObject.CompareTag("Player"))

        {

            isDead = true;

        }

     }
}