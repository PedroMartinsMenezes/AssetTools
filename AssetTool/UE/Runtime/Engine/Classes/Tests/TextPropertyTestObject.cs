namespace AssetTool
{
    [JsonAsset("TextPropertyTestObject")]
    public class UTextPropertyTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}