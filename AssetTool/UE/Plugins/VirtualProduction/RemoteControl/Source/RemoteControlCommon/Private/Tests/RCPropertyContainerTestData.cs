namespace AssetTool
{
    [JsonAsset("PropertyContainerTestObject")]
    public class UPropertyContainerTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}