namespace AssetTool
{
    [JsonAsset("InterchangeWriterBase")]
    public class UInterchangeWriterBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}