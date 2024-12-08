namespace AssetTool
{
    [JsonAsset("DefaultPawn")]
    public class ADefaultPawn : APawn
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}