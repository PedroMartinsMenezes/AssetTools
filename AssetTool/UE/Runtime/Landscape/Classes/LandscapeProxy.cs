namespace AssetTool
{
    [JsonAsset("LandscapeProxy")]
    public class ALandscapeProxy : APartitionActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}