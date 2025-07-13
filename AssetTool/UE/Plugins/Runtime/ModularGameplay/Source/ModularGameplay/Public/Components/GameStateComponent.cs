namespace AssetTool
{
    [JsonAsset("GameStateComponent")]
    public class UGameStateComponent : UGameFrameworkComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}