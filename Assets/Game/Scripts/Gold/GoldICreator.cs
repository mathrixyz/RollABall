using Unity.Collections;
using UnityEditor;
using UnityEngine;
public class GoldCreator : MonoBehaviour
{
    #region SINGLETON
    public static GoldCreator instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion



    [SerializeField] private GameObject _goldPrefab;
    //[SerializeField] private int _goldCount;
    [SerializeField] private float _spacing;
    [SerializeField] private int _column;
    [SerializeField] private int _row;
    [SerializeField] private Vector3 _startPosition;

    public int totalGoldCount;

    private void Start()
    {
        totalGoldCount = _row * _column;
        CreateGold();
    }

    private void CreateGold()
    {
        for (int i = 0; i < _row; i++)
        {
            for (int j = 0; j < _column; j++)
            {
                Instantiate(_goldPrefab, new Vector3(_startPosition.x + i * _spacing, _startPosition.y, _startPosition.z+j*_spacing), Quaternion.identity);
            }
            
        }
    }  
    public void DecreaseGoldCount()
    {
        totalGoldCount--;
        if (totalGoldCount == 0) { UiManager.Instance.OpenPanel(UiManager.Instance.nextLevelPanel); }
    }
}