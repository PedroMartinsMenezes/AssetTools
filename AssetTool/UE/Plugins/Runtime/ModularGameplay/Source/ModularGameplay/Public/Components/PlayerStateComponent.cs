namespace AssetTool
{
    [JsonAsset("PlayerStateComponent")]
    public class UPlayerStateComponent : UGameFrameworkComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}