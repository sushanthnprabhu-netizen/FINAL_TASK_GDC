using UnityEngine;
using UnityEngine.EventSystems;

public class UIButtonSound : MonoBehaviour, IPointerEnterHandler
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("UIManager").GetComponent<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.Play();
    }
}