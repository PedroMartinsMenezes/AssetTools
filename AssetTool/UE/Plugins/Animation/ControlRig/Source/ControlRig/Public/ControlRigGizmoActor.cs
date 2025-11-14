namespace AssetTool
{
    [JsonAsset("AControlRigShapeActor")]
    public class AControlRigShapeActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}