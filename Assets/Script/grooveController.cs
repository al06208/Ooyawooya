using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class grooveController : MonoBehaviour {
    public GameObject groove;
    //same shit as the schutController but for Grooves
    Vector3 left = new Vector3((float)-8.6, 7, (float)-.9);
    Vector3 right = new Vector3((float)8.6, 7, (float).9);

	void Start () {
        Koreographer.Instance.RegisterForEvents("KoreoGroove", GrooveEvent);
    }
    //at the moment, grooves simply fly downwards as soon as they're spawned. Should there be more warning? probably.
    //they take a beat to reach the target zone (grass debug texture) so I spawn them a beat early.
    //todo: audio warnings or something I dunno
    void GrooveEvent(KoreographyEvent korEvent)
    {
        int place = korEvent.GetIntValue();
        switch (place)
        {
            case 0:
                GameObject groove1 = Object.Instantiate(groove, left, Quaternion.identity);
                break;
            case 1:
                GameObject groove2 = Object.Instantiate(groove, right, Quaternion.identity);
                break;
            default:
                break;
        }
        
    }

}
