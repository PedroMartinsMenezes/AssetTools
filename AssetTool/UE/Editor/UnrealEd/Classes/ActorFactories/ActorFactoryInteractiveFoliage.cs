namespace AssetTool
{
    [JsonAsset("ActorFactoryInteractiveFoliage")]
    public class UActorFactoryInteractiveFoliage : UActorFactoryStaticMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}