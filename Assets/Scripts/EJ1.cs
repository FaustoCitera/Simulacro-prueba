using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1.Crea un programa que pida dos números al usuario y responda si son iguales o no lo son.
public class EJ1 : MonoBehaviour
{
	public int num1;
	public int num2;
    // Start is called before the first frame update
    void Start()
    {
		if (num1 == num2)
		{
			Debug.Log("Los numeros son iguales");
		}
		else
		{
			Debug.Log("Los numeros no son iguales");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
