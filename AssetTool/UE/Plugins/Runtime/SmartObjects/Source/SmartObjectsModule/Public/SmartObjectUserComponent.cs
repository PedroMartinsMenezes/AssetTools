namespace AssetTool
{
    [JsonAsset("SmartObjectUserComponent")]
    public class USmartObjectUserComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}