namespace AssetTool
{
    [JsonAsset("ApplicationLifecycleComponent")]
    public class UApplicationLifecycleComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}