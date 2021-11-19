using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLerp : MonoBehaviour
{
    //=====================================Initalize========================================
    //initalize maximum and minimum values of Lerp

    //for X transform value
    public float minimumX = 0;
    public float maximumX = 0;

    //for Y transform value
    public float minimumY = 0;
    public float maximumY = 0;

    //initalize time it takes to complete Lerp
    public float t = 0;

    //initalize positon of Lerped Object
    public float posX;
    public float posY;

    //initalize Lerp bool
    public bool lurp = true;

    //initalize Image render
    public SpriteRenderer renderer;

    //======================================+=========================================

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //==================================Lerping======================================
        //
        if (lurp == true)
        {
            transform.localScale = new Vector2(Mathf.Lerp(minimumX, maximumX, t), Mathf.Lerp(minimumY, maximumY, t));

            t += t * Time.deltaTime;     
        }

        if (lurp == false)
        {

        }

        //======================================+=========================================

    }
}
