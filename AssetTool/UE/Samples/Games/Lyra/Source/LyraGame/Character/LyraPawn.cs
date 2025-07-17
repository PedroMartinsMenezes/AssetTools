namespace AssetTool
{
    [JsonAsset("LyraPawn")]
    public class ALyraPawn : AModularPawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}