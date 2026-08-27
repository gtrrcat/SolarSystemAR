using TMPro;
using UnityEngine;

public class PlanetInfoManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI planetName;
    [SerializeField] private TextMeshProUGUI planetDescription;
    [SerializeField] private GameObject infoPanel;

    private void Start()
    {
        HideInfo();
    }

    public void ShowInfo(string planetNameText, string planetDescriptionText)
    {
        
        planetName.text = planetNameText;
        planetDescription.text = planetDescriptionText;
        infoPanel.SetActive(true);
    }

    public void HideInfo()
    {
        infoPanel.SetActive(false);
    }
}

