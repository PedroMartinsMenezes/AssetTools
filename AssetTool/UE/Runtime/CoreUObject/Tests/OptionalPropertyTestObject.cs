namespace AssetTool
{
    [JsonAsset("OptionalPropertyTestObject")]
    public class UOptionalPropertyTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}