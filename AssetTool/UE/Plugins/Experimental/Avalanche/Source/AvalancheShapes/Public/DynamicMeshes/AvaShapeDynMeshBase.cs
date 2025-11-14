namespace AssetTool
{
    [JsonAsset("AvaShapeDynamicMeshBase")]
    public class UAvaShapeDynamicMeshBase : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}