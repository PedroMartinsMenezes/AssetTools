namespace AssetTool
{
    [JsonAsset("UIFrameworkPlayerComponent")]
    public class UUIFrameworkPlayerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}