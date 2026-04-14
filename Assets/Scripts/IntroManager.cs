using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroManager : MonoBehaviour
{
    public TMP_Text introText;

    private int currentStep = 0;

    string[] texts = new string[]
{
    "Hola, soy Luka Sabatella...",

    "Bienvenido a esta experiencia personal, donde vas a conocer una parte de mí...",

    "Esto es POETRY.",

    "POETRY no es simplemente un juego...",

    "Es una experiencia que refleja lo que sentimos.",

    "La poesía suele verse como algo extraño hoy en día...",

    "Algo innecesario.",

    "Pero como se dice en 'La sociedad de los poetas muertos'...",

    "No escribimos poesía solo porque sea bonita...",

    "Lo hacemos porque estamos vivos.",

    "Porque sentimos.",

    "Porque hay cosas dentro nuestro que necesitan salir.",

    "POETRY refleja una parte de mí...",

    "Pero también puede reflejar una parte de vos.",

    "No se trata de ganar.",

    "Se trata de expresarte.",

    "De escribir.",

    "De liberar lo que llevás dentro.",

    "Ahora te toca a vos escribir tu propio verso. CARPE DIEM"
};

    public void NextStep()
    {
        currentStep++;

        if (currentStep < texts.Length)
        {
            introText.text = texts[currentStep];
        }
        else
        {
            SceneManager.LoadScene("Game");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextStep();
        }
    }

    void Start()
    {
        introText.text = texts[currentStep];
    }
}