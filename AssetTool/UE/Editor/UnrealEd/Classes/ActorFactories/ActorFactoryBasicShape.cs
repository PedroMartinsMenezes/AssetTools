namespace AssetTool
{
    [JsonAsset("ActorFactoryBasicShape")]
    public class UActorFactoryBasicShape : UActorFactoryStaticMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}