namespace AssetTool
{
    [JsonAsset("PlayerStartPIE")]
    public class APlayerStartPIE : APlayerStart
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}