namespace AssetTool
{
    [JsonAsset("IKRigComponent")]
    public class UIKRigComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}