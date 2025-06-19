namespace AssetTool
{
    [JsonAsset("DeformableCollisionsActor")]
    public class ADeformableCollisionsActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}