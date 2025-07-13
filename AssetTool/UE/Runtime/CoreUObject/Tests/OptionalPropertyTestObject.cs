namespace AssetTool
{
    [JsonAsset("OptionalPropertyTestObject")]
    public class UOptionalPropertyTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}