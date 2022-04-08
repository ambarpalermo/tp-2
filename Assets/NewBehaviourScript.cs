using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int miedad;
    public Text mitexto;

    // Start is called before the first frame update
    void Start()
    {
        if(miedad >= 18)
        {
            mitexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            mitexto.text = "Es menor de edad";
            Debug.Log("Es menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
