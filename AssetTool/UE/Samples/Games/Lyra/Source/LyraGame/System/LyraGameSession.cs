namespace AssetTool
{
    [JsonAsset("LyraGameSession")]
    public class ALyraGameSession : AGameSession
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}