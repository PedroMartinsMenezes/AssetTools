namespace AssetTool
{
    [JsonAsset("HoldoutCompositeComponent")]
    public class UHoldoutCompositeComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}