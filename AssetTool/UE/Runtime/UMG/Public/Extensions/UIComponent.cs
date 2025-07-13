namespace AssetTool
{
    [JsonAsset("UIComponent")]
    public class UUIComponent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}