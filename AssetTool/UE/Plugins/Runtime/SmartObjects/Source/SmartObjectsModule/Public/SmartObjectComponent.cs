namespace AssetTool
{
    [JsonAsset("SmartObjectComponent")]
    public class USmartObjectComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}