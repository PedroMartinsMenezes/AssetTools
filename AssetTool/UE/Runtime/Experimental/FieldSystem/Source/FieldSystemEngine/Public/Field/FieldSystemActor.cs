namespace AssetTool
{
    [JsonAsset("FieldSystemActor")]
    public class AFieldSystemActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}