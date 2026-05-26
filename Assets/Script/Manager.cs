using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image hoverImage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Color color = hoverImage.color;
        color.a = 0.25f;
        hoverImage.color = color;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Color color = hoverImage.color;
        color.a = 0f;
        hoverImage.color = color;
    }
}