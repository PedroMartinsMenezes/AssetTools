namespace AssetTool
{
    [JsonAsset("AvaShapeActor")]
    public class AAvaShapeActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}