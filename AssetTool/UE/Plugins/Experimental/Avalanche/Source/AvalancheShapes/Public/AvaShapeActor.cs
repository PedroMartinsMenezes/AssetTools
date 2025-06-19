namespace AssetTool
{
    [JsonAsset("AvaShapeActor")]
    public class AAvaShapeActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}