namespace AssetTool
{
    [JsonAsset("Pawn")]
    public class APawn : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}