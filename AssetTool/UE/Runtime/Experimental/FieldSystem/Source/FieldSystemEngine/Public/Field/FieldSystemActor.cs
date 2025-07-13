namespace AssetTool
{
    [JsonAsset("FieldSystemActor")]
    public class AFieldSystemActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}