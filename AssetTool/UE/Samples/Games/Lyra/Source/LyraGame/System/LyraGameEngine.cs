namespace AssetTool
{
    [JsonAsset("LyraGameEngine")]
    public class ULyraGameEngine : UGameEngine
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}