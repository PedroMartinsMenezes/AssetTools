namespace AssetTool
{
    [JsonAsset("LyraTeamCreationComponent")]
    public class ULyraTeamCreationComponent : UGameStateComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}