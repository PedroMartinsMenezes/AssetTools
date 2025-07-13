namespace AssetTool
{
    [JsonAsset("EditConditionTestObject")]
    public class UEditConditionTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}