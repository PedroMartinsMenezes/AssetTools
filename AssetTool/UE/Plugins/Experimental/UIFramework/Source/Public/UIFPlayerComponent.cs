namespace AssetTool
{
    [JsonAsset("UIFrameworkPlayerComponent")]
    public class UUIFrameworkPlayerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}