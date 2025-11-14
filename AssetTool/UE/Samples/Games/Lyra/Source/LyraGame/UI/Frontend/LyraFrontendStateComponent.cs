namespace AssetTool
{
    [JsonAsset("LyraFrontendStateComponent")]
    public class ULyraFrontendStateComponent : UGameStateComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}