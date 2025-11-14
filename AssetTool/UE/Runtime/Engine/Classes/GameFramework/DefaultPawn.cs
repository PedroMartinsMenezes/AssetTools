namespace AssetTool
{
    [JsonAsset("DefaultPawn")]
    public class ADefaultPawn : APawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}