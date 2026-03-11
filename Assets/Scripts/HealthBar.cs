using UnityEngine;
using UnityEngine.UI;
 
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Image fillImage;

    [SerializeField]
    private Gradient gradient;



    public void SetHealth(float healthNormalized)
    {
        fillImage.fillAmount = healthNormalized; //permet de faire varier la taille de la barre de vie en fonction du pourcentage de vie restant
        fillImage.color = gradient.Evaluate(healthNormalized); //permet de faire varier la couleur de la barre de vie en fonction du pourcentage de vie restant
    }
}
 