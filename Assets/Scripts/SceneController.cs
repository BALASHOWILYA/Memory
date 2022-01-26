using UnityEngine;

public class SceneController : MonoBehaviour
{
    //Значение, указывающие количество ячеек сетки и их расстояние друг от друга 
    public const int gridRows = 2;
    public const int gridCols = 4;
    public const float offsetX = 2f;
    public const float offsetY = 2.5f;

    //Ссылка для карты в сцене.
    [SerializeField] private MemoryCard originalCard;
    //Массив для ссылок на ресурсы-спрайты.
    [SerializeField] private Sprite[] images;

    // Start is called before the first frame update
    void Start()
    {
        //Положение первой карты; положение остальных карт отсчитывается от этой точки. 
        Vector3 startPos = originalCard.transform.position;

        // Объявляем целочисленный массив с парами индентификаторов для всех четырех спрайтов с изображениями карт.
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3 };
        //Вызываем функцию, перемешивающую элементы массива 
        numbers = ShuffleArray(numbers);

        //Вложенные цыклы, задающие как столбцы, как и строки сетки.
        for(int i=0; i < gridCols; i++)
        {
            for(int j = 0; j < gridRows; j++)
            {
                //Ссылка на контейнер для исходной карты или ее копий.
                MemoryCard card;
                if(i==0 && j==0)
                {
                    card = originalCard;
                } else
                {
                    card = Instantiate(originalCard) as MemoryCard;
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                //Вызов открытого метода, добавленного в сценарий MemoryCard.
                card.SetCard(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = -(offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }

      
    }

    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;

        }
        return newArray;
    }
}
