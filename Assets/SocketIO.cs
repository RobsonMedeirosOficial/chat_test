using Firesplash.UnityAssets.SocketIO;
using System.Collections;
using UnityEngine;
using TMPro;
public class SocketIO : MonoBehaviour
{
    public TextMeshProUGUI callback;
    public TMP_InputField inputField;
    SocketIOCommunicator sioCom;
    public Transform grid;
    public TextMeshProUGUI msg;
    public string MSG;
    // Start is called before the first frame update
    void Start()
    {
        sioCom = GetComponent<SocketIOCommunicator>();
        sioCom.Instance.On("connect", (payload) =>
        {
            Debug.Log("Connected! Socket ID: " + sioCom.Instance.SocketID);
            //sioCom.Instance.Emit("CLIENT", "NOVA REQUISIÇÃO! (" + sioCom.Instance.SocketID + ")", true);



            
            sioCom.Instance.On("msgUpdate", (data) =>
            {
                print("Received: " + data);
                AddText(data);
                
            });
        });
        




        sioCom.Instance.Connect();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Action()
    {
        //sioCom.Instance.Emit("CLIENT", "NOVA REQUISIÇÃO! ("+ sioCom.Instance.SocketID + ")",true);
        if (inputField && inputField.text!="")
        {
            sioCom.Instance.Emit("CLIENT", inputField.text, true);
            inputField.text = "";

        }

    }

    public void AddText(string txt)
    {
        if (grid && msg)
        {
           var m = Instantiate(msg, Vector3.zero, Quaternion.identity, grid);
            m.text = txt;
        }
    }
}
