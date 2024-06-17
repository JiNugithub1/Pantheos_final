using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public InputField NicknameInput;
    public GameObject InitGameBtn;
    public Text ConnectionStatus;

    PhotonView PV;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1080, 660, false);
        ConnectionStatus.text = "서버 연결 안됨..";
        PV = photonView;
    }

    public void Connect()
    {
        if (NicknameInput.text.Equals(""))
            return;
        else
        {
            PhotonNetwork.LocalPlayer.NickName = NicknameInput.text;
            ConnectionStatus.text = "서버에 연결 중..";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("MyRoom", new RoomOptions { MaxPlayers = 2 }, null);
    }
    bool master()
    {
        return PhotonNetwork.LocalPlayer.IsMasterClient;
    }
    public override void OnJoinedRoom()
    {
        ConnectionStatus.text = "서버 연결 완료!";
        if (master()) InitGameBtn.SetActive(true);
    }
    public void InitGame()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount != 2) return;
        PV.RPC("InitGameRPC", RpcTarget.AllViaServer);
    }
    // Update is called once per frame
    [PunRPC]
    void InitGameRPC()
    {
        PhotonNetwork.LoadLevel("Room");
    }
}
