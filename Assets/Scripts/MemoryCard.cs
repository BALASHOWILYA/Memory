using UnityEngine;

public class MemoryCard : MonoBehaviour
{

    //����������, ������� ����������  �� ������ Inspector.
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;
    //�������
    [SerializeField] private Sprite image;

    private int _id;
    //�������
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = image;
    }

    // ����������� ������� ������ 
    public int id
    {
        get { return _id; }
    }

    //�������� �����, ������� ����� ������������ ������ �������� ��� �������� ���������� ������� ����� ��������.
    public void SetCard(int id, Sprite image)
    {
        _id = id;
        // ������������ ������ ���������� SpriteRenderer. 
       cardBack.GetComponent<SpriteRenderer>().sprite = image;
    }

    //��� ������� ���������� ����� ������ �� �������.
    public void OnMouseDown()
    {

        //��� �����������  ����������� ������ � ������, ����� ������ �������/�����.
        if (cardBack.activeSelf)
        {
            //������ ������ ����������/��������� 
            cardBack.SetActive(false);
        }
       
    }
}
