using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int currentLifePoints;

    [SerializeField]
    private int maxLifePoints;

    [SerializeField]
    private TextMeshProUGUI currentLifePointsText;

    public void TakeDamage()
    {
        currentLifePoints = Mathf.Clamp(
            currentLifePoints - 1,
            0,
            maxLifePoints
        );
        currentLifePointsText.SetText(currentLifePoints.ToString());
    }

}
 
