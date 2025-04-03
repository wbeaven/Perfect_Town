using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [SerializeField] UnityEvent onClick;
    public bool inRange = false;

    private void OnMouseDown()
    {
        if (inRange)
          onClick.Invoke();
    }
}
