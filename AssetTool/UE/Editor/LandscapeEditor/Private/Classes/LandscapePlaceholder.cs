namespace AssetTool
{
    [JsonAsset("LandscapePlaceholder")]
    public class ALandscapePlaceholder : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}