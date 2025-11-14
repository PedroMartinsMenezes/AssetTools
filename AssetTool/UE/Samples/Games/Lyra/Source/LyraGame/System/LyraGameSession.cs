namespace AssetTool
{
    [JsonAsset("LyraGameSession")]
    public class ALyraGameSession : AGameSession
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}