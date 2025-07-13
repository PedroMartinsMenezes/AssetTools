namespace AssetTool
{
    [JsonAsset("ObjectToolsTestObject")]
    public class UObjectToolsTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}