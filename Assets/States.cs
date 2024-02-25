using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "States")]
public class States : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] States[] nextStates;

    public States[] GetNextStates() {
        return nextStates;
    }

    public string GetStateStory() {
        return storyText;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
