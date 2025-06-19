namespace AssetTool
{
    [JsonAsset("ActorFactoryInteractiveFoliage")]
    public class UActorFactoryInteractiveFoliage : UActorFactoryStaticMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}