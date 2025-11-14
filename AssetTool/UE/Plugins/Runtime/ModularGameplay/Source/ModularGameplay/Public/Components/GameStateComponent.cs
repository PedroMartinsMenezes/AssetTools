namespace AssetTool
{
    [JsonAsset("GameStateComponent")]
    public class UGameStateComponent : UGameFrameworkComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}