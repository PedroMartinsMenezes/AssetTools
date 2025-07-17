namespace AssetTool
{
    [JsonAsset("LyraSignificanceManager")]
    public class ULyraSignificanceManager : USignificanceManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}