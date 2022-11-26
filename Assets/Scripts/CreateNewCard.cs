using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateNewCard : MonoBehaviour
{
    public Card cardPrefab;
    public Transform contentGrid;
    public TMP_Dropdown addCard;
    public GameObject addCardPrefab;

    public void CreateNewCardinGrid()
    {
        Card newCard = Instantiate(cardPrefab, contentGrid);

        newCard.title.text = addCard.options[addCard.value].text;
        newCard.description.text = "this sensor its for wats";
        newCard.typeValue.text = "wats";
        newCard.value.text = "330w";

        GameObject addNewCard = Instantiate(addCardPrefab,contentGrid);
        TMP_Dropdown addNewCardDropDown = addNewCard.GetComponent<TMP_Dropdown>();
        addNewCardDropDown.value = addCard.value;
        addNewCardDropDown.onValueChanged.AddListener((value) => CreateNewCardinGrid());
        Destroy(addCard.gameObject);
        addCard = addNewCardDropDown;
    }
}
