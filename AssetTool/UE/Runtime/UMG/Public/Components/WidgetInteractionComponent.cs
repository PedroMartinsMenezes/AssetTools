namespace AssetTool
{
    [JsonAsset("WidgetInteractionComponent")]
    public class UWidgetInteractionComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}