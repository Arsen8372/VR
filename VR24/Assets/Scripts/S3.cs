using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.EventSystems;

public class S3 : MonoBehaviour
{
    public Text nm;
    public Text course;
    public Text group;
    public string jsonURL;
    public Jsonclass jsnData;

    void Start()
    {
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        Debug.Log("��������...");
        var uwr = new UnityWebRequest(jsonURL);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var resultFile = Path.Combine(Application.persistentDataPath, "result.json");
        var dh = new DownloadHandlerFile(resultFile);
        dh.removeFileOnAbort = true;
        uwr.downloadHandler = dh;
        yield return uwr.SendWebRequest();
        Debug.Log("���� �������� �� ����:" + resultFile);
        jsnData = JsonUtility.FromJson<Jsonclass>(File.ReadAllText(Application.persistentDataPath + "/result.json"));
        nm.text = jsnData.Name;
        course.text = jsnData.Course;
        group.text = jsnData.Group;
        yield return StartCoroutine(getData());
    }
    [System.Serializable]

    public class Jsonclass
    {
        public string Name;
        public string Course;
        public string Group;
    }
}
