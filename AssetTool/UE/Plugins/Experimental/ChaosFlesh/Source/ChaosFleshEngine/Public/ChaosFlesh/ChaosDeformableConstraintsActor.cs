namespace AssetTool
{
    [JsonAsset("DeformableConstraintsActor")]
    public class ADeformableConstraintsActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}