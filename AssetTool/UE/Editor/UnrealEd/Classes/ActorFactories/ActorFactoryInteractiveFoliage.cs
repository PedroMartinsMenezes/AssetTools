namespace AssetTool
{
    [JsonAsset("ActorFactoryInteractiveFoliage")]
    public class UActorFactoryInteractiveFoliage : UActorFactoryStaticMesh
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}