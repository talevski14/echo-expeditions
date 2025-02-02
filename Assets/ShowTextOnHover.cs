using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowTextOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject hoverText;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        hoverText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (button != null && !button.interactable)
        {
            hoverText.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoverText.SetActive(false);
    }
}