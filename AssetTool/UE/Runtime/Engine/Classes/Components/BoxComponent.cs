namespace AssetTool
{
    [JsonAsset("BoxComponent")]
    public class UBoxComponent : UShapeComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}