namespace AssetTool
{
    [JsonAsset("TestFilteringObject")]
    public class UTestFilteringObject : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}