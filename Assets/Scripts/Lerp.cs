using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    //=====================================Initalize========================================
    //initalize maximum and minimum values of Lerp

    //Initalize random range
    public float minPosRangeX;
    public float maxPosRangeX;

    public float minPosRangeY;
    public float maxPosRangeY;
    //for X transform scale value
    public float minimumScaleX = 0;
    public float maximumScaleX = 0;

    //for Y transform scale value
    public float minimumScaleY = 0;
    public float maximumScaleY = 0;

    //for X transform pos value
    public float minimumPosX = 0;
    public float maximumPosX = 0;

    //for Y transform pos value
    public float minimumPosY = 0;
    public float maximumPosY = 0;

    //initalize time it takes to complete Lerp
    public float lerpTime = 0;

    //initalize lerpTime reset
    public float lerpTimeReset;

    //initalize timer
    public float tillRiseTime;

    //initalize timerReset
    public float riseTimeReset;

    //initalize Lerp bool
    public bool lerp = false;

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
            // Changes maximum based on position
            PosChange();

            //Resets Timer
            tillRiseTime = riseTimeReset;

            //Activates renderer
            this.renderer.enabled = true;

            //Transform Loop
            while (lerp == true)
            {
                //Makes the image grow
                transform.localScale = new Vector2(Mathf.Lerp(minimumScaleX, maximumScaleX, lerpTime), Mathf.Lerp(minimumScaleY, maximumScaleY, lerpTime));
                transform.position = new Vector2(Mathf.Lerp(minimumPosX, maximumPosX, lerpTime), Mathf.Lerp(minimumPosY, maximumPosY, lerpTime));

                //Makes image grow over a set time
                lerpTime += lerpTime * Time.deltaTime;

                //Checks if maximum was reached
                if (this.transform.localScale.x == maximumScaleX && this.transform.localScale.y == maximumScaleY)
                {
                    lerp = false;
                    break;
                }
            }
            
        }

        //Detects if lerp is deactivated
        if (lerp == false)
        {
            //Picks a random spawn point
            maxPosRangeX = 0;
            minimumPosX = Random.Range(minPosRangeX, maxPosRangeX);
            minimumPosY = Random.Range(minPosRangeY, maxPosRangeY);

            //Deactivates renderer
            this.renderer.enabled = false;

            //resets Lerp
            lerpTime = lerpTimeReset;

            //Timer Loop
            while (lerp == false)
            {
                Debug.Log("Timer Loop");
                //Subtracts Timer
                tillRiseTime = tillRiseTime - 1 * Time.deltaTime;

                //Clamps Timer
                if (tillRiseTime < 0)
                {
                    tillRiseTime = 0;
                }

                //Checks if timer is finished
                if (tillRiseTime == 0)
                {
                    lerp = true;
                    break;
                }
            }            
        }
        //======================================+=========================================
        void PosChange()
        {                      
            for (int c = 0; c < minPosRangeX; c++)
            {
                maxPosRangeX += 5.6f;
            }
                               
            for (int c = 0; c > minPosRangeX; c--)
            {
                maxPosRangeX += -5.6f;
            }                       
        }
    }
}
