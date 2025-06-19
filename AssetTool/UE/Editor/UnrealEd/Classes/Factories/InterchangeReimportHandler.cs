namespace AssetTool
{
    [JsonAsset("InterchangeReimportHandler")]
    public class UInterchangeReimportHandler : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}