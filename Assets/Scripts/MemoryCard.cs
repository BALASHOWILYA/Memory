using UnityEngine;

public class MemoryCard : MonoBehaviour
{

    //Переменная, которая появляется  на панели Inspector.
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;
   

    private int _id;
   

    // Добавленная функция чтения 
    public int id
    {
        get { return _id; }
    }

    //Открытый метод, которым могут пользоваться другие сценарии для передачи указанному объекту новых спрайтов.
    public void SetCard(int id, Sprite image)
    {
        _id = id;
        // Сопоставляем спрайт компоненту SpriteRenderer. 
       cardBack.GetComponent<SpriteRenderer>().sprite = image;
    }

    //Это функция вызывается после щелчка на объекте.
    public void OnMouseDown()
    {

        //Код деактивации  запускается только в случае, когда объект активен/виден.
        if (cardBack.activeSelf)
        {
            //Делает объект неактивным/невидимым 
            cardBack.SetActive(false);
        }
       
    }
}
