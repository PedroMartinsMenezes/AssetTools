namespace AssetTool
{
    [JsonAsset("LyraWorldCollectable")]
    public class ALyraWorldCollectable : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}