namespace AssetTool
{
    [JsonAsset("InterchangeWriterBase")]
    public class UInterchangeWriterBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}