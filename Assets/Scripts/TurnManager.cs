using UnityEngine;


public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;
    GameObject greecePlayer;
    GameObject koreanPlayer;

    private enum PlayerTurn { Greece, Korean }
    private PlayerTurn currentTurn = PlayerTurn.Greece;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("TurnManager instance created.");
        }
        else
        {
            Debug.Log("TurnManager instance already exists. Destroying this instance.");
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Debug.Log("TurnManager Start method called.");
        StartTurn();
    }

    void StartTurn()
    {
        Debug.Log("StartTurn method called.");
        if (currentTurn == PlayerTurn.Greece)
        {
            greecePlayer = GameObject.FindWithTag("GreecePlayer");
            if (greecePlayer != null)
            {
                Debug.Log("Greece player found.");
                //greecePlayer.GetComponent<Greece>()?.StartTurn();
                Debug.Log("Greece player's turn started.");
            }
            else
            {
                Debug.LogWarning("Greece player not found.");
            }
        }
        else if (currentTurn == PlayerTurn.Korean)
        {
            koreanPlayer = GameObject.FindWithTag("KoreanPlayer");
            if (koreanPlayer != null)
            {
                Debug.Log("Korean player found.");
                //koreanPlayer.GetComponent<Korean>()?.StartTurn();
                Debug.Log("Korean player's turn started.");
            }
            else
            {
                Debug.LogWarning("Korean player not found.");
            }
        }
    }

    public void EndTurn()
    {
        if (currentTurn == PlayerTurn.Greece)
        {
            currentTurn = PlayerTurn.Korean;
        }
        else
        {
            currentTurn = PlayerTurn.Greece;
        }
        StartTurn();
    }
}
