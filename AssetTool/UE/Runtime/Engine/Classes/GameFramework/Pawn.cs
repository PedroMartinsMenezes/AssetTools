namespace AssetTool
{
    [JsonAsset("Pawn")]
    public class APawn : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}