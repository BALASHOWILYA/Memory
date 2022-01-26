using UnityEngine;

public class MemoryCard : MonoBehaviour
{

    //����������, ������� ����������  �� ������ Inspector.
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;
   

    private int _id;
   

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
