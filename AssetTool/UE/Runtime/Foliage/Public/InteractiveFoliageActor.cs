namespace AssetTool
{
    [JsonAsset("InteractiveFoliageActor")]
    public class AInteractiveFoliageActor : AStaticMeshActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}