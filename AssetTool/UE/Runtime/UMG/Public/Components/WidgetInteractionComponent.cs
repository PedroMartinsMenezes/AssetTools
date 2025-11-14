namespace AssetTool
{
    [JsonAsset("WidgetInteractionComponent")]
    public class UWidgetInteractionComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}