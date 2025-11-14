namespace AssetTool
{
    [JsonAsset("ActorFactoryBasicShape")]
    public class UActorFactoryBasicShape : UActorFactoryStaticMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}