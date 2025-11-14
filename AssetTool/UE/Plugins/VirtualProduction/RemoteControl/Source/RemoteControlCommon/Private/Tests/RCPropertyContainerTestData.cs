namespace AssetTool
{
    [JsonAsset("PropertyContainerTestObject")]
    public class UPropertyContainerTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}