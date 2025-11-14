namespace AssetTool
{
    [JsonAsset("InterchangeImportTestStepBase")]
    public class UInterchangeImportTestStepBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}