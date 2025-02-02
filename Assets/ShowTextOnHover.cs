using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowTextOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject hoverText;
    private Button button;
    public GameObject message;
    public GameObject enoughLivesMessage;
    public GameObject boughtLivesMessage;
    public GameObject boughtBulletsMessage;

    void Start()
    {
        button = GetComponent<Button>();
        hoverText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (button != null && !button.interactable)
        {
            message.SetActive(false);
            enoughLivesMessage.SetActive(false);
            boughtLivesMessage.SetActive(false);
            boughtBulletsMessage.SetActive(false);
            
            hoverText.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoverText.SetActive(false);
    }
}