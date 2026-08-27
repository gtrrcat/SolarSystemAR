using UnityEngine;

public class PlanetInfoTrigger : MonoBehaviour
{
    [Header("Ссылка на UI менеджер")]
    [SerializeField] private PlanetInfoManager planetInfoManager;
    [Header("Данные планеты")]
    [SerializeField] private string planetName;
    [TextArea(3, 5)]
    [SerializeField] private string planetDescription;

    public void ShowInfo()
    {
        if (planetInfoManager != null)
        {
            planetInfoManager.ShowInfo(planetName, planetDescription);
        }
    }
    
}
