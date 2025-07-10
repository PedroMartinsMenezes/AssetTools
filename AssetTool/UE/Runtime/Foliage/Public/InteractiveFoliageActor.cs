namespace AssetTool
{
    [JsonAsset("InteractiveFoliageActor")]
    public class AInteractiveFoliageActor : AStaticMeshActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}