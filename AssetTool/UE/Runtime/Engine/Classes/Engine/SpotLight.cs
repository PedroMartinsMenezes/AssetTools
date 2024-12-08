namespace AssetTool
{
    [JsonAsset("SpotLight")]
    public class ASpotLight : ALight
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}