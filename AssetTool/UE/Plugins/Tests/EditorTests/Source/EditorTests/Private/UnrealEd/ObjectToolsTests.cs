namespace AssetTool
{
    [JsonAsset("ObjectToolsTestObject")]
    public class UObjectToolsTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}