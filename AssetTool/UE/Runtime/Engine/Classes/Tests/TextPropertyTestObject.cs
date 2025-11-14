namespace AssetTool
{
    [JsonAsset("TextPropertyTestObject")]
    public class UTextPropertyTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}