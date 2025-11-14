namespace AssetTool
{
    [JsonAsset("LyraPawn")]
    public class ALyraPawn : AModularPawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}