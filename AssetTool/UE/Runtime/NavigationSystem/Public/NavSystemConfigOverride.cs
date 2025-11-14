namespace AssetTool
{
    [JsonAsset("NavSystemConfigOverride")]
    public class ANavSystemConfigOverride : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}