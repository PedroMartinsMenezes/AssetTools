namespace AssetTool
{
    [JsonAsset("LandscapeProxy")]
    public class ALandscapeProxy : APartitionActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}