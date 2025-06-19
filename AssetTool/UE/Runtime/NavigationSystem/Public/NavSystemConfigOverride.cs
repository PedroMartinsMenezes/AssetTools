namespace AssetTool
{
    [JsonAsset("NavSystemConfigOverride")]
    public class ANavSystemConfigOverride : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}