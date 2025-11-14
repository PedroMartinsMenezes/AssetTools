namespace AssetTool
{
    [JsonAsset("DeformableConstraintsActor")]
    public class ADeformableConstraintsActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}