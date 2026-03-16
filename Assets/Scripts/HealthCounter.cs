using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class HealthCounter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI healthText;

    [SerializeField]
    private IntVariable playerCurrentLifePoints;

    [SerializeField]
    private IntVariable playerMaxLifePoints;

    [SerializeField]
    private VoidEventChannel onPlayerTakeDamage;

    private void OnEnable()
    {
        onPlayerTakeDamage.OnEventRaised += UpdateHealthText;
        UpdateHealthText(); 
    }

    private void Start()
    {
        UpdateHealthText(); 
    }

    private void OnDisable()
    {
        onPlayerTakeDamage.OnEventRaised -= UpdateHealthText;
    }

    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = playerCurrentLifePoints.CurrentValue + "/" + playerMaxLifePoints.CurrentValue;
        }
    }
}


  






