namespace AssetTool
{
    [JsonAsset("PCGCullPointsOutsideActorBoundsSettings")]
    public class UPCGCullPointsOutsideActorBoundsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}