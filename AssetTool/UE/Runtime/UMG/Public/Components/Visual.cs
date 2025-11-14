namespace AssetTool
{
    [JsonAsset("Visual")]
    public class UVisual : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}