namespace AssetTool
{
    [JsonAsset("PlayerStartPIE")]
    public class APlayerStartPIE : APlayerStart
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}