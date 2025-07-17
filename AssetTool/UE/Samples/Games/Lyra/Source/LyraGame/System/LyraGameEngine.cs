namespace AssetTool
{
    [JsonAsset("LyraGameEngine")]
    public class ULyraGameEngine : UGameEngine
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}