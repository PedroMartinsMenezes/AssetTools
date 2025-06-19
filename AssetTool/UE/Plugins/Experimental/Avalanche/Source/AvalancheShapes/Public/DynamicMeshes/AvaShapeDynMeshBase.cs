namespace AssetTool
{
    [JsonAsset("AvaShapeDynamicMeshBase")]
    public class UAvaShapeDynamicMeshBase : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}