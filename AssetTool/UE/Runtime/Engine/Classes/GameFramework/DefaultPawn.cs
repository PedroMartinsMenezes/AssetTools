namespace AssetTool
{
    [JsonAsset("DefaultPawn")]
    public class ADefaultPawn : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}