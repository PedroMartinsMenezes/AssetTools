namespace AssetTool
{
    [JsonAsset("HoldoutCompositeComponent")]
    public class UHoldoutCompositeComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}