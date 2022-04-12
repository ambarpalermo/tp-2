using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validarcontraseña : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textomsj;
    public GameObject cartel;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContraseña()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartel.SetActive(true);
            textomsj.text = "¡Bienvenido!";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartel.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
