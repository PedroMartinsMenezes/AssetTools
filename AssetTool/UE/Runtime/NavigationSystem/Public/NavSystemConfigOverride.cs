namespace AssetTool
{
    [JsonAsset("NavSystemConfigOverride")]
    public class ANavSystemConfigOverride : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}