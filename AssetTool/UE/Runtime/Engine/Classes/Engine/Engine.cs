namespace AssetTool
{
    [JsonAsset("Engine")]
    public class UEngine : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}