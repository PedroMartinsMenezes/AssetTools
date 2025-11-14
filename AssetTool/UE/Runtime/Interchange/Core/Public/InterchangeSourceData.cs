namespace AssetTool
{
    [JsonAsset("InterchangeSourceData")]
    public class UInterchangeSourceData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}