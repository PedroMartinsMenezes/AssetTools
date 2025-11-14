namespace AssetTool
{
    [JsonAsset("Pawn")]
    public class APawn : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}