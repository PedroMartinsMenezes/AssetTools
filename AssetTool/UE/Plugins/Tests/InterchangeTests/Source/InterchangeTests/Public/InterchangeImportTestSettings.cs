namespace AssetTool
{
    [JsonAsset("InterchangeImportTestSettings")]
    public class UInterchangeImportTestSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}