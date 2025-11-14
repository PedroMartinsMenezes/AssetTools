namespace AssetTool
{
    [JsonAsset("Landscape")]
    public class ALandscape : ALandscapeProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}