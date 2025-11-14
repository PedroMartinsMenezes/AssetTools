namespace AssetTool
{
    [JsonAsset("IKRigComponent")]
    public class UIKRigComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}