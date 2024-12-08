namespace AssetTool
{
    [JsonAsset("PlayerStartPIE")]
    public class APlayerStartPIE : APlayerStart
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}