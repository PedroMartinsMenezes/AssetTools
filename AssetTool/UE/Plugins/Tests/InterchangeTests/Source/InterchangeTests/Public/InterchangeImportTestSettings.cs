namespace AssetTool
{
    [JsonAsset("InterchangeImportTestSettings")]
    public class UInterchangeImportTestSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}