namespace AssetTool
{
    [JsonAsset("LyraFrontendStateComponent")]
    public class ULyraFrontendStateComponent : UGameStateComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}