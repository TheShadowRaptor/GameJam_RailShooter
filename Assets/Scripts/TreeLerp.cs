using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLerp : MonoBehaviour
{
    //=====================================Initalize========================================
    //initalize maximum and minimum values of Lerp

    //for X transform scale value
    public float minimumScaleX = 0;
    public float maximumScaleX = 0;

    //for Y transform scale value
    public float minimumScaleY = 0;
    public float maximumScaleY = 0;

    //for X transform scale value
    public float minimumPosX = 0;
    public float maximumPosX = 0;

    //for Y transform scale value
    public float minimumPosY = 0;
    public float maximumPosY = 0;

    //initalize time it takes to complete Lerp
    public float t = 0;

    //initalize time reset
    public float timeReset;

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
            transform.localScale = new Vector2(Mathf.Lerp(minimumScaleX, maximumScaleX, t), Mathf.Lerp(minimumScaleY, maximumScaleY, t));
            transform.position = new Vector2(Mathf.Lerp(minimumPosX, maximumPosX, t), Mathf.Lerp(minimumPosY, maximumPosY, t));

            //Makes image grow over a set time
            t += t * Time.deltaTime;     
        }

        //Detects if lerp is deactivated
        if (lerp == false)
        {
            //Deactivates renderer
            this.renderer.enabled = false;

            //resets Lerp
            t = timeReset;

        }

        //======================================+=========================================

    }
}
