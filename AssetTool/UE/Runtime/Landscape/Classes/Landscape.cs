namespace AssetTool
{
    [JsonAsset("Landscape")]
    public class ALandscape : ALandscapeProxy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}