namespace AssetTool
{
    [JsonAsset("SpringArmComponent")]
    public class USpringArmComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}