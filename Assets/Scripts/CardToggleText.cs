using UnityEngine;

public class CardToggleText : MonoBehaviour
{
    
    [SerializeField] private GameObject infoPanel;

    public void ToggleCard()
    {
        if (infoPanel != null)
            infoPanel.SetActive(!infoPanel.activeSelf);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
