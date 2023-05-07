namespace ExerciseSuiteAutomationTest.TestDataHolder;

public class EquipmentDataHolder
{
    private readonly List<string> _equipmentIdList;

    public EquipmentDataHolder()
    {
        _equipmentIdList = new List<string>();
    }

    public string GetLastEquipmentId()
    {
        if (_equipmentIdList.Count == 0)
        {
            return string.Empty;
        }

        return _equipmentIdList[^1];
    }

    public void AddEquipmentIdToList(string id)
    {
        _equipmentIdList.Add(id);
    }
}