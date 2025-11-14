namespace AssetTool
{
    [JsonAsset("LevelBounds")]
    public class ALevelBounds : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}