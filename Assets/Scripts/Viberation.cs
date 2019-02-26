using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viberation : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnGUI()
    {
        if (GUI.Button(new Rect(0, 10, 100, 32), "Vibrate!"))
            Handheld.Vibrate();
    }
}
