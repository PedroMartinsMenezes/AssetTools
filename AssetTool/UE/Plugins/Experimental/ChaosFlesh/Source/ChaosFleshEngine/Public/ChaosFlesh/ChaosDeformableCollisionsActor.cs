namespace AssetTool
{
    [JsonAsset("DeformableCollisionsActor")]
    public class ADeformableCollisionsActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}