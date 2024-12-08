namespace AssetTool
{
    [JsonAsset("SpringArmComponent")]
    public class USpringArmComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}