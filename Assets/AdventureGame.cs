using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] States startingState;

    States state;

    private void ManageState() {
        var nextStates = state.GetNextStates();
        for (int i=0; i < nextStates.Length; i++) {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i)) {
                state = nextStates[i];
            }
        }
        textComponent.text = state.GetStateStory();
    }

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();

        // Check if 'q' key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Quit the application
            Application.Quit();
        }
    }
}

