using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject StartGameBtn;
    public GameObject GreeceBtn;
    public GameObject KoreanBtn;
    public Text GreecePlayer;
    public Text KoreanPlayer;
    PhotonView PV;

    void Start()
    {
        PV = photonView;
    }

    void Update()
    {
        if (master() && GreecePlayer.text != "" && KoreanPlayer.text != "")
        {
            StartGameBtn.SetActive(true);
        }
    }

    public void GreeceBtnOnClick()
    {
        if (PhotonNetwork.LocalPlayer != null && !string.IsNullOrEmpty(PhotonNetwork.LocalPlayer.NickName))
        {
            KoreanBtn.SetActive(false);
            string playerName = PhotonNetwork.LocalPlayer.NickName;
            PV.RPC("RPC_UpdatePlayer", RpcTarget.All, "Greece", playerName);
        }
        else
        {
            Debug.LogError("LocalPlayer's NickName is null or empty.");
        }
    }

    public void KoreanBtnOnClick()
    {
        if (PhotonNetwork.LocalPlayer != null && !string.IsNullOrEmpty(PhotonNetwork.LocalPlayer.NickName))
        {
            GreeceBtn.SetActive(false);
            string playerName = PhotonNetwork.LocalPlayer.NickName;
            PV.RPC("RPC_UpdatePlayer", RpcTarget.All, "Korean", playerName);
        }
        else
        {
            Debug.LogError("LocalPlayer's NickName is null or empty.");
        }
    }

    bool master()
    {
        return PhotonNetwork.IsMasterClient;
    }

    public void startButtonOnClick()
    {
        if (master())
        {
            PhotonNetwork.AutomaticallySyncScene = true;
            PV.RPC("StartGame", RpcTarget.AllViaServer);
        }
    }

    [PunRPC]
    void RPC_UpdatePlayer(string country, string playerName)
    {
        if (country == "Greece")
        {
            GreeceBtn.SetActive(false);
            GreecePlayer.text = playerName;
        }
        else if (country == "Korean")
        {
            KoreanBtn.SetActive(false);
            KoreanPlayer.text = playerName;
        }
    }

    [PunRPC]
    void StartGame()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
