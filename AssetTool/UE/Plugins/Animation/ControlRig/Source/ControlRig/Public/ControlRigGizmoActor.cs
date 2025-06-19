namespace AssetTool
{
    [JsonAsset("AControlRigShapeActor")]
    public class AControlRigShapeActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}