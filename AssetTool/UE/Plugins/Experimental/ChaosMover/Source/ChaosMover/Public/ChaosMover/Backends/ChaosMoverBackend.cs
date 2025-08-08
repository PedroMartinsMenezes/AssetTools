namespace AssetTool
{
    [JsonAsset("ChaosMoverBackendComponent")]
    public class UChaosMoverBackendComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}