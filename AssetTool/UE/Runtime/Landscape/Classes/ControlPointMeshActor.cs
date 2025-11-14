namespace AssetTool
{
    [JsonAsset("ControlPointMeshActor")]
    public class AControlPointMeshActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}