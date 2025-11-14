namespace AssetTool
{
    [JsonAsset("ApplicationLifecycleComponent")]
    public class UApplicationLifecycleComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}