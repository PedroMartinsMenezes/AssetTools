namespace AssetTool
{
    [JsonAsset("InstancedActorsRepresentationActorManagement")]
    public class UInstancedActorsRepresentationActorManagement : UMassRepresentationActorManagement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}