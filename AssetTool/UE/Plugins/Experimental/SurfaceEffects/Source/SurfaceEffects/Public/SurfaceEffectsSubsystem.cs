namespace AssetTool
{
    [JsonAsset("SurfaceEffectRule")]
    public class USurfaceEffectRule : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SurfaceEffectsSubsystem")]
    public class USurfaceEffectsSubsystem : UGameInstanceSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}