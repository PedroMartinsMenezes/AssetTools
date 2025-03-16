namespace AssetTool
{
    [JsonAsset("TextPropertyTestObject")]
    public class UTextPropertyTestObject : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}