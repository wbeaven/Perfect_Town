using UnityEngine;

public class Gatcha : MonoBehaviour
{
    void Start()
    {
        Chance();
    }

    void Update()
    {
        
    }

    private void Chance()
    {
        int randomNum = Mathf.Abs(Random.Range(1, 5));

        switch (randomNum)
        {
            case 1: print("picked 1"); break;
            case 2: print("picked 2"); break;
            case 3: print("picked 3"); break;
            case 4: print("picked 4"); break;
            default: print("error"); break;
        }
    }
}
