
//using WebSocketSharp;
using UnityEngine;
using TMPro;

public class SocketTest : MonoBehaviour
{
    public TextMeshProUGUI callBack;
    public string call="";
    //WebSocket ws;
    public PlayerInfo playerInfo = new PlayerInfo();
    public bool isReceive = false;
    // Start is called before the first frame update
    void Start()
    {
        //ws = new WebSocket("ws://dev-tblite-game-server-lymuo4q6ia-uc.a.run.app/");
        //ws = new WebSocket("ws://localhost:3000/");
        //ws.OnMessage += (sender, e) =>
        //{
        //    //Debug.Log("Received menssage from " + ((WebSocket)sender).Url + ", data: " + e.Data);
        //    Debug.Log("Connected!");

        //    callBack.text += "Connected!    |     ";
        //    call += callBack.text;
        //};
        //ws.Connect();
        //ws.OnOpen += (sender, e) =>
        //{
        //    Debug.Log("Connected!");
        //    callBack.text += "Connected!    |     ";
        //    call += callBack.text;
        //};

    }

    // Update is called once per frame
    void Update()
    {
        //if (ws.IsAlive && !isReceive)
        //{
        //    ws.OnMessage += (sender, e) =>
        //    {
        //        // Recebe dados do servidor e preenche a classe PlayerInfo ---------------------------
        //        Debug.Log(e.Data);
        //        //playerInfo = JsonUtility.FromJson<PlayerInfo>(e.Data);
        //        //callBack.text += "Receive: " + e.Data+"      |     ";
        //        //call += callBack.text;
        //        //--------------------------------------------------------
        //    };
        //    //isReceive = true;
        //}
    }

    public void Action()
    {
        Debug.Log("Action!");
        //if (ws == null)
        //{
        //    return;
        //}

        // Preenche a classe PlayerInfo antes de enviar para o servidor ----------------------------
        playerInfo.health = 1985;
        playerInfo.lives = 37;
        playerInfo.playerName = "Roger";
        // Converte a classe em string json
        string json = JsonUtility.ToJson(playerInfo).ToString();
        // Envia para o servidor
        //ws.Send(json);
        Debug.Log("Send: " + json);
        //callBack.text ="Send: "+ json + "      |     ";
        //call += callBack.text;
        // --------------------------------------------------


    }
}

[System.Serializable]
public class PlayerInfo
{
    public string playerName;
    public int lives;
    public float health;
}



