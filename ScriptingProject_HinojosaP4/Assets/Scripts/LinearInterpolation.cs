using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    /*
    //Takes 3 float parameters:one representing the value to interpolate from; another representing the value to interpolate to and a final float representing how far to interpolate
    //In this case,result = 4
    float result = Mathf.Lerp(3f, 5f, 0.5f);
    
    //
    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);

    Vector3 result = Vector3.Lerp (from, to, 0.75f)

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Over several frames, the light intesity will tend towards 8 but the rate of its change will slow as it approaches its target
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);

        //Change of intensity happens per second instead of per frame
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    }
   */
}
