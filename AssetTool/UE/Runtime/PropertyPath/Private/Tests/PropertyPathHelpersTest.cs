namespace AssetTool
{
    [JsonAsset("PropertyPathTestObject")]
    public class UPropertyPathTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}