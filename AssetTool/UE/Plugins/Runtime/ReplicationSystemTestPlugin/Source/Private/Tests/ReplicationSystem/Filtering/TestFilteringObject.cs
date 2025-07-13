namespace AssetTool
{
    [JsonAsset("TestFilteringObject")]
    public class UTestFilteringObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}