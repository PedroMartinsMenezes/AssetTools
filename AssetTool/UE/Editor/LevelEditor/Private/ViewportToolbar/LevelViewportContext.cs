namespace AssetTool
{
    [JsonAsset("LevelViewportContext")]
    public class ULevelViewportContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}