namespace AssetTool
{
    [JsonAsset("ActorFactoryBasicShape")]
    public class UActorFactoryBasicShape : UActorFactoryStaticMesh
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}