namespace AssetTool
{
    [JsonAsset("LyraExperienceManagerComponent")]
    public class ULyraExperienceManagerComponent : UGameStateComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}