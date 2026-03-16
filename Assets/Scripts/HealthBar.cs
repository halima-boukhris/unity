using UnityEngine;
using UnityEngine.UI;
 
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Image fillImage;

    [SerializeField]
    private Gradient gradient;

    [SerializeField]
    private IntVariable playerCurrentLifePoints;

    [SerializeField]
    private IntVariable playerMaxLifePoints;

    [SerializeField]
    private VoidEventChannel onPlayerTakeDamage;

    private void OnEnable()
    {
        onPlayerTakeDamage.OnEventRaised += SetHealth; //permet de s'abonner à l'événement de prise de dégâts du joueur
            SetHealth(); //permet de mettre à jour la barre de vie au moment où le script est activé
    }

    private void OnDisable()
    {
        onPlayerTakeDamage.OnEventRaised -= SetHealth; //permet de se désabonner de l'événement de prise de dégâts du joueur
    }
    private void SetHealth()
    {
        float healthNormalized = (float)playerCurrentLifePoints.CurrentValue / playerMaxLifePoints.CurrentValue; //permet de calculer le pourcentage de vie restant
        fillImage.fillAmount = healthNormalized; //permet de faire varier la taille de la barre de vie en fonction du pourcentage de vie restant
        fillImage.color = gradient.Evaluate(healthNormalized); //permet de faire varier la couleur de la barre de vie en fonction du pourcentage de vie restant
    }
}
 