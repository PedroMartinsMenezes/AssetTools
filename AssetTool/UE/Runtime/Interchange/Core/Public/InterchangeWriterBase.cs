namespace AssetTool
{
    [JsonAsset("InterchangeWriterBase")]
    public class UInterchangeWriterBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}