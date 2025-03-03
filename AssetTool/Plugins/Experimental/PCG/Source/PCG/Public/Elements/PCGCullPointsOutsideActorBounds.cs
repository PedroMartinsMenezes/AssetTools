namespace AssetTool
{
    [JsonAsset("PCGCullPointsOutsideActorBoundsSettings")]
    public class UPCGCullPointsOutsideActorBoundsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}