namespace AssetTool
{
    [JsonAsset("BoxComponent")]
    public class UBoxComponent : UShapeComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}