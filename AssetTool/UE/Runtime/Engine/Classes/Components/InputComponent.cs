namespace AssetTool
{
    [JsonAsset("InputComponent")]
    public class UInputComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}