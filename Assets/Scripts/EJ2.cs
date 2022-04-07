using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2.Solicitar el ingreso del precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
public class EJ2 : MonoBehaviour
{
	public float producto1;
	public float producto2;
	public float producto3;
	public float monto;
	// Start is called before the first frame update
	void Start()
    {
		float suma;
		float falta;
		float resto;
		suma = producto1 + producto2 + producto3;
		falta = suma - monto;
		resto = monto - suma;
		if (suma > monto)
		{
			Debug.Log("La suma supera al monto disponible y a usted le faltan " + falta + " pesos ");
		}
		else if (suma <= monto)
		{
			Debug.Log("La suma no supera al monto disponible y a usted le sobran " + resto + " pesos ");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
