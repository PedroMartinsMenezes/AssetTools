namespace AssetTool
{
    [JsonAsset("WidgetComponent")]
    public class UWidgetComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}