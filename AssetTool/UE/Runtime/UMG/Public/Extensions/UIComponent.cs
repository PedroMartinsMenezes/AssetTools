namespace AssetTool
{
    [JsonAsset("UIComponent")]
    public class UUIComponent : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}