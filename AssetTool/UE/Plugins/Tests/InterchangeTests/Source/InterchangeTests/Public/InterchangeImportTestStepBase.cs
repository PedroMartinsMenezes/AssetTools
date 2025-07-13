namespace AssetTool
{
    [JsonAsset("InterchangeImportTestStepBase")]
    public class UInterchangeImportTestStepBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}