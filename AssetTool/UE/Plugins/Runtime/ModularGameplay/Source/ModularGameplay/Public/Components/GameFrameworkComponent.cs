namespace AssetTool
{
    [JsonAsset("GameFrameworkComponent")]
    public class UGameFrameworkComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}