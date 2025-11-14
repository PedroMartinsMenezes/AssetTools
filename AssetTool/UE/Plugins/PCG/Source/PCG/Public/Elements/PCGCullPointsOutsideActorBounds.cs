namespace AssetTool
{
    [JsonAsset("PCGCullPointsOutsideActorBoundsSettings")]
    public class UPCGCullPointsOutsideActorBoundsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}