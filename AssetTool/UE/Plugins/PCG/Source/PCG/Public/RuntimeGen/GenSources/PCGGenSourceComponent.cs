namespace AssetTool
{
    [JsonAsset("PCGGenSourceComponent")]
    public class UPCGGenSourceComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}