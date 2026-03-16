using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_Text wordText;
    public TMP_Text usedLettersText;
    public TMP_InputField inputField;
    public TMP_Dropdown difficultyDropdown;

    private WordBank wordBank = new WordBank();
    private Letters letters = new Letters();
    private Stat stat = new Stat();
    private Difficulty difficulty = new Difficulty();

    private string currentWord;

    void Start()
    {
        SetDifficulty();
        StartNewGame();
    }

    public void SetDifficulty()
    {
        int diff = difficultyDropdown.value + 1;
        difficulty.SetDifficult(diff);
        StartNewGame();
    }

    public void StartNewGame()
    {
        currentWord = wordBank.setWord(difficulty.GetDifficult());
        UpdateUI();
    }

    public void SendWord()
    {
        string playerWord = inputField.text;

        letters.checkWord(currentWord, playerWord);
        stat.addStats(3, letters.score);

        UpdateUI();

        inputField.text = "";
    }

    void UpdateUI()
    {
        wordText.text = letters.getWord(currentWord);
        usedLettersText.text = "Использованные буквы: " + letters.getLetter();
    }
}