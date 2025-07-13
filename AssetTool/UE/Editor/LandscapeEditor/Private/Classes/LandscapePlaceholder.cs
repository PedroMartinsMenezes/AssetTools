namespace AssetTool
{
    [JsonAsset("LandscapePlaceholder")]
    public class ALandscapePlaceholder : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}