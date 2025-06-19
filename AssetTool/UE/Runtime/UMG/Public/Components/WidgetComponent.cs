namespace AssetTool
{
    [JsonAsset("WidgetComponent")]
    public class UWidgetComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}