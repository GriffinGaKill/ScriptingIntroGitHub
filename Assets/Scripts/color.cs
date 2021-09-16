using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public Gradient cycleColors;

    public Color startColor;
    public Color midColor;
    public Color endColor;
    public float fullCycleTime = 18;
    float currentLerping = 0;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = startColor;
    }

    // Update is called once per frame
    void Update()
    {
        //Method A for regular Lerping, manually inverse
        /*currentLerping += (1 / (fullCycleTime / 3)) * Time.deltaTime;*/

        //Method B using inverse Lerping, calculate how much time has passed between each cycle
        currentLerping = Mathf.InverseLerp(0, fullCycleTime / 3, currentLerping * (fullCycleTime / 3) + Time.deltaTime);

        //Method C keeping track of time and just inverse lerping

        Camera.main.backgroundColor = cycleColors.Evaluate(0);


       //if (currentLerping >= 0 && currentLerping < (1f/3) )
       // {
       //     Camera.main.backgroundColor = Color.Lerp(startColor, midColor, currentLerping * 3);

       // }
       // else if (currentLerping >= 1 && currentLerping < (2f/3) )
       // {
       //     Camera.main.backgroundColor = Color.Lerp(startColor, midColor, 
       //         (currentLerping - ( 1f/3 )) * 3);
       // }
       // else if (currentLerping >= 2 && currentLerping < (3f/3) )
       // {
       //     Camera.main.backgroundColor = Color.Lerp(startColor, midColor, 
       //         (currentLerping - ( 2f/3 )) * 3);
       // }
       //  else
       //  {
       //      currentLerping = 0;
       // }
    }
}
