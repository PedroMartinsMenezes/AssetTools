namespace AssetTool
{
    [JsonAsset("InputComponent")]
    public class UInputComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}