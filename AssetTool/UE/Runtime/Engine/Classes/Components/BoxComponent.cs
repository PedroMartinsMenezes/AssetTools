namespace AssetTool
{
    [JsonAsset("BoxComponent")]
    public class UBoxComponent : UShapeComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}