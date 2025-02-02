using UnityEngine;
using TMPro;

public class GoldController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _totalGoldCountText;       
    [SerializeField] public int _totalGoldCount;
    public int _goldIncreaseValue;

    public static GoldController Instance;

    private void Start()
    {
        _totalGoldCountText.SetText(_totalGoldCount.ToString());    
    }
    private void Awake()
    {
        Instance = this;
    }
    public void IncreaseGold()
    {
        _goldIncreaseValue = Random.Range(1, 10);
        _totalGoldCount += _goldIncreaseValue;
        _totalGoldCountText.SetText(_totalGoldCount.ToString());
        //Debug.Log("Kazanılan Puan :" + _goldIncreaseValue + "  Toplam Puan :" + _totalGoldCount);      
    }
    public void DecreasedGold()
    {
        _totalGoldCount--;
        if (_totalGoldCount < 0 )
            _totalGoldCount = 0;
        _totalGoldCountText.SetText(_totalGoldCount.ToString());
    }
}
