namespace AssetTool
{
    [JsonAsset("DeformableCollisionsActor")]
    public class ADeformableCollisionsActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}