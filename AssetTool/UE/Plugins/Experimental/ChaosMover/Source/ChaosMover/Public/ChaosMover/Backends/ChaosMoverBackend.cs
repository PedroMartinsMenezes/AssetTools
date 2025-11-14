namespace AssetTool
{
    [JsonAsset("ChaosMoverBackendComponent")]
    public class UChaosMoverBackendComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}