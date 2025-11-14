namespace AssetTool
{
    [JsonAsset("LyraSignificanceManager")]
    public class ULyraSignificanceManager : USignificanceManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}