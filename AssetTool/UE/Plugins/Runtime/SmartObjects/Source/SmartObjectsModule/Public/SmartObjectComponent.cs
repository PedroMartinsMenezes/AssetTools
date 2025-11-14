namespace AssetTool
{
    [JsonAsset("SmartObjectComponent")]
    public class USmartObjectComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}