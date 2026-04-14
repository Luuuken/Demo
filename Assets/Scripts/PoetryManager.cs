using UnityEngine;
using TMPro;

public class PoetryManager : MonoBehaviour
{
    public TMP_InputField inputField;

    public void GuardarPoema()
    {
        string poema = inputField.text;

        Debug.Log("Poema del jugador:");
        Debug.Log(poema);
    }
}