namespace AssetTool
{
    [JsonAsset("IKRigComponent")]
    public class UIKRigComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}