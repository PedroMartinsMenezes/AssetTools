namespace AssetTool
{
    [JsonAsset("SmartObjectUserComponent")]
    public class USmartObjectUserComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}