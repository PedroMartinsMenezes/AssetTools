namespace AssetTool
{
    [JsonAsset("LyraWorldCollectable")]
    public class ALyraWorldCollectable : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}