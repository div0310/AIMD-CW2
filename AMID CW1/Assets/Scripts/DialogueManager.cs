using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Button[] choiceButtons;

    private Dialogue currentDialogue;

    public void StartDialogue(Dialogue dialogue)
    {
        currentDialogue = dialogue;
        UpdateUI();
        dialoguePanel.SetActive(true);
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        // Any additional clean-up logic can go here
    }

    public void SelectChoice(int choiceIndex)
    {
        DialogueOption selectedOption = currentDialogue.options[choiceIndex];
        // Handle selected option (e.g., advance to next dialogue)
    }

    private void UpdateUI()
    {
        nameText.text = currentDialogue.npcName;
        dialogueText.text = currentDialogue.npcLine;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            if (i < currentDialogue.options.Length)
            {
                choiceButtons[i].gameObject.SetActive(true);
                choiceButtons[i].GetComponentInChildren<TMP_Text>().text = currentDialogue.options[i].text;
            }
            else
            {
                choiceButtons[i].gameObject.SetActive(false);
            }
        }
    }
}

[System.Serializable]
public class Dialogue
{
    public string npcName;
    public string npcLine;
    public DialogueOption[] options;
}

[System.Serializable]
public class DialogueOption
{
    public string text;
    // Add any additional properties you need for the option
}