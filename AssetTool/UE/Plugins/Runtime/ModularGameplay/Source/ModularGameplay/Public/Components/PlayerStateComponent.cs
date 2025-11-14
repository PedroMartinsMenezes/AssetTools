namespace AssetTool
{
    [JsonAsset("PlayerStateComponent")]
    public class UPlayerStateComponent : UGameFrameworkComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}