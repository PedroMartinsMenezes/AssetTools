namespace AssetTool
{
    [JsonAsset("InterchangeImportTestPlanFactory")]
    public class UInterchangeImportTestPlanFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}