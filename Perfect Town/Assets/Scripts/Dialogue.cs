using UnityEngine;
using TMPro;
using UnityEngine.Events;
using SUPERCharacter;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour, IInteractable
{
    [SerializeField] private string[] charName;
    [SerializeField] private string[] paragraph;
    private TextMeshProUGUI dialogueBox;
    private int step = 0;
    private Image gradient;
    //private Collider range;
    //private bool inRange;

    void Start()
    {
        dialogueBox = GameObject.Find("Dialogue Box").GetComponent<TextMeshProUGUI>();
        gradient = GameObject.Find("Gradient").GetComponent<Image>();
        step = 0;
    }

    void Update()
    {
        if(Physics.CheckSphere(transform.position, 4f, 2))
        {
        }
    }

    public UnityEvent OnInteract;
    public bool Interact()
    {
        OnInteract.Invoke();
        return true;
    }

    public void Para()
    {
        if (step == paragraph.Length)
        {
            EndConvo();
        }
        else
        {
            gradient.enabled = true;
            dialogueBox.text = string.Format("<color=green>{0}</color>\n{1}", charName[step], paragraph[step]);
            step++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        EndConvo();
    }

    private void EndConvo()
    {
        dialogueBox.text = null;
        step = 0;
        gradient.enabled = false;
    }
}
