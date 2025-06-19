namespace AssetTool
{
    [JsonAsset("Landscape")]
    public class ALandscape : ALandscapeProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}