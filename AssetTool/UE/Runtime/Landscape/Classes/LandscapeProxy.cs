namespace AssetTool
{
    [JsonAsset("LandscapeProxy")]
    public class ALandscapeProxy : APartitionActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}