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
    public bool lerp = true;

    //initalize Image render
    public SpriteRenderer renderer;

    //======================================+=========================================

    // Start is called before the first frame update
    void Start()
    {
        //Grabs the renderer of the sprite
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //==================================Lerping======================================
        //Detects if lerp is active
        if (lerp == true)
        {
            //Activates renderer
            this.renderer.enabled = true;
                
            //Makes the image grow
            transform.localScale = new Vector2(Mathf.Lerp(minimumX, maximumX, t), Mathf.Lerp(minimumY, maximumY, t));

            //Makes image grow over a set time
            t += t * Time.deltaTime;     
        }

        //Detects if lerp is deactivated
        if (lerp == false)
        {
            //Deactivates renderer
            this.renderer.enabled = false;
        }

        //======================================+=========================================

    }
}
