using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int hearts = 3;
    private int damageTaken = 1;

    public int gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //change Input.GetKeyDown to when the enemys gets behind the screen
        if (Input.GetKeyDown(KeyCode.B))
        {
            hearts = hearts - damageTaken;
            Debug.Log("YOU TOOK DAMAGE, " + hearts + " Hearts Left");
        }
    }
}
