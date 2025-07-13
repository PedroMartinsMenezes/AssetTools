namespace AssetTool
{
    [JsonAsset("AutoRTFMTestObject")]
    public class UAutoRTFMTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}