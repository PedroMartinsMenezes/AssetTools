namespace AssetTool
{
    [JsonAsset("InstancedActorsRepresentationActorManagement")]
    public class UInstancedActorsRepresentationActorManagement : UMassRepresentationActorManagement
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}